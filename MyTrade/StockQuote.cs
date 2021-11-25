using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    class StockQuote
    {
        private string _region;
        public string region
        {
            get { return _region; }
            set { _region = value; }
        }


        private string _quoteType;
        public string quoteType
        {
            get { return _quoteType; }
            set { _quoteType = value; }
        }


        private string _currency;
        public string currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private int _earningsTimestamp;

        public int earningsTimestamp
        {
            get { return _earningsTimestamp; }
            set { _earningsTimestamp = value; }
        }





        #region Constructor
        public StockQuote(string region, string quoteType, string currency, int earningsTimestamp)
        {
            this._region = region;
            this._quoteType = quoteType;
            this._currency = currency;
            this._earningsTimestamp = earningsTimestamp;
        }



        public StockQuote() { }
        #endregion

    }
}
