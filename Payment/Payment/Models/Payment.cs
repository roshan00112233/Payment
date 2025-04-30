using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Models
{
    public abstract class BasePayment
    {
        public decimal Amount { get; set; }
        public string Payer { get; set; }


        public void log()
        {
            Console.WriteLine($"[log] {Payer} paid rs {Amount}");
        }


        public abstract void Process();

    }
}
