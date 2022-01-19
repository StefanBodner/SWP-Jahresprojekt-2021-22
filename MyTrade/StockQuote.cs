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
		private string _currency;
		public string currency
		{
			get { return _currency; }
			set { _currency = value; }
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

		private int _fiftyDayAverage;
		public int fiftyDayAverage
		{
			get { return _fiftyDayAverage; }
			set { _fiftyDayAverage = value; }
		}

		private int _marketCap;
		public int marketCap
		{
			get { return _marketCap; }
			set { _marketCap = value; }
		}

		private int _averageAnalystRating;
		public int averageAnalystRating
		{
			get { return _averageAnalystRating; }
			set { _averageAnalystRating = value; }
		}


		private int _postMarketChangePercent;
		public int postMarketChangePercent
		{
			get { return _postMarketChangePercent; }
			set { _postMarketChangePercent = value; }
		}

		private int _postMarketPrice;
		public int postMarketPrice
		{
			get { return _postMarketPrice; }
			set { _postMarketPrice = value; }
		}

		private int _regularMarketChangePercent;
		public int regularMarketChangePercent
		{
			get { return _regularMarketChangePercent; }
			set { _regularMarketChangePercent = value; }
		}

		private int _regularMarketPrice;
		public int regularMarketPrice
		{
			get { return _regularMarketPrice; }
			set { _regularMarketPrice = value; }
		}

		private int _regularMarketDayRange;
		public int regularMarketDayRange
		{
			get { return _regularMarketDayRange; }
			set { _regularMarketDayRange = value; }
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

		private int _regularMarketOpen;
		public int regularMarketOpen
		{
			get { return _regularMarketOpen; }
			set { _regularMarketOpen = value; }
		}

		private int _averageDailyVolume10Day;
		public int averageDailyVolume10Day
		{
			get { return _averageDailyVolume10Day; }
			set { _averageDailyVolume10Day = value; }
		}

		private int _fiftyTwoWeekRange;
		public int fiftyTwoWeekRange
		{
			get { return _fiftyTwoWeekRange; }
			set { _fiftyTwoWeekRange = value; }
		}

		private string _longName;
		public string longName
		{
			get { return _longName; }
			set { _longName = value; }
		}

		private string _symbol;
		public string symbol
		{
			get { return _symbol; }
			set { _symbol = value; }
		}
		#endregion

		#region Constructor
		public StockQuote(string currency, int trailingAnnualDividendRate, int trailingPE, int trailingAnnualDividendYield, int epsTrailingTwelveMonths, int fiftyDayAverage, int marketCap, int averageAnalystRating, int postMarketChangePercent, int postMarketPrice, int regularMarketChangePercent, int regularMarketPrice, int regularMarketDayRange, int regularMarketVolume, int regularMarketPreviousClose, int bid, int ask, int bidSize, int askSize, string fullExchangeName, int regularMarketOpen, int averageDailyVolume10Day, int fiftyTwoWeekRange, string longName, string symbol)
		{
			this._currency = currency;
			this._trailingAnnualDividendRate = trailingAnnualDividendRate;
			this._trailingPE = trailingPE;
			this._trailingAnnualDividendYield = trailingAnnualDividendYield;
			this._epsTrailingTwelveMonths = epsTrailingTwelveMonths;
			this._fiftyDayAverage = fiftyDayAverage;
			this._marketCap = marketCap;
			this._averageAnalystRating = averageAnalystRating;
			this._postMarketChangePercent = postMarketChangePercent;
			this._postMarketPrice = postMarketPrice;
			this._regularMarketChangePercent = regularMarketChangePercent;
			this._regularMarketPrice = regularMarketPrice;
			this._regularMarketDayRange = regularMarketDayRange;
			this._regularMarketVolume = regularMarketVolume;
			this._regularMarketPreviousClose = regularMarketPreviousClose;
			this._bid = bid;
			this._ask = ask;
			this._bidSize = bidSize;
			this._askSize = askSize;
			this._fullExchangeName = fullExchangeName;
			this._regularMarketOpen = regularMarketOpen;
			this._averageDailyVolume10Day = averageDailyVolume10Day;
			this._fiftyTwoWeekRange = fiftyTwoWeekRange;
			this._longName = longName;
			this._symbol = symbol;
		}


		public StockQuote() { }
		#endregion

		#region

		#endregion
	}
}

