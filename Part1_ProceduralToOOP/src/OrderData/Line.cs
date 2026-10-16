using System;
using System.Collections.Generic;
using System.Text;

namespace Customers_System.OrderData;
public class Line
{

    public Line(Product product, int quantity)
    {
        if (quantity <= 0)
            throw new Exception("Wrong Quantity !");

        if (product == null)
            throw new Exception("Empty Product !");
        
        Total = Product.Price * quantity;
        Product = product;
        Quantity = quantity;
    }

    public Product Product { get; init; }
    public decimal Total { get; init; }
    public int Quantity { get; init; }
        
}

