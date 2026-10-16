using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Customers_System
{
    public class Customer
    {

        public Customer(string name, string email, string governate, bool Vip)
        {
            Name = name;

            if (email.Contains("@"))
                Email = email;

            Governate = governate;

            IsVip = Vip;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Governate { get; set; }
        public bool IsVip{ get; set; }

    }
}
