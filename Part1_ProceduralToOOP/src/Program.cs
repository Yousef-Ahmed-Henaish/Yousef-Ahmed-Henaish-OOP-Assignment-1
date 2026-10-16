using Customers_System;
using Customers_System.OrderData;

public class Program
{
    public static void Main(string[] args)
    {
        ProductName name = new ProductName("Laptop Stand");

        Product p1 = new Product(1, name, 500, 50);

        List<Line> Lines = new List<Line>();
        Lines.Add(new Line(p1, 1));
        Lines.Add(new Line(p1, 2));
        Lines.Add(new Line(p1, 3));

        Customer c1 = new Customer("Yousef", "Yousef@gmail.com","Giza", false);


        Order o1 = new Order(c1, true, Lines);

        

















    }
}