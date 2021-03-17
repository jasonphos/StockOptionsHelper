using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOptionsHelper.Data
{
	public class StockSymbol
	{
		public readonly String Symbol;
		public OptionCycle Cycle;
		public String CompanyName { get; set; }
		private List<String> expirationDates;
		public List<String> ExpirationDates {
			get {
				if (expirationDates != null && isCacheValid("ExpirationDates"))
					return expirationDates;
				else
				{
					expirationDates = DataUtil.determineExpirationDates(this);
					return expirationDates;
				}
			} set
			{

			}
		}
		private Dictionary<String, DateTime> CacheExpiration { get; set;}
		public StockSymbol(String symbol)
		{
			this.Symbol = symbol;
			CacheExpiration = new Dictionary<string, DateTime>();
		}


	}
}
