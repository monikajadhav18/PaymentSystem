namespace PaymentSystem.Services;

public abstract class PaymentProcessor
{
    public void StartPayment()
    {
        Console.WriteLine("Starting payment...");
    }

    public virtual void PaymentCompleted()
    {
        Console.WriteLine("Payment completed.");
    }
}