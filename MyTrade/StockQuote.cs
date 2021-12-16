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

		private string _earningsTimestamp;
		public string earningsTimestamp
		{
			get { return _earningsTimestamp; }
			set { _earningsTimestamp = value; }
		}

		private string _earningsTimestampStart;
		public string earningsTimestampStart
		{
			get { return _earningsTimestampStart; }
			set { _earningsTimestampStart = value; }
		}

		private string _earningsTimestampEnd;
		public string earningsTimestampEnd
		{
			get { return _earningsTimestampEnd; }
			set { _earningsTimestampEnd = value; }
		}

		private string _trailingAnnualDividendRate;
		public string trailingAnnualDividendRate
		{
			get { return _trailingAnnualDividendRate; }
			set { _trailingAnnualDividendRate = value; }
		}

		private string _trailingPE;
		public string trailingPE
		{
			get { return _trailingPE; }
			set { _trailingPE = value; }
		}

		private string _trailingAnnualDividendYield;
		public string trailingAnnualDividendYield
		{
			get { return _trailingAnnualDividendYield; }
			set { _trailingAnnualDividendYield = value; }
		}

		private string _epsTrailingTwelveMonths;
		public string epsTrailingTwelveMonths
		{
			get { return _epsTrailingTwelveMonths; }
			set { _epsTrailingTwelveMonths = value; }
		}

		private string _epsForward;
		public string epsForward
		{
			get { return _epsForward; }
			set { _epsForward = value; }
		}

		private string _epsCurrentYear;
		public string epsCurrentYear
		{
			get { return _epsCurrentYear; }
			set { _epsCurrentYear = value; }
		}

		private string _priceEpsCurrentYear;
		public string priceEpsCurrentYear
		{
			get { return _priceEpsCurrentYear; }
			set { _priceEpsCurrentYear = value; }
		}

		private string _sharesOutstanding;
		public string sharesOutstanding
		{
			get { return _sharesOutstanding; }
			set { _sharesOutstanding = value; }
		}

		private string _bookValue;
		public string bookValue
		{
			get { return _bookValue; }
			set { _bookValue = value; }
		}

		private string _fiftyDayAverage;
		public string fiftyDayAverage
		{
			get { return _fiftyDayAverage; }
			set { _fiftyDayAverage = value; }
		}

		private string _fiftyDayAverageChange;
		public string fiftyDayAverageChange
		{
			get { return _fiftyDayAverageChange; }
			set { _fiftyDayAverageChange = value; }
		}

		private string _fiftyDayAverageChangePercent;
		public string fiftyDayAverageChangePercent
		{
			get { return _fiftyDayAverageChangePercent; }
			set { _fiftyDayAverageChangePercent = value; }
		}

		private string _twoHundredDayAverage;
		public string twoHundredDayAverage
		{
			get { return _twoHundredDayAverage; }
			set { _twoHundredDayAverage = value; }
		}

		private string _twoHundredDayAverageChange;
		public string twoHundredDayAverageChange
		{
			get { return _twoHundredDayAverageChange; }
			set { _twoHundredDayAverageChange = value; }
		}

		private string _twoHundredDayAverageChangePercent;
		public string twoHundredDayAverageChangePercent
		{
			get { return _twoHundredDayAverageChangePercent; }
			set { _twoHundredDayAverageChangePercent = value; }
		}

		private string _marketCap;
		public string marketCap
		{
			get { return _marketCap; }
			set { _marketCap = value; }
		}

		private string _forwardPE;
		public string forwardPE
		{
			get { return _forwardPE; }
			set { _forwardPE = value; }
		}

		private string _priceToBook;
		public string priceToBook
		{
			get { return _priceToBook; }
			set { _priceToBook = value; }
		}

		private string _sourceInterval;
		public string sourceInterval
		{
			get { return _sourceInterval; }
			set { _sourceInterval = value; }
		}

		private string _exchangeDataDelayedBy;
		public string exchangeDataDelayedBy
		{
			get { return _exchangeDataDelayedBy; }
			set { _exchangeDataDelayedBy = value; }
		}

		private string _pageViewGrowthWeekly;
		public string pageViewGrowthWeekly
		{
			get { return _pageViewGrowthWeekly; }
			set { _pageViewGrowthWeekly = value; }
		}

		private string _averageAnalystRating;
		public string averageAnalystRating
		{
			get { return _averageAnalystRating; }
			set { _averageAnalystRating = value; }
		}

		private string _tradeable;
		public string tradeable
		{
			get { return _tradeable; }
			set { _tradeable = value; }
		}

		private string _firstTradeDateMilliseconds;
		public string firstTradeDateMilliseconds
		{
			get { return _firstTradeDateMilliseconds; }
			set { _firstTradeDateMilliseconds = value; }
		}

		private string _priceHint;
		public string priceHint
		{
			get { return _priceHint; }
			set { _priceHint = value; }
		}

		private string _postMarketChangePercent;
		public string postMarketChangePercent
		{
			get { return _postMarketChangePercent; }
			set { _postMarketChangePercent = value; }
		}

		private string _postMarketTime;
		public string postMarketTime
		{
			get { return _postMarketTime; }
			set { _postMarketTime = value; }
		}

		private string _postMarketPrice;
		public string postMarketPrice
		{
			get { return _postMarketPrice; }
			set { _postMarketPrice = value; }
		}

		private string _postMarketChange;
		public string postMarketChange
		{
			get { return _postMarketChange; }
			set { _postMarketChange = value; }
		}

		private string _regularMarketChange;
		public string regularMarketChange
		{
			get { return _regularMarketChange; }
			set { _regularMarketChange = value; }
		}

		private string _regularMarketChangePercent;
		public string regularMarketChangePercent
		{
			get { return _regularMarketChangePercent; }
			set { _regularMarketChangePercent = value; }
		}

		private string _regularMarketTime;
		public string regularMarketTime
		{
			get { return _regularMarketTime; }
			set { _regularMarketTime = value; }
		}

		private string _regularMarketPrice;
		public string regularMarketPrice
		{
			get { return _regularMarketPrice; }
			set { _regularMarketPrice = value; }
		}

		private string _regularMarketDayHigh;
		public string regularMarketDayHigh
		{
			get { return _regularMarketDayHigh; }
			set { _regularMarketDayHigh = value; }
		}

		private string _regularMarketDayRange;
		public string regularMarketDayRange
		{
			get { return _regularMarketDayRange; }
			set { _regularMarketDayRange = value; }
		}

		private string _regularMarketDayLow;
		public string regularMarketDayLow
		{
			get { return _regularMarketDayLow; }
			set { _regularMarketDayLow = value; }
		}

		private string _regularMarketVolume;
		public string regularMarketVolume
		{
			get { return _regularMarketVolume; }
			set { _regularMarketVolume = value; }
		}

		private string _regularMarketPreviousClose;
		public string regularMarketPreviousClose
		{
			get { return _regularMarketPreviousClose; }
			set { _regularMarketPreviousClose = value; }
		}

		private string _bid;
		public string bid
		{
			get { return _bid; }
			set { _bid = value; }
		}

		private string _ask;
		public string ask
		{
			get { return _ask; }
			set { _ask = value; }
		}

		private string _bidSize;
		public string bidSize
		{
			get { return _bidSize; }
			set { _bidSize = value; }
		}

		private string _askSize;
		public string askSize
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

		private string _regularMarketOpen;
		public string regularMarketOpen
		{
			get { return _regularMarketOpen; }
			set { _regularMarketOpen = value; }
		}

		private string _averageDailyVolume3Month;
		public string averageDailyVolume3Month
		{
			get { return _averageDailyVolume3Month; }
			set { _averageDailyVolume3Month = value; }
		}

		private string _averageDailyVolume10Day;
		public string averageDailyVolume10Day
		{
			get { return _averageDailyVolume10Day; }
			set { _averageDailyVolume10Day = value; }
		}

		private string _fiftyTwoWeekLowChange;
		public string fiftyTwoWeekLowChange
		{
			get { return _fiftyTwoWeekLowChange; }
			set { _fiftyTwoWeekLowChange = value; }
		}

		private string _fiftyTwoWeekLowChangePercent;
		public string fiftyTwoWeekLowChangePercent
		{
			get { return _fiftyTwoWeekLowChangePercent; }
			set { _fiftyTwoWeekLowChangePercent = value; }
		}

		private string _fiftyTwoWeekRange;
		public string fiftyTwoWeekRange
		{
			get { return _fiftyTwoWeekRange; }
			set { _fiftyTwoWeekRange = value; }
		}

		private string _fiftyTwoWeekHighChange;
		public string fiftyTwoWeekHighChange
		{
			get { return _fiftyTwoWeekHighChange; }
			set { _fiftyTwoWeekHighChange = value; }
		}

		private string _fiftyTwoWeekHighChangePercent;
		public string fiftyTwoWeekHighChangePercent
		{
			get { return _fiftyTwoWeekHighChangePercent; }
			set { _fiftyTwoWeekHighChangePercent = value; }
		}

		private string _fiftyTwoWeekLow;
		public string fiftyTwoWeekLow
		{
			get { return _fiftyTwoWeekLow; }
			set { _fiftyTwoWeekLow = value; }
		}

		private string _fiftyTwoWeekHigh;
		public string fiftyTwoWeekHigh
		{
			get { return _fiftyTwoWeekHigh; }
			set { _fiftyTwoWeekHigh = value; }
		}

		private string _dividendDate;
		public string dividendDate
		{
			get { return _dividendDate; }
			set { _dividendDate = value; }
		}

		private string _messageBoardId;
		public string messageBoardId
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

		private string _gmtOffSetMilliseconds;
		public string gmtOffSetMilliseconds
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

		private string _esgPopulated;
		public string esgPopulated
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
		public StockQuote (string region, string quoteType, string currency, string earningsTimestamp, string earningsTimestampStart, string earningsTimestampEnd, string trailingAnnualDividendRate, string trailingPE, string trailingAnnualDividendYield, string epsTrailingTwelveMonths, string epsForward, string epsCurrentYear, string priceEpsCurrentYear, string sharesOutstanding, string bookValue, string fiftyDayAverage, string fiftyDayAverageChange, string fiftyDayAverageChangePercent, string twoHundredDayAverage, string twoHundredDayAverageChange, string twoHundredDayAverageChangePercent, string marketCap, string forwardPE, string priceToBook, string sourceInterval, string exchangeDataDelayedBy, string pageViewGrowthWeekly, string averageAnalystRating, string tradeable, string firstTradeDateMilliseconds, string priceHint, string postMarketChangePercent, string postMarketTime, string postMarketPrice, string postMarketChange, string regularMarketChange, string regularMarketChangePercent, string regularMarketTime, string regularMarketPrice, string regularMarketDayHigh, string regularMarketDayRange, string regularMarketDayLow, string regularMarketVolume, string regularMarketPreviousClose, string bid, string ask, string bidSize, string askSize, string fullExchangeName, string financialCurrency, string regularMarketOpen, string averageDailyVolume3Month, string averageDailyVolume10Day, string fiftyTwoWeekLowChange, string fiftyTwoWeekLowChangePercent, string fiftyTwoWeekRange, string fiftyTwoWeekHighChange, string fiftyTwoWeekHighChangePercent, string fiftyTwoWeekLow, string fiftyTwoWeekHigh, string dividendDate, string messageBoardId, string exchangeTimezoneName, string exchangeTimezoneShortName, string gmtOffSetMilliseconds, string market, string esgPopulated, string exchange, string longName, string marketState, string shortName, string displayName, string symbol)
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
