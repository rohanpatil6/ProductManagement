using AutoMapper;
using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryVM>().ReverseMap();
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<CategoryAttribute, CategoryAttributeVM>().ReverseMap();
            CreateMap<ProductAttributeValue, ProductAttributeValueVM>().ReverseMap();
        }
    }
}
