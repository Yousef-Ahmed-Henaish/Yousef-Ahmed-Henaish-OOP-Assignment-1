using System;
using System.Collections.Generic;
using System.Text;

namespace Customers_System.OrderData;
public class ProductManagment
{
    static readonly List<Product> AllProducts = new List<Product>();

    void AddProduct(int id, ProductName name, decimal Price, int Stock)
    {
        ProductName.ProductsNames.Add(name);
        AllProducts.Add(new(id, name, Price, Stock));
    }

    static int FindProductIndexById(int id)
    {
        foreach(Product product in AllProducts)
        {
            if (id == product.ID)
            {
                return AllProducts.IndexOf(product);
            }
        }

        return -1;
    }
}

