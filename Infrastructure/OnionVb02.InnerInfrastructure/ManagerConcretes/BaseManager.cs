using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.DTOInterfaces;
using OnionVb02.Application.ManagerInterfaces;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.InnerInfrastructure.ManagerConcretes
{
    public abstract class BaseManager<T, U> : IManager<T, U>
        where T : class, IDto
        where U : class, IEntity
    {
        private readonly IRepository<U> _repository;
        protected readonly IMapper _mapper;
        private readonly IValidator<T>? _validator; 

        public BaseManager(IRepository<U> repository, IMapper mapper, IServiceProvider serviceProvider)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = serviceProvider.GetService<IValidator<T>>();
        }

        public virtual async Task CreateAsync(T entity)
        {
            if (_validator != null)
            {
                var validationResult = await _validator.ValidateAsync(entity);
                if (!validationResult.IsValid)
                {
                    var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                    throw new Exception($"Doğrulama Hatası: {errors}");
                }
            }

            try
            {
                U domainEntity = _mapper.Map<U>(entity);
                domainEntity.CreatedDate = DateTime.Now;
                domainEntity.Status = Domain.Enums.DataStatus.Inserted;

                await _repository.CreateAsync(domainEntity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kayıt oluşturulurken hata meydana geldi: {ex.Message}", ex);
            }
        }

        public virtual async Task UpdateAsync(T entity)
        {
            if (_validator != null)
            {
                var validationResult = await _validator.ValidateAsync(entity);
                if (!validationResult.IsValid)
                {
                    var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage));
                    throw new Exception($"Doğrulama Hatası: {errors}");
                }
            }

            try
            {
                U originalValue = await _repository.GetByIdAsync(entity.Id);
                if (originalValue == null) throw new Exception("Güncellenecek kayıt bulunamadı.");

                U newValue = _mapper.Map<U>(entity);
                newValue.CreatedDate = originalValue.CreatedDate; 
                newValue.UpdatedDate = DateTime.Now;
                newValue.Status = Domain.Enums.DataStatus.Updated;

                await _repository.UpdateAsync(originalValue, newValue);
            }
            catch (Exception ex)
            {
                throw new Exception($"Güncelleme sırasında hata meydana geldi: {ex.Message}", ex);
            }
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            try
            {
                List<U> values = await _repository.GetAllAsync();
                return _mapper.Map<List<T>>(values);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veriler listelenirken hata oluştu: {ex.Message}", ex);
            }
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            try
            {
                U value = await _repository.GetByIdAsync(id);
                return _mapper.Map<T>(value);
            }
            catch (Exception ex)
            {
                throw new Exception($"Veri getirilirken hata oluştu: {ex.Message}", ex);
            }
        }


        public virtual List<T> GetActives()
        {
            try
            {
                List<U> values = _repository.Where(x => x.Status != Domain.Enums.DataStatus.Deleted).ToList();
                return _mapper.Map<List<T>>(values);
            }
            catch (Exception ex)
            {
                throw new Exception($"Aktif veriler getirilirken hata: {ex.Message}", ex);
            }
        }

        public virtual List<T> GetPassives()
        {
            try
            {
                List<U> values = _repository.Where(x => x.Status == Domain.Enums.DataStatus.Deleted).ToList();
                return _mapper.Map<List<T>>(values);
            }
            catch (Exception ex)
            {
                throw new Exception($"Pasif veriler getirilirken hata: {ex.Message}", ex);
            }
        }

        public virtual List<T> GetUpdateds()
        {
            try
            {
                List<U> values = _repository.Where(x => x.Status == Domain.Enums.DataStatus.Updated).ToList();
                return _mapper.Map<List<T>>(values);
            }
            catch (Exception ex)
            {
                throw new Exception($"Güncellenen veriler getirilirken hata: {ex.Message}", ex);
            }
        }

        public virtual async Task<string> SoftDeleteAsync(int id)
        {
            try
            {
                U value = await _repository.GetByIdAsync(id);

                if (value == null) return "Kayıt bulunamadı.";
                if (value.Status == Domain.Enums.DataStatus.Deleted) return "Veri zaten silinmiş (pasif).";

                value.DeletedDate = DateTime.Now;
                await _repository.SaveChangesAsync();

                return $"{id} id'li veri pasif hale getirildi (Soft Delete).";
            }
            catch (Exception ex)
            {
                throw new Exception($"Soft delete sırasında hata: {ex.Message}", ex);
            }
        }

        public virtual async Task<string> HardDeleteAsync(int id)
        {
            try
            {
                U value = await _repository.GetByIdAsync(id);

                if (value == null) return "Silinecek kayıt bulunamadı.";
                if (value.Status != Domain.Enums.DataStatus.Deleted) return "Veri tamamen silinebilmesi için önce pasif (Soft Deleted) olmalıdır.";

                await _repository.DeleteAsync(value);
                return $"{id} id'li veri tamamen silindi (Hard Delete).";
            }
            catch (Exception ex)
            {
                throw new Exception($"Hard delete sırasında hata: {ex.Message}", ex);
            }
        }
    }
}