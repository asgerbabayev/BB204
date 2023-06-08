using AutoMapper;
using JwtExample.Data.Entities;
using JwtExample.DTO_s.ProductDto_s;

namespace JwtExample.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductGetDto>();
        CreateMap<ProductPostDto, Product>();
    }
}
