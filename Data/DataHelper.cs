﻿using System;
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
		
		protected Data data { get; set; } //Could change this in the future if we want to allow switching out data, but for now this is the simple play to make it private.

		private DataHelper()
		{
			data = new Data();
			data.AppDataPath = DataUtil.determineAppDataPath();


		}

		public List<String> GetExpirationDates(String symbol)
		{
			StockSymbol sym = getSymbol(symbol);
			sym.

		}

		private StockSymbol getSymbol(String symbol)
		{
			return data.getSymbol(symbol);
		}
	}
}
