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

        public static string apiKey = "9Sc90J2VQb7W3VpsCNjs24woO4zK2yzN1LImHPL3";

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
