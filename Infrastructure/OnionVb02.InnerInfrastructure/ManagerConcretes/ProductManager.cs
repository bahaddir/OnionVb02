using AutoMapper;
using OnionVb02.Application.DTOClasses;
using OnionVb02.Application.ManagerInterfaces;
using OnionVb02.Contract.RepositoryInterfaces;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.InnerInfrastructure.ManagerConcretes
{
    public class ProductManager(IProductRepository repository, IMapper mapper, IServiceProvider serviceProvider) : BaseManager<ProductDto, Product>(repository, mapper,serviceProvider), IProductManager
    {
        private readonly IProductRepository _repository = repository;
    }
}
