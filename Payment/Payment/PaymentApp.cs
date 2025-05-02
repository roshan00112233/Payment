using Payment.Services;
using Payment.Models;
using Payment.Interfaces;
using Payment.Utils;
using Payment.Delegates;
using System.Security.Cryptography.X509Certificates;

namespace Payment
{
    public static class PaymentApp
    {
        public static void Run()
        {
            Console.WriteLine("PAYMET APP WITH GENERICS ");


            BasePayment Credit = new CreditCardProcessor
            {
                Amount = 1500,
                Payer = "Roshan"
            };

            Credit.Process();
            Credit.log();

            var logger = new GenericsLogger<BasePayment>();  
            logger.logDetails(Credit);


            var notifier = new PaymentNotifier();

            notifier.OnPaymentCompleted += SendEmail;
            notifier.OnPaymentCompleted += GeneralReceipt;

            notifier.notify(Credit);
        }
        private static void SendEmail(BasePayment payment)
        {
            Console.WriteLine($"Sending email to {payment.Payer} for amount {payment.Amount}");
        }
        private static void GeneralReceipt(BasePayment payment)
        {
            Console.WriteLine($"generating receipt to {payment.Payer} for amount {payment.Amount}");
        }
    }
}

