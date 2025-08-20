using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class AttributeVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public virtual ICollection<CategoryAttribute> CategoryAttributes { get; set; } = [];
        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = [];
    }
}
