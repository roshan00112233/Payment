using Payment.Services;
using Payment.Models;
using Payment.Interfaces;

namespace Payment
{
    public static class PaymentApp
    {
        public static void Run()
        {
            Console.WriteLine("PAYMET APP IS RUNNING ");


            BasePayment Credit = new CreditCardProcessor
            {
                Amount = 1500,
                Payer = "Roshan"
            };

            Credit.Process();
            Credit.log();


            if(Credit is IRefundable refundable)
            {
                refundable.Refund();
            }
        }
    }
}
