using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOptionsHelper.Controllers {
	class ThetaReturnCalculatorController {
		public enum ReturnCalculationType {
			CoveredCall, CashSecuredPut
		}

		public void CalculateCoveredCallReturn(DateTime ExpirationDate, decimal SharePrice, decimal strike, int quantity, 
			out decimal InvestedAmount, out decimal ExpectedProfit, out decimal ExpectedProfitPerc, out decimal ExpectedProfitAnnualPerc,
			out decimal ExpectedMaxProfit, out decimal ExpectedMaxProfitPerc, out decimal ExpectedMaxProfitAnnualPerc, int OPTION_SHARES_PER_CONTRACT = 100) {

			

			decimal InvestedAmount = (SharePrice * quantity * OPTION_SHARES_PER_CONTRACT) - 
		}

		private void CalculateRawPerc(decimal InvestedAmount, decimal Profit) {

		}
		private decimal CalculateAnnualPerc(DateTime ExpirationDate, decimal Profit) {

		}
	}
}
