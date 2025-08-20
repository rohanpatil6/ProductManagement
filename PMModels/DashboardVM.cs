using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class DashboardVM
    {

        public List<Category> Categories { get; set; } = new();
        public List<CategoryAttribute> CategoryAttributes { get; set; } = new();
        public List<ProductManagement.Models.Attribute> Attributes { get; set; } = new();
        public List<Product> Products { get; set; } = new();
        public List<ProductAttributeValue> ProductAttributeValues { get; set; } = new();
    }
}
