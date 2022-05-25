using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    public class ResultSearch
    {
        public string exch { get; set; }
        public string exchDisp { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public string type { get; set; }
        public string typeDisp { get; set; }
    }

    public class SearchData
    {
        public string Query { get; set; }
        public List<ResultSearch> Result { get; set; }
    }

    public class RootSearch
    {
        public SearchData ResultSet { get; set; }
    }
}
