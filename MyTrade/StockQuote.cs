using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTrade
{
    class StockQuote
    {
		#region Getter/Setter

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

		private int _earningsTimestampStart;
		public int earningsTimestampStart
		{
			get { return _earningsTimestampStart; }
			set { _earningsTimestampStart = value; }
		}

		private int _earningsTimestampEnd;
		public int earningsTimestampEnd
		{
			get { return _earningsTimestampEnd; }
			set { _earningsTimestampEnd = value; }
		}

		private int _trailingAnnualDividendRate;
		public int trailingAnnualDividendRate
		{
			get { return _trailingAnnualDividendRate; }
			set { _trailingAnnualDividendRate = value; }
		}

		private int _trailingPE;
		public int trailingPE
		{
			get { return _trailingPE; }
			set { _trailingPE = value; }
		}

		private int _trailingAnnualDividendYield;
		public int trailingAnnualDividendYield
		{
			get { return _trailingAnnualDividendYield; }
			set { _trailingAnnualDividendYield = value; }
		}

		private int _epsTrailingTwelveMonths;
		public int epsTrailingTwelveMonths
		{
			get { return _epsTrailingTwelveMonths; }
			set { _epsTrailingTwelveMonths = value; }
		}

		private int _epsForward;
		public int epsForward
		{
			get { return _epsForward; }
			set { _epsForward = value; }
		}

		private int _epsCurrentYear;
		public int epsCurrentYear
		{
			get { return _epsCurrentYear; }
			set { _epsCurrentYear = value; }
		}

		private int _priceEpsCurrentYear;
		public int priceEpsCurrentYear
		{
			get { return _priceEpsCurrentYear; }
			set { _priceEpsCurrentYear = value; }
		}

		private int _sharesOutstanding;
		public int sharesOutstanding
		{
			get { return _sharesOutstanding; }
			set { _sharesOutstanding = value; }
		}

		private int _bookValue;
		public int bookValue
		{
			get { return _bookValue; }
			set { _bookValue = value; }
		}

		private int _fiftyDayAverage;
		public int fiftyDayAverage
		{
			get { return _fiftyDayAverage; }
			set { _fiftyDayAverage = value; }
		}

		private int _fiftyDayAverageChange;
		public int fiftyDayAverageChange
		{
			get { return _fiftyDayAverageChange; }
			set { _fiftyDayAverageChange = value; }
		}

		private int _fiftyDayAverageChangePercent;
		public int fiftyDayAverageChangePercent
		{
			get { return _fiftyDayAverageChangePercent; }
			set { _fiftyDayAverageChangePercent = value; }
		}

		private int _twoHundredDayAverage;
		public int twoHundredDayAverage
		{
			get { return _twoHundredDayAverage; }
			set { _twoHundredDayAverage = value; }
		}

		private int _twoHundredDayAverageChange;
		public int twoHundredDayAverageChange
		{
			get { return _twoHundredDayAverageChange; }
			set { _twoHundredDayAverageChange = value; }
		}

		private int _twoHundredDayAverageChangePercent;
		public int twoHundredDayAverageChangePercent
		{
			get { return _twoHundredDayAverageChangePercent; }
			set { _twoHundredDayAverageChangePercent = value; }
		}

		private int _marketCap;
		public int marketCap
		{
			get { return _marketCap; }
			set { _marketCap = value; }
		}

		private int _forwardPE;
		public int forwardPE
		{
			get { return _forwardPE; }
			set { _forwardPE = value; }
		}

		private int _priceToBook;
		public int priceToBook
		{
			get { return _priceToBook; }
			set { _priceToBook = value; }
		}

		private int _sourceInterval;
		public int sourceInterval
		{
			get { return _sourceInterval; }
			set { _sourceInterval = value; }
		}

		private int _exchangeDataDelayedBy;
		public int exchangeDataDelayedBy
		{
			get { return _exchangeDataDelayedBy; }
			set { _exchangeDataDelayedBy = value; }
		}

		private int _pageViewGrowthWeekly;
		public int pageViewGrowthWeekly
		{
			get { return _pageViewGrowthWeekly; }
			set { _pageViewGrowthWeekly = value; }
		}

		private int _averageAnalystRating;
		public int averageAnalystRating
		{
			get { return _averageAnalystRating; }
			set { _averageAnalystRating = value; }
		}

		private bool _tradeable;
		public bool tradeable
		{
			get { return _tradeable; }
			set { _tradeable = value; }
		}

		private int _firstTradeDateMilliseconds;
		public int firstTradeDateMilliseconds
		{
			get { return _firstTradeDateMilliseconds; }
			set { _firstTradeDateMilliseconds = value; }
		}

		private int _priceHint;
		public int priceHint
		{
			get { return _priceHint; }
			set { _priceHint = value; }
		}

		private int _postMarketChangePercent;
		public int postMarketChangePercent
		{
			get { return _postMarketChangePercent; }
			set { _postMarketChangePercent = value; }
		}

		private int _postMarketTime;
		public int postMarketTime
		{
			get { return _postMarketTime; }
			set { _postMarketTime = value; }
		}

		private int _postMarketPrice;
		public int postMarketPrice
		{
			get { return _postMarketPrice; }
			set { _postMarketPrice = value; }
		}

		private int _postMarketChange;
		public int postMarketChange
		{
			get { return _postMarketChange; }
			set { _postMarketChange = value; }
		}

		private int _regularMarketChange;
		public int regularMarketChange
		{
			get { return _regularMarketChange; }
			set { _regularMarketChange = value; }
		}

		private int _regularMarketChangePercent;
		public int regularMarketChangePercent
		{
			get { return _regularMarketChangePercent; }
			set { _regularMarketChangePercent = value; }
		}

		private int _regularMarketTime;
		public int regularMarketTime
		{
			get { return _regularMarketTime; }
			set { _regularMarketTime = value; }
		}

		private int _regularMarketPrice;
		public int regularMarketPrice
		{
			get { return _regularMarketPrice; }
			set { _regularMarketPrice = value; }
		}

		private int _regularMarketDayHigh;
		public int regularMarketDayHigh
		{
			get { return _regularMarketDayHigh; }
			set { _regularMarketDayHigh = value; }
		}

		private int _regularMarketDayRange;
		public int regularMarketDayRange
		{
			get { return _regularMarketDayRange; }
			set { _regularMarketDayRange = value; }
		}

		private int _regularMarketDayLow;
		public int regularMarketDayLow
		{
			get { return _regularMarketDayLow; }
			set { _regularMarketDayLow = value; }
		}

		private int _regularMarketVolume;
		public int regularMarketVolume
		{
			get { return _regularMarketVolume; }
			set { _regularMarketVolume = value; }
		}

		private int _regularMarketPreviousClose;
		public int regularMarketPreviousClose
		{
			get { return _regularMarketPreviousClose; }
			set { _regularMarketPreviousClose = value; }
		}

		private int _bid;
		public int bid
		{
			get { return _bid; }
			set { _bid = value; }
		}

		private int _ask;
		public int ask
		{
			get { return _ask; }
			set { _ask = value; }
		}

		private int _bidSize;
		public int bidSize
		{
			get { return _bidSize; }
			set { _bidSize = value; }
		}

		private int _askSize;
		public int askSize
		{
			get { return _askSize; }
			set { _askSize = value; }
		}

		private string _fullExchangeName;
		public string fullExchangeName
		{
			get { return _fullExchangeName; }
			set { _fullExchangeName = value; }
		}

		private string _financialCurrency;
		public string financialCurrency
		{
			get { return _financialCurrency; }
			set { _financialCurrency = value; }
		}

		private int _regularMarketOpen;
		public int regularMarketOpen
		{
			get { return _regularMarketOpen; }
			set { _regularMarketOpen = value; }
		}

		private int _averageDailyVolume3Month;
		public int averageDailyVolume3Month
		{
			get { return _averageDailyVolume3Month; }
			set { _averageDailyVolume3Month = value; }
		}

		private int _averageDailyVolume10Day;
		public int averageDailyVolume10Day
		{
			get { return _averageDailyVolume10Day; }
			set { _averageDailyVolume10Day = value; }
		}

		private int _fiftyTwoWeekLowChange;
		public int fiftyTwoWeekLowChange
		{
			get { return _fiftyTwoWeekLowChange; }
			set { _fiftyTwoWeekLowChange = value; }
		}

		private int _fiftyTwoWeekLowChangePercent;
		public int fiftyTwoWeekLowChangePercent
		{
			get { return _fiftyTwoWeekLowChangePercent; }
			set { _fiftyTwoWeekLowChangePercent = value; }
		}

		private int _fiftyTwoWeekRange;
		public int fiftyTwoWeekRange
		{
			get { return _fiftyTwoWeekRange; }
			set { _fiftyTwoWeekRange = value; }
		}

		private int _fiftyTwoWeekHighChange;
		public int fiftyTwoWeekHighChange
		{
			get { return _fiftyTwoWeekHighChange; }
			set { _fiftyTwoWeekHighChange = value; }
		}

		private int _fiftyTwoWeekHighChangePercent;
		public int fiftyTwoWeekHighChangePercent
		{
			get { return _fiftyTwoWeekHighChangePercent; }
			set { _fiftyTwoWeekHighChangePercent = value; }
		}

		private int _fiftyTwoWeekLow;
		public int fiftyTwoWeekLow
		{
			get { return _fiftyTwoWeekLow; }
			set { _fiftyTwoWeekLow = value; }
		}

		private int _fiftyTwoWeekHigh;
		public int fiftyTwoWeekHigh
		{
			get { return _fiftyTwoWeekHigh; }
			set { _fiftyTwoWeekHigh = value; }
		}

		private int _dividendDate;
		public int dividendDate
		{
			get { return _dividendDate; }
			set { _dividendDate = value; }
		}

		private int _messageBoardId;
		public int messageBoardId
		{
			get { return _messageBoardId; }
			set { _messageBoardId = value; }
		}

		private string _exchangeTimezoneName;
		public string exchangeTimezoneName
		{
			get { return _exchangeTimezoneName; }
			set { _exchangeTimezoneName = value; }
		}

		private string _exchangeTimezoneShortName;
		public string exchangeTimezoneShortName
		{
			get { return _exchangeTimezoneShortName; }
			set { _exchangeTimezoneShortName = value; }
		}

		private int _gmtOffSetMilliseconds;
		public int gmtOffSetMilliseconds
		{
			get { return _gmtOffSetMilliseconds; }
			set { _gmtOffSetMilliseconds = value; }
		}

		private string _market;
		public string market
		{
			get { return _market; }
			set { _market = value; }
		}

		private bool _esgPopulated;
		public bool esgPopulated
		{
			get { return _esgPopulated; }
			set { _esgPopulated = value; }
		}

		private string _exchange;
		public string exchange
		{
			get { return _exchange; }
			set { _exchange = value; }
		}

		private string _longName;
		public string longName
		{
			get { return _longName; }
			set { _longName = value; }
		}

		private string _marketState;
		public string marketState
		{
			get { return _marketState; }
			set { _marketState = value; }
		}

		private string _shortName;
		public string shortName
		{
			get { return _shortName; }
			set { _shortName = value; }
		}

		private string _displayName;
		public string displayName
		{
			get { return _displayName; }
			set { _displayName = value; }
		}

		private string _symbol;
		public string symbol
		{
			get { return _symbol; }
			set { _symbol = value; }
		}





		#endregion

		#region Constructor
		public StockQuote(string region, string quoteType, string currency, int earningsTimestamp, int earningsTimestampStart, int earningsTimestampEnd, int trailingAnnualDividendRate, int trailingPE, int trailingAnnualDividendYield, int epsTrailingTwelveMonths, int epsForward, int epsCurrentYear, int priceEpsCurrentYear, int sharesOutstanding, int bookValue, int fiftyDayAverage, int fiftyDayAverageChange, int fiftyDayAverageChangePercent, int twoHundredDayAverage, int twoHundredDayAverageChange, int twoHundredDayAverageChangePercent, int marketCap, int forwardPE, int priceToBook, int sourceInterval, int exchangeDataDelayedBy, int pageViewGrowthWeekly, int averageAnalystRating, bool tradeable, int firstTradeDateMilliseconds, int priceHint, int postMarketChangePercent, int postMarketTime, int postMarketPrice, int postMarketChange, int regularMarketChange, int regularMarketChangePercent, int regularMarketTime, int regularMarketPrice, int regularMarketDayHigh, int regularMarketDayRange, int regularMarketDayLow, int regularMarketVolume, int regularMarketPreviousClose, int bid, int ask, int bidSize, int askSize, string fullExchangeName, string financialCurrency, int regularMarketOpen, int averageDailyVolume3Month, int averageDailyVolume10Day, int fiftyTwoWeekLowChange, int fiftyTwoWeekLowChangePercent, int fiftyTwoWeekRange, int fiftyTwoWeekHighChange, int fiftyTwoWeekHighChangePercent, int fiftyTwoWeekLow, int fiftyTwoWeekHigh, int dividendDate, int messageBoardId, string exchangeTimezoneName, string exchangeTimezoneShortName, int gmtOffSetMilliseconds, string market, bool esgPopulated, string exchange, string longName, string marketState, string shortName, string displayName, string symbol)
		{
			this._region = region;
			this._quoteType = quoteType;
			this._currency = currency;
			this._earningsTimestamp = earningsTimestamp;
			this._earningsTimestampStart = earningsTimestampStart;
			this._earningsTimestampEnd = earningsTimestampEnd;
			this._trailingAnnualDividendRate = trailingAnnualDividendRate;
			this._trailingPE = trailingPE;
			this._trailingAnnualDividendYield = trailingAnnualDividendYield;
			this._epsTrailingTwelveMonths = epsTrailingTwelveMonths;
			this._epsForward = epsForward;
			this._epsCurrentYear = epsCurrentYear;
			this._priceEpsCurrentYear = priceEpsCurrentYear;
			this._sharesOutstanding = sharesOutstanding;
			this._bookValue = bookValue;
			this._fiftyDayAverage = fiftyDayAverage;
			this._fiftyDayAverageChange = fiftyDayAverageChange;
			this._fiftyDayAverageChangePercent = fiftyDayAverageChangePercent;
			this._twoHundredDayAverage = twoHundredDayAverage;
			this._twoHundredDayAverageChange = twoHundredDayAverageChange;
			this._twoHundredDayAverageChangePercent = twoHundredDayAverageChangePercent;
			this._marketCap = marketCap;
			this._forwardPE = forwardPE;
			this._priceToBook = priceToBook;
			this._sourceInterval = sourceInterval;
			this._exchangeDataDelayedBy = exchangeDataDelayedBy;
			this._pageViewGrowthWeekly = pageViewGrowthWeekly;
			this._averageAnalystRating = averageAnalystRating;
			this._tradeable = tradeable;
			this._firstTradeDateMilliseconds = firstTradeDateMilliseconds;
			this._priceHint = priceHint;
			this._postMarketChangePercent = postMarketChangePercent;
			this._postMarketTime = postMarketTime;
			this._postMarketPrice = postMarketPrice;
			this._postMarketChange = postMarketChange;
			this._regularMarketChange = regularMarketChange;
			this._regularMarketChangePercent = regularMarketChangePercent;
			this._regularMarketTime = regularMarketTime;
			this._regularMarketPrice = regularMarketPrice;
			this._regularMarketDayHigh = regularMarketDayHigh;
			this._regularMarketDayRange = regularMarketDayRange;
			this._regularMarketDayLow = regularMarketDayLow;
			this._regularMarketVolume = regularMarketVolume;
			this._regularMarketPreviousClose = regularMarketPreviousClose;
			this._bid = bid;
			this._ask = ask;
			this._bidSize = bidSize;
			this._askSize = askSize;
			this._fullExchangeName = fullExchangeName;
			this._financialCurrency = financialCurrency;
			this._regularMarketOpen = regularMarketOpen;
			this._averageDailyVolume3Month = averageDailyVolume3Month;
			this._averageDailyVolume10Day = averageDailyVolume10Day;
			this._fiftyTwoWeekLowChange = fiftyTwoWeekLowChange;
			this._fiftyTwoWeekLowChangePercent = fiftyTwoWeekLowChangePercent;
			this._fiftyTwoWeekRange = fiftyTwoWeekRange;
			this._fiftyTwoWeekHighChange = fiftyTwoWeekHighChange;
			this._fiftyTwoWeekHighChangePercent = fiftyTwoWeekHighChangePercent;
			this._fiftyTwoWeekLow = fiftyTwoWeekLow;
			this._fiftyTwoWeekHigh = fiftyTwoWeekHigh;
			this._dividendDate = dividendDate;
			this._messageBoardId = messageBoardId;
			this._exchangeTimezoneName = exchangeTimezoneName;
			this._exchangeTimezoneShortName = exchangeTimezoneShortName;
			this._gmtOffSetMilliseconds = gmtOffSetMilliseconds;
			this._market = market;
			this._esgPopulated = esgPopulated;
			this._exchange = exchange;
			this._longName = longName;
			this._marketState = marketState;
			this._shortName = shortName;
			this._displayName = displayName;
			this._symbol = symbol;
		}


		public StockQuote() { }
        #endregion

    }
}
