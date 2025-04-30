using Payment.Interfaces;
using Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment.Services
{
    public class BankTransferProcessor : BasePayment
    {
        public override void Process()
        {
            Console.WriteLine($"Processing bank transfer payment ");
        }
    }
}
