using System;
using System.Collections.Generic;

namespace StockOptionsHelper.Data {
	internal class ApplicationCacheTracker {
		

		private static readonly ApplicationCacheTracker instance = new ApplicationCacheTracker();

		private static readonly Dictionary<string, int> listCacheTimeoutSeconds;
		private static int DefaultCacheTimeoutSeconds = 300;
		static ApplicationCacheTracker() {
			listCacheTimeoutSeconds.Add("ExpirationDates", 3600);
		}

		private ApplicationCacheTracker() { }

		public static ApplicationCacheTracker Instance {
			get { return instance; }
		}

		//*********************BEGIN Instance Implementation (not static)*********************************
		private Dictionary<string, DateTime> listExpDateTimes;

		internal bool isValid(string key) {
			if (listExpDateTimes.ContainsKey(key)) {
				DateTime now = DateTime.Now;
				if (now < listExpDateTimes[key])
					return true;
			}
			return false;
		}

		internal void resetCache(string key) {
			listExpDateTimes[key] = DateTime.Now;
		}

	}
}