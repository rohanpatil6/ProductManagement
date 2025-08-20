using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class CategoryAttributeVM
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? AttributeId { get; set; }
        public string DataType { get; set; } = string.Empty;

        public virtual ProductManagement.Models.Attribute? Attribute { get; set; }
        public virtual Category? Category { get; set; }
    }
}
