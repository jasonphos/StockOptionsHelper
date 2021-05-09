using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockOptionsHelper.Data
{
	internal class DataHelper
	{
		public static DataHelper Instance = new DataHelper();
		public const String DATA_FOLDER_NAME = "Data";
		
		protected DataStock data { get; set; } //Could change this in the future if we want to allow switching out data, but for now this is the simple play to make it private.

		private DataHelper()
		{
			data = new DataStock();
			data.AppDataPath = DataUtil.determineAppDataPath();


		}

		public List<String> GetExpirationDates(String symbol)
		{
			StockSymbol sym = getSymbol(symbol);
			return sym.ExpirationDates;
		}

		private StockSymbol getSymbol(String symbol)
		{
			return data.getSymbol(symbol);
		}
	}
}
