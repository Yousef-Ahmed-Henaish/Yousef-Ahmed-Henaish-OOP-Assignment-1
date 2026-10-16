namespace Customers_System.OrderData;
    public class Product
{
    public Product(int id, ProductName productName, decimal price, int stock)
    {
        ID = id;
        Name = productName;
        Price = price;
        Stock = stock;
    }

    public int ID {  get; private set; }
    public ProductName Name { get; init; }
    public decimal Price {  get; init; }
    public int Stock {  get; private set; }
    
}
