using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class ProductAttributeValueVM
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? AttributeId { get; set; }
        public string Value { get; set; } = string.Empty;

        public virtual ProductManagement.Models.Attribute? Attribute { get; set; }
        public virtual Product? Product { get; set; }
    }
}
