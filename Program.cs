using PaymentSystem.Interfaces;
using PaymentSystem.Models;

IPayment creditCardPayment =
    new CreditCardPayment("1234567890123456");

IPayment upiPayment =
    new UPIPayment("monika@upi");

Console.WriteLine("===== CREDIT CARD PAYMENT =====");

creditCardPayment.Pay(2500);

Console.WriteLine();

Console.WriteLine("===== UPI PAYMENT =====");

upiPayment.Pay(1500);

Console.WriteLine();

Console.WriteLine("===== PAYMENT PROCESSOR =====");

CreditCardPayment creditCard =
    new CreditCardPayment("1234567890123456");

creditCard.StartPayment();
creditCard.Pay(3000);
creditCard.PaymentCompleted();