using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOptionsHelper.Data
{
	static class DataUtil {
		public static String determineAppDataPath() {
			//For now, we will define this very simply: If the Data folder exists, then app data exists.
			//If A Data Folder exists in the same path as the executable, then use it.
			//Else if a Data Folder exists in the user's default application data path, then use it.
			//Else, prompt to ask where to create the Data folder!
			String exePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			String appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			List<String> pathsToCheck = new List<String> { exePath, appDataPath };
			

			foreach (String toCheck in pathsToCheck) {
				String toCheckDataFolder = System.IO.Path.Combine(toCheck, DataHelper.DATA_FOLDER_NAME);
				if (System.IO.Directory.Exists(toCheckDataFolder))
					return toCheckDataFolder;
			}

			String pathToCreate = "";
			DialogResult result = MessageBox.Show("Data Directory does not exist. Would you like to create this directory in the same folder as the Program? Yes to do so, or No to create it in AppData", "Data Directory not found", MessageBoxButtons.YesNoCancel);
			if (result == DialogResult.Yes)
				pathToCreate = exePath;
			else if (result == DialogResult.No)
				pathToCreate = appDataPath;
			
			if (!String.IsNullOrEmpty(pathToCreate)) {
				try {
					System.IO.Directory.CreateDirectory(pathToCreate);
					return pathToCreate;
				} catch(Exception e) {
					MessageBox.Show("Error creating directory at " + pathToCreate + " Error was: " + e.Message);
				}
			}
			return ""; //Should only reach here if an error ocurred.
		}

		internal static List<string> determineExpirationDates(StockSymbol stockSymbol) {
			List<string> listExpDates = new List<string>();
			OptionCycle cycle = stockSymbol.Cycle;
			DateTime nextMonthly  = 
			if (cycle.CycleMonth == CycleMonths.)
		}
		private static void addWeeklyExpirationDate(List<string> listExpDates) {
			DateTime today = DateTime.Today;
			// The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
			int daysUntilFriday = ((int)DayOfWeek.Friday - (int)today.DayOfWeek + 7) % 7;
			DateTime nextFriday = today.AddDays(daysUntilFriday);
			DateTime targetWeek = nextFriday.AddDays(7 * weeksOut);
			return targetWeek;  
		}

		private static void addMonthlyExpirationDates(List<string> listExpDates) {
			//Monthly Options always expire the 3rd Friday of the month, unless Friday is a holiday. 
			//Todo: Code a holiday exception.
			DateTime today = DateTime.Today;

			
			DateTime targetMonth = today.AddMonths(monthsOut);
			DateTime targetMonthMonthlyExp = FindDayReturnDate(today, DayOfWeek.Friday, 3); 
			if (today <= targetMonthMonthlyExp) //Todo: Could consider a time factor in the future, i.e. if we wanted to cutoff displaying today as an expiration after a certain time. Could make it a configuration item when we code this feature.
				return 
		}

		//For example to find the day for 2nd Friday, February, 2016
		//=>call FindDay(2016, 2, DayOfWeek.Friday, 2)
		public static int FindDay(int year, int month, DayOfWeek Day, int occurance) {

			if (occurance <= 0 || occurance > 5)
				throw new Exception("Occurance is invalid");

			DateTime firstDayOfMonth = new DateTime(year, month, 1);
			//Substract first day of the month with the required day of the week 
			var daysneeded = (int)Day - (int)firstDayOfMonth.DayOfWeek;
			//if it is less than zero we need to get the next week day (add 7 days)
			if (daysneeded < 0) daysneeded = daysneeded + 7;
			//DayOfWeek is zero index based; multiply by the Occurance to get the day
			var resultedDay = (daysneeded + 1) + (7 * (occurance - 1));

			if (resultedDay > (firstDayOfMonth.AddMonths(1) - firstDayOfMonth).Days)
				throw new Exception(String.Format("No {0} occurance(s) of {1} in the required month", occurance, Day.ToString()));

			return resultedDay;
		}

		public static DateTime FindDayReturnDate(int year, int month, DayOfWeek Day, int occurance) {
			int dayOfMonth = FindDay(year, month, Day, occurance);
			return new DateTime(year, month, dayOfMonth)
		}

		public static DateTime FindDayReturnDate(DateTime currentDate, DayOfWeek Day, int occurance) {
			return FindDayReturnDate(currentDate.Year, currentDate.Month, Day, occurance);
		}
	}
}
