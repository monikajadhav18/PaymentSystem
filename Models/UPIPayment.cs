using PaymentSystem.Interfaces;
using PaymentSystem.Services;

namespace PaymentSystem.Models;

public class UPIPayment : PaymentProcessor, IPayment
{
    private string upiId;

    public UPIPayment(string upiId)
    {
        this.upiId = upiId;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ₹{amount}");
        Console.WriteLine($"UPI ID: {upiId}");
    }

    public override void PaymentCompleted()
    {
        Console.WriteLine("UPI payment completed successfully.");
    }
}