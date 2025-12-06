using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using OnionVb02.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.Application.MappingProfiles
{
    public class CqrsMappingProfile : Profile
    {
        public CqrsMappingProfile()
        {
            
            CreateMap<CreateProductCommand, Product>();
            CreateMap<UpdateProductCommand, Product>();

            

            CreateMap<Product, GetProductByIdQueryResult>();

            
        }
    }
}
