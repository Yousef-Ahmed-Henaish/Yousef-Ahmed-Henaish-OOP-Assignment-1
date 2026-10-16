using System;
using System.Collections.Generic;
using Customers_System.OrderData;

// Only this file created by AI, There is wrong logic

namespace Customers_System
{
    public class Menu
    {
        public static void PrintMenu()
        {
            while (true)
            {
                Console.WriteLine("Press: ");
                Console.WriteLine("1) Print customers\n2) Print products\n3) Print all orders\n4) Print one order by id\n5)" +
                                  " Create order\n6) Add line to order\n7) Mark order paid\n8) Show paid sales total\n0) Exit");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.\n");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        OrderManagment.PrintCustomers();
                        break;
                    case 2:
                        OrderManagment.PrintProducts();
                        break;
                    case 3:
                        OrderManagment.PrintAllOrders();
                        break;
                    case 4:
                        PrintOneOrderById();
                        break;
                    case 5:
                        CreateOrder();
                        break;
                    case 6:
                        AddLineToOrder();
                        break;
                    case 7:
                        MarkOrderPaid();
                        break;
                    case 8:
                        ShowPaidSalesTotal();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void PrintOneOrderById()
        {
            int orderId = ReadInt("Enter order id: ");
            int index = OrderManagment.FindOrderIndexById(orderId);
            if (index < 0)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            OrderManagment.PrintOrder(OrderManagment.Orders[index]);
        }

        static void CreateOrder()
        {
            int customerId = ReadInt("Enter customer id: ");
            int customerIndex = OrderManagment.FindCustomerIndexById(customerId);
            if (customerIndex < 0)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            Customer customer = OrderManagment.Customers[customerIndex];
            Order order = OrderManagment.CreateOrder(customer, new List<Line>());
            Console.WriteLine($"Order {order.ID} created for {customer.Name}.");
        }

        static void AddLineToOrder()
        {
            int orderId = ReadInt("Enter order id: ");
            int orderIndex = OrderManagment.FindOrderIndexById(orderId);
            if (orderIndex < 0)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            int productId = ReadInt("Enter product id: ");
            int productIndex = OrderManagment.FindProductIndexById(productId);
            if (productIndex < 0)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            int quantity = ReadInt("Enter quantity: ");
            Order order = OrderManagment.Orders[orderIndex];
            Product product = OrderManagment.Products[productIndex];
            OrderManagment.AddLineToOrder(order, product, quantity);
            Console.WriteLine($"Added {quantity} x product {product.ID} to order {order.ID}.");
        }

        static void MarkOrderPaid()
        {
            int orderId = ReadInt("Enter order id: ");
            int index = OrderManagment.FindOrderIndexById(orderId);
            if (index < 0)
            {
                Console.WriteLine("Order not found.");
                return;
            }

            Order order = OrderManagment.Orders[index];
            OrderManagment.MarkOrderPaid(order);
            Console.WriteLine($"Order {order.ID} marked as paid.");
        }

        static void ShowPaidSalesTotal()
        {
            Console.WriteLine($"Paid sales total: {OrderManagment.TotalSalesPaidOnly()}");
        }

        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Invalid number.");
                return -1;
            }

            return value;
        }
    }
}
