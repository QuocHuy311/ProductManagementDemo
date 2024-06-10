using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Category
{
    public Category() { 
        Products = new HashSet<Product>();
    }

    public Category(int catID, string catName)
    {
        this.CategoryId = catID;
        this.CategoryName = catName;
    }
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
