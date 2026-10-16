using System;
using System.Collections.Generic;
using System.Text;

namespace Customers_System.OrderData;

public class OrderManagment
{

    const int MaxCustomers = 50;
    const int MaxProducts = 50;
    const int MaxLinesPerOrder = 20;
    public const int MaxOrders = 100;
    public static List<Order> Orders = new List<Order>();

    //Flaw: anyone can access it and change the entire data. ( violate encapsulation )
    public static List<Customer> Customers = new List<Customer>();
    public static List<Product> Products = new List<Product>();




    public static void PrintCustomers()
    {
        Console.WriteLine($"Cutomers: {Customers.Count}");
        foreach (var customer in Customers)
        {
            int i = 0; i++;
            Console.WriteLine($"{i + 1}. Name: {customer.Name}, Id: {customer.ID} , Governate: {customer.Governate}, Email: {customer.Email}");
        }
    }

    public static decimal TotalSalesPaidOnly()
    {
        decimal Total = 0;
        foreach (var order in Orders)
        {
            if (order.IsPaid)
                Total += order.Total;
        }
        return Total;
    }

    public static int FindCustomerIndexById(int Id)
    {
        foreach (var customer in Customers)
        {
            if (Id == customer.ID)
            {
                return Customers.IndexOf(customer);
            }
        }

        return -1;
    }

    public static int FindProductIndexById(int id)
    {
        foreach (var product in Products)
        {
            if (id == product.ID)
                return Products.IndexOf(product);
        }

        return -1;
    }

    void addCustomer( string name, string email, string governate, bool isVip)
    {
        Customers.Add(new Customer(name, email, governate, isVip));
    }

    bool CustomerIsFound(Customer customer)
    {
        return Customers.Contains(customer);
    }

    public static Order CreateOrder(Customer customer, List<Line> lines)
    {
        Order order = new Order(customer, false, lines);
        Orders.Add(order);
        return order;
    }


    public static decimal CalculateOrderTotal(Order order) 
    {
        decimal Total = 0;
            
        foreach (Line line in order.Lines)
        {
            Total += line.Total;
        }

        if (order.Customer.IsVip)
            return Total * 0.9m;
        else
            return Total;
    }








    public static void AddLineToOrder(Order order, Product product, int quantity) 
    {
        order.Lines.Add( new Line(product, quantity) );
    }

    public static void MarkOrderPaid(Order order) 
    {
        order.IsPaid = true;
    }

    public static void PrintOrder(Order order)
    {
        Console.WriteLine($"===== Order {order.ID} =====");

        Console.WriteLine($"Date: {order.OrderDate}");
        Console.WriteLine($"Customer: {order.Customer}");
        Console.WriteLine($"Paid: {order.IsPaid}");
        Console.WriteLine("Lines");
        foreach (Line line in order.Lines)
        {
            int i = 0; i++;
            Console.WriteLine($"Line {i + 1}: {line.Product}, {line.Quantity}, @{line.Product.Price} = {line.Quantity * line.Product.Price}");
        }
        Console.WriteLine($"Total: {CalculateOrderTotal(order)}");
    }

    public static Boolean OrderIsFound(Order order)
    {
        foreach (Order Order in Orders)
            if (Order.ID == order.ID)
                return true;

        return false;
    }

    public static int FindOrderIndexById(int id)
    {
        foreach (Order Order in Orders)
            if (id == Order.ID)
                return Orders.IndexOf(Order);

        return -1;
    }

    public static void PrintAllOrders()
    {
        Console.WriteLine($"Orders: {Orders.Count}");
        foreach (var order in Orders)
        {
            PrintOrder(order);
        }
    }

    public static void PrintProducts()
    {
        Console.WriteLine($"Products: {Products.Count}");
        foreach (var product in Products)
        {
            int i = 0; i++;
            Console.WriteLine($"{i + 1}. Name: {product.Name}, Id: {product.ID}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }

}
