using ProductManagement.Models;

namespace ProductManagement.PMModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual ICollection<CategoryAttribute> CategoryAttributes { get; set; } = [];
        public virtual ICollection<Product> Products { get; set; } = [];
    }
}
