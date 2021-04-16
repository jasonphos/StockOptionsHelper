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
		private ApplicationCacheTracker cacheTracker = ApplicationCacheTracker.Instance;
		public String CompanyName { get; set; }
		private List<String> expirationDates;
		public List<String> ExpirationDates {
			get {
				if (expirationDates != null && cacheTracker.isValid("ExpirationDates"))
					return expirationDates;
				else
				{
					expirationDates = determineExpirationDatesFormatted();
					cacheTracker.resetCache("ExpirationDates");
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

		private List<DateTime> determineExpirationDates() {
			HashSet<DateTime> listExpDates = new HashSet<DateTime>();

			if (Cycle.HasWeeklies)
				DataUtil.addWeeklyExpirationDates(listExpDates);
			DataUtil.addLeapExpirationDates(listExpDates, Cycle.CycleLeap);
			DataUtil.addMonthlyExpirationDates(listExpDates);

			List<DateTime> toReturn;
			toReturn = listExpDates.ToList();
			toReturn.Sort();
			return listExpDates.ToList<DateTime>();
		}
		private List<string> determineExpirationDatesFormatted() {
			List<DateTime> listExpDates = determineExpirationDates();
			DateTime today = DateTime.Today;
			List<string> toReturn = new List<string>();

			foreach (DateTime theDate in listExpDates) {
				String format;
				if ((theDate.Year > today.Year)) //If not current year, then stick the year on it. Could change formatting in future of course, move it elsewhere...
					format = "MMM DD, YYYY";
				else
					format = "MMM DD";

				toReturn.Add(theDate.ToString(format));
			}
			return toReturn;
		}

	}
}
