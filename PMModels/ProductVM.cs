using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int? CategoryId { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = [];
    }
}
