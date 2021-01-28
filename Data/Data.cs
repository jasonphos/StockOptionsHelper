using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOptionsHelper.Data
{
	internal class Data
	{
		public String AppDataPath { get; set; }
		private Dictionary<String, StockSymbol> Symbols;
		public StockSymbol getSymbol(String symbol)
		{
			if (Symbols.ContainsKey(symbol))
				return Symbols[symbol];
			else
				return new StockSymbol(symbol); //In future, we could consider tracking this so it can be saved to db or file, but for now we'll just do this.
		}
	}
}
