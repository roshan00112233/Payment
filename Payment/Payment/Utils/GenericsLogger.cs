using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Utils
{
    public class GenericsLogger<T> where T : BasePayment
    {
        public void logDetails(T payment)
        {
            Console.WriteLine("---- Payment Log ----");
            Console.WriteLine($"Payer: {payment.Payer}");
            Console.WriteLine($"Amount: {payment.Amount}");
            Console.WriteLine($"Logged At: {DateTime.Now}");
        }

    }

}

