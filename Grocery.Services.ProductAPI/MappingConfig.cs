using AutoMapper;
using Grocery.Services.ProductAPI.Models;
using Grocery.Services.ProductAPI.Models.DTO;

namespace Grocery.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDTO, ProductDTO>();
                config.CreateMap<ProductDTO, Product>();
            });

            return mappingConfig;
        }
    }
}
