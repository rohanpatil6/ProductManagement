using System;
using System.Collections.Generic;

namespace ProductManagement.Models;

public partial class ProductAttributeValue
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? AttributeId { get; set; }

    public string Value { get; set; } = null!;

    public virtual Attribute? Attribute { get; set; }

    public virtual Product? Product { get; set; }
}
