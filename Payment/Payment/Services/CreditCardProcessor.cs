using Payment.Interfaces;
using Payment.Models;


namespace Payment.Services
{
    public class CreditCardProcessor : BasePayment, IRefundable
    {
        public override void Process()
        {
            Console.WriteLine($"Processing credit card payment ");
        }

        public void Refund()
        {
            Console.WriteLine($"Refunding credit card payment");
        }


    }
}
