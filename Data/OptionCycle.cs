using System;

namespace StockOptionsHelper.Data
{
	public class OptionCycle
	{
		public enum CycleMonths { Unknown, January, February, March}
		public enum CycleLeaps { None, Standard, ExtendedJanMarJunSept}
		public readonly CycleMonths CycleMonth;
		public readonly CycleLeaps CycleLeap;
		public readonly bool HasWeeklies;

		
		public OptionCycle(CycleMonths month = CycleMonths.Unknown, 
			CycleLeaps CycleLeap = CycleLeaps.None, bool hasWeeklies = false)
		{
			this.CycleMonth = month; this.CycleLeap = CycleLeap; this.HasWeeklies = hasWeeklies;
		}

		public OptionCycle(String month, String cycleLeap, String hasWeeklies) : 
			this(ConvertToCycleMonth(month), ConvertToCycleLeap(cycleLeap), ConvertToHasValue(hasWeeklies))
		{
			
		}

		public static CycleLeaps ConvertToCycleLeap(String cycleLeap) {
			switch(cycleLeap) {
				case "None":
					return CycleLeaps.None;
				case "Standard":
					return CycleLeaps.Standard;
				case "ExtendedJanMarJunSept":
					return CycleLeaps.ExtendedJanMarJunSept;
				default:
					return CycleLeaps.None;

			}

		}
		public static CycleMonths ConvertToCycleMonth(String month)
		{
			switch(month)
			{
				case "January":
					return CycleMonths.January;
				case "February":
					return CycleMonths.February;
				case "March":
					return CycleMonths.March;
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