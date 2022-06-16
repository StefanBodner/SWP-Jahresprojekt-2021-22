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

        //https://www.yahoofinanceapi.com/

        public static string apiKey = "5O3GWaacy35x7zAPHAWyuVtgseT1IS45zcZdpKLd";

        public static List<string> tickerWL = new List<string>() { "AAPL", "TSLA", "MSFT", "AMZN", "NFLX", "FB", "GOOGL", "BTC-USD", "MRNA", "BNTX"};
        #endregion

        #region Methods
        public static string GetTickerList()
        {
            string tickerString = "";

            foreach(string s in tickerWL)
            {
                tickerString += s + ",";
            }

            return tickerString;
        }
        #endregion
    }
}
