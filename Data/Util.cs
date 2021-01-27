using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockOptionsHelper.Data
{
	static class Util
	{
		public static String determineAppDataPath()
		{
			//For now, we will define this very simply: If the Data folder exists, then app data exists.
			//If A Data Folder exists in the same path as the executable, then use it.
			//Else if a Data Folder exists in the user's default application data path, then use it.
			//Else, prompt to ask where to create the Data folder!
			String exePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			String appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			List<String> pathsToCheck = new List<String> { exePath, appDataPath };
			

			foreach (String toCheck in pathsToCheck)
			{
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
			
			if (!String.IsNullOrEmpty(pathToCreate))
			{
				try
				{
					System.IO.Directory.CreateDirectory(pathToCreate);
					return pathToCreate;
				} catch(Exception e)
				{
					MessageBox.Show("Error creating directory at " + pathToCreate + " Error was: " + e.Message);
				}
			}
			return ""; //Should only reach here if an error ocurred.
		}
	}
}
