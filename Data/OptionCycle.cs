using System;

namespace StockOptionsHelper.Data
{
	public class OptionCycle
	{
		public enum CycleMonths { Unknown, January, February, March}
		public readonly CycleMonths CycleMonth;
		public readonly bool HasLeaps;
		public readonly bool HasWeeklies;

		
		public OptionCycle(CycleMonths month = CycleMonths.Unknown, bool hasLeaps = false, 
			bool hasWeeklies = false)
		{
			this.CycleMonth = month; this.HasLeaps = hasLeaps; this.HasWeeklies = hasWeeklies;
		}

		public OptionCycle(String month, String hasLeaps, String hasWeeklies ) : 
			this(ConvertToCycleMonth(month), ConvertToHasValue(hasLeaps), ConvertToHasValue(hasWeeklies))
		{
			
		}

		public static CycleMonths ConvertToCycleMonth(String month)
		{
			switch(month)
			{
				case "January":
					return CycleMonths.January;
				case "February":
					return CycleMonths.January;
				case "March":
					return CycleMonths.January;
				default: 
					return CycleMonths.Unknown;
			}
		}
		public static bool ConvertToHasValue(String hasValue)
		{
			return hasValue == "Y";
		}
		public static String ConvertToHasValue(bool hasValue)
		{
			if (hasValue)
				return "Y";
			return "N";

		}
	}
}