using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockOptionsHelper.Data
{
	sealed internal class DataHelper
	{
		public static DataHelper Instance = new DataHelper();
		public const String DATA_FOLDER_NAME = "Data";
		public Data data { get; set; }

		private DataHelper()
		{
			data = new Data();
			data.AppDataPath = Util.determineAppDataPath();


		}
	}
}
