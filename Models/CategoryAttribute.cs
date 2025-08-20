using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class CategoryAttribute
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public int? AttributeId { get; set; }

    public string DataType { get; set; } = null!;

    public virtual Attribute? Attribute { get; set; }

    public virtual Category? Category { get; set; }
}
