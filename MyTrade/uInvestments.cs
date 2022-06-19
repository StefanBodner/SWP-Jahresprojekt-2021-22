using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    public class uInvestments
    {
        public string ticker;
        public double amount;
        public double avgPrice;
        public double fees;

        public uInvestments(string ticker, double amount, double avgPrice, double fees)
        {
            this.ticker = ticker;
            this.amount = amount;
            this.avgPrice = avgPrice;
            this.fees = fees;
        }
    }
}
