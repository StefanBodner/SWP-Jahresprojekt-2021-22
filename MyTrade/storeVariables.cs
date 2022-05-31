using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    public class StoreVariables
    {
        #region Variables
        public static string stockName { get; set; }

        public static string apiKey = "e1i5DKWcaV7UBrc5OVNge4U1LgokxF703OTc6O99";

        public static List<string> tickerL = new List<string>() { "AAPL", "TSLA", "MSFT", "AMZN", "NFLX", "FB", "GOOGL", "BTC-USD", "MRNA", "BNTX"};
        #endregion

        #region Methods
        public static string GetTickerList()
        {
            string tickerString = "";

            foreach(string s in tickerL)
            {
                tickerString += s + ",";
            }

            return tickerString;
        }
        #endregion
    }
}
