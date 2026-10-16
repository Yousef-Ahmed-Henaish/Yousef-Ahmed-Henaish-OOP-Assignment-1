using System;
using System.Collections.Generic;
using System.Text;

namespace Customers_System.OrderData
{
    public class Order
    {

        public Order( Customer customer, Boolean PayStatus, List <Line> lines)
        {
            this.ID = OrderManagment.Orders.Count + 1;
            this.Customer = customer;
            this.IsPaid = PayStatus;
            this.Lines = lines;
            this.OrderDate = DateTime.Now;
            this.IsVip = customer.IsVip;
            this.Total = OrderManagment.CalculateOrderTotal(this);
        }

        public int ID { get; init; }
        public DateTime OrderDate { get; init; }
        public Customer Customer  { get; init; }
        public Boolean IsPaid { get; set; }
        public decimal Total { get;}
        public Boolean IsVip { get; init; }
        public List<Line> Lines { get; init; } = new List<Line>();
        
    }
}
