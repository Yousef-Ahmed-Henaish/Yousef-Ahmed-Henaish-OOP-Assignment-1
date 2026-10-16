namespace Builder_Pattern;

public class Program
{
    public static void Main(string[] args)
    {
        var order = new Order.OrderBuilder(invoiceId: 1, customerName: "Yousef", email: "Examble@gmail.com", customerPhone: "0123456789")
            .WithDetails().SetBillingCountry("Billing Country")
            .Build();

        Console.WriteLine("Object Data");
        Console.WriteLine($"Invoice Id: {order.InvoiceId}, Billing Country: {order.BillingCountry}");
    }

    // Sepearate builders good in resposipilites separation and testing capability, but have issue that You should use private set not init use two classess with different fields.
}

