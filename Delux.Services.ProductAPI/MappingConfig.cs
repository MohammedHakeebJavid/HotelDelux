using AutoMapper;
using Delux.Services.ProductAPI.Models;
using Delux.Services.ProductAPI.Models.Dtos;

namespace Delux.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });

            return mappingConfig;
        }
    }
}
