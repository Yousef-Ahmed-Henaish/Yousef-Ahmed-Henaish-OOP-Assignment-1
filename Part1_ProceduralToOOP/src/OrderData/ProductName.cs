using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Customers_System.OrderData;

public class ProductName
{
    public ProductName(string name)
    {
        Name = name;
    }
    public string Name { get; private set; }
    public static List<ProductName> ProductsNames = new List<ProductName>();
}

