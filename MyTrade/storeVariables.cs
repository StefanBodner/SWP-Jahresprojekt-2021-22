using System.Collections.Generic;

namespace MyTrade
{
    public class StoreVariables
    {
        #region Variables
        public static string stockName { get; set; }

        //https://www.yahoofinanceapi.com/
        //5O3GWaacy35x7zAPHAWyuVtgseT1IS45zcZdpKLd Abgabe (@hak-kitz)
        //1WOcW3A2Tr65k1oi9KF307IJJmmVvqIl20fTvSeI Arbeit (@gmail)
        //QtnY5FGuOK13uGFAGzQZE1aK99bIkMvm9MgBPvvp Arbeit (10 Minuten Mail)
        //3qgZBfw8FX578U0oxuA3E3p1X7RqBURp39uJP3R7 Arbeit (10 Minuten Mail)
        public static string apiKey = "3qgZBfw8FX578U0oxuA3E3p1X7RqBURp39uJP3R7";

        public static List<string> tickerWL = new List<string>() { };
        public static List<uInvestments> tickerIV = new List<uInvestments>() { };
        public static List<string> liCurrency = new List<string>() {"EUR"};
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

        public static string RequestCurrencies(List<ResultStockQuote> li)
        {
            //Connect all entries to string (HTTP request)
            string tickerString = "";
            for (int i = 1; i < liCurrency.Count; i++)
            {
                tickerString += "EUR" + liCurrency[i] + "=X,";
            }
            return tickerString;
        }
        #endregion
    }
}
