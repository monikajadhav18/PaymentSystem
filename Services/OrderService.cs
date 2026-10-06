using PaymentSystem.Interfaces;

namespace PaymentSystem.Services;

public class OrderService
{
    private readonly IPayment payment;

    public OrderService(IPayment payment)
    {
        this.payment = payment;
    }

    public void Checkout(decimal amount)
    {
        payment.Pay(amount);
    }
}