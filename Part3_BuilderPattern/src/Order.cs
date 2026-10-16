using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace Builder_Pattern;

public class Order
{

    private Order( int invoiceId, string customerName, string customerEmail, string customerPhone )
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
    }
    
    public int InvoiceId { get;  }
    public string CustomerName { get; }
    public string CustomerEmail { get; }
    public string CustomerPhone { get; }

    public string? BillingStreet { get; private set;}
    public string? BillingCity { get; private set;}
    public string? BillingState { get; private set;}
    public string? BillingZipCode { get; private set;}
    public string? BillingCountry { get; private set;}

    public DateTime? OrderDate { get; private set;}
    public string? PaymentMethod { get; private set;}
    public string? ShippingState { get; private set;}
    public string? Currency { get; private set;}
    public decimal? SubTotal { get; private set;}
    public decimal? DiscountAmount { get; private set;}
    public decimal? TaxAmount { get; private set;}
    public decimal? TotalAmount { get; private set;}

    public class OrderBuilder
    {
        public OrderBuilder(int invoiceId, string customerName, string email, string customerPhone)
           => _order = new Order(invoiceId, customerName, email, customerPhone);

        private readonly Order _order;

        public OrderBuilder SetPaymentMethod(string paymentMethod)
        {
             _order.PaymentMethod = paymentMethod;
            return this;
        }

        public OrderBuilder SetOrderDate(DateTime date)
        {
            _order.OrderDate = date;
            return this;
        }

        public OrderBuilder SetCurrency(string currency)
        {
            _order.Currency = currency;
            return this;
        }

        public OrderBuilder SetSubTotal(decimal subTotal)
        {
            _order.SubTotal = subTotal;
            return this;
        }

        public OrderBuilder SetDiscountAmount(decimal discountAmount)
        {
            _order.DiscountAmount = discountAmount;
            return this;
        }

        public OrderBuilder SetTaxAmount(decimal taxAmount)
        {
            _order.TaxAmount = taxAmount;
            return this;
        }

        public OrderBuilder SetTotalAmount(decimal totalAmount)
        {
            _order.TotalAmount = totalAmount;
            return this;
        }

        public Order Build()
        {
            return _order;
        }

        public AddressBuilder WithDetails()
        {
            
            return new AddressBuilder(_order);
        }

    }

    public class AddressBuilder
    {
        public AddressBuilder(Order order)
            => _order = order;

        private readonly Order _order;

        public AddressBuilder SetBillingState(string billingState)
        {
            _order.BillingState = billingState;
            return this;
        }

        public AddressBuilder SetShippingState(string shippingState)
        {
            _order.ShippingState = shippingState;
            return this;
        }

        public AddressBuilder SetBillingStreet(string billingStreet)
        {
            _order.BillingStreet = billingStreet;
            return this;
        }

        public AddressBuilder SetBillingCity(string billingCity)
        {
            _order.BillingCity = billingCity;
            return this;
        }

        public AddressBuilder SetBillingZipCode(string billingZipCode)
        {
            _order.BillingZipCode = billingZipCode;
            return this;
        }

        public AddressBuilder SetBillingCountry(string billingCountry)
        {
            _order.BillingCountry = billingCountry;
            return this;
        }

        public Order Build()
        {
            return _order;
        }

    }

}

