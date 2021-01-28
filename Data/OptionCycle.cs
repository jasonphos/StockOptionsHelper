namespace StockOptionsHelper.Data
{
	public class OptionCycle
	{
		public enum CycleMonths { Unknown, January, February, March}
		public readonly CycleMonths Month;
		public readonly bool HasLeaps;
		public readonly bool HasWeeklies;

		public OptionCycle(CycleMonths month = CycleMonths.Unknown, bool hasLeaps = false, 
			bool hasWeeklies = false)
		{
			this.Month = month; this.HasLeaps = hasLeaps; this.HasWeeklies = hasWeeklies;
		}
	}
}