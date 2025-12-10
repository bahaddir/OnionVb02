using AutoMapper;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductAttributeValueCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ShipperCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserProfileResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.AppUserResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.CategoryResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderDetailResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.OrderResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductAttributeValueResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ProductResults;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Results.ShipperResults;
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
            CreateMap<Product, GetProductQueryResult>();

            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, GetCategoryByIdQueryResult>();
            CreateMap<Category, GetCategoryQueryResult>();

            CreateMap<CreateOrderCommand, Order>();
            CreateMap<UpdateOrderCommand, Order>();
            CreateMap<Order, GetOrderByIdQueryResult>();
            CreateMap<Order, GetOrderQueryResult>();

            CreateMap<CreateOrderDetailCommand, OrderDetail>();
            CreateMap<UpdateOrderDetailCommand, OrderDetail>();
            CreateMap<OrderDetail, GetOrderDetailByIdQueryResult>();
            CreateMap<OrderDetail, GetOrderDetailQueryResult>();

            CreateMap<CreateAppUserCommand, AppUser>();
            CreateMap<UpdateAppUserCommand, AppUser>();
            CreateMap<AppUser, GetAppUserByIdQueryResult>();
            CreateMap<AppUser, GetAppUserQueryResult>();

            CreateMap<CreateAppUserProfileCommand, AppUserProfile>();
            CreateMap<UpdateAppUserProfileCommand, AppUserProfile>();
            CreateMap<AppUserProfile, GetAppUserProfileByIdQueryResult>();
            CreateMap<AppUserProfile, GetAppUserProfileQueryResult>();

            CreateMap<CreateShipperCommand, Shipper>();
            CreateMap<UpdateShipperCommand, Shipper>();
            CreateMap<Shipper, GetShipperByIdQueryResult>();
            CreateMap<Shipper, GetShipperQueryResult>();

            CreateMap<CreateProductAttributeCommand, ProductAttribute>();
            CreateMap<UpdateProductAttributeCommand, ProductAttribute>();
            CreateMap<ProductAttribute, GetProductAttributeByIdQueryResult>();
            CreateMap<ProductAttribute, GetProductAttributeQueryResult>();

            CreateMap<CreateProductAttributeValueCommand, ProductAttributeValue>();
            CreateMap<UpdateProductAttributeValueCommand, ProductAttributeValue>();
            CreateMap<ProductAttributeValue, GetProductAttributeValueByIdQueryResult>();
            CreateMap<ProductAttributeValue, GetProductAttributeValueQueryResult>();

        }
    }
}
