using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Delegates
{
    public class PaymentNotifier
    {                                                                                                                     
        //added delegates
        public delegate void PaymentCompletedHandler(BasePayment payment);

        //events
        public event PaymentCompletedHandler OnPaymentCompleted;

        //trigger
        public void notify(BasePayment payment)
        {
            // Notify all subscribers about the payment completion
            Console.WriteLine("Payment completed successfully.");
            OnPaymentCompleted?.Invoke(payment);
        }
    }
}
