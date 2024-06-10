using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Product
{
    public Product() { }
    public Product(int productId, string productName, int? categoryId, short? unitsInStock, decimal? unitPrice)
    {
        ProductId = productId;
        ProductName = productName;
        CategoryId = categoryId;
        UnitsInStock = unitsInStock;
        UnitPrice = unitPrice;
    }

    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? CategoryId { get; set; }

    public short? UnitsInStock { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual Category? Category { get; set; }
}
