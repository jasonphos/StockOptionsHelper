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
		public static String DATA_FOLDER_NAME = "Data";
		public Data DataObject { get; set; }

		public void InitializeData()
		{
			

		}
	}
}
