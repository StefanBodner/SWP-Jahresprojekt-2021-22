using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    class Stock
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



        #region Constructor
        public Stock(string region, string quoteType, string currency) 
        {
            this._region = region;
            this._quoteType = quoteType;
            this._currency = currency;
        }

        public Stock() { }
        #endregion
    }
}
