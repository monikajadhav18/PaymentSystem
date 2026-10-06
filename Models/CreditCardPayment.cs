using PaymentSystem.Interfaces;
using PaymentSystem.Services;

namespace PaymentSystem.Models;

public class CreditCardPayment : PaymentProcessor, IPayment
{
    private string cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount}");
        Console.WriteLine($"Card ending with: {cardNumber[^4..]}");
    }

    public override void PaymentCompleted()
    {
        Console.WriteLine("Credit card payment completed successfully.");
    }
}