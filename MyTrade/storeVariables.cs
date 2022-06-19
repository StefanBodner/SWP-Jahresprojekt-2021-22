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
        //5O3GWaacy35x7zAPHAWyuVtgseT1IS45zcZdpKLd Abgabe
        //1WOcW3A2Tr65k1oi9KF307IJJmmVvqIl20fTvSeI Arbeit
        public static string apiKey = "5O3GWaacy35x7zAPHAWyuVtgseT1IS45zcZdpKLd";

        public static List<string> tickerWL = new List<string>() { "AAPL", "TSLA", "MSFT", "AMZN", "NFLX", "FB", "GOOGL", "BTC-USD", "MRNA", "BNTX"};
        public static List<uInvestments> tickerIV = new List<uInvestments>() { };
        #endregion

        #region Methods
        public static string GetTickerWL()
        {
            string tickerString = "";

            foreach(string s in tickerWL)
            {
                tickerString += s + ",";
            }

            return tickerString;
        }

        public static string GetTickerIV()
        {
            string tickerString = "";

            for(int i = 0; i < tickerIV.Count; i++)
            {
                tickerString += tickerIV[i].ticker + ",";
            }

            return tickerString;
        }
        #endregion
    }
}
