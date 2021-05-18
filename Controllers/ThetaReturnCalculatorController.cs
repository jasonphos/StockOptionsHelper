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

		public void CalculateCoveredCallReturn(DateTime expirationDate, decimal sharePrice, decimal strike, int quantity, decimal optionPremium,
			out decimal investedAmount, out decimal expectedProfit, out decimal expectedProfitPerc, out decimal expectedProfitAnnualPerc,
			out decimal expectedMaxProfit, out decimal expectedMaxProfitPerc, out decimal expectedMaxProfitAnnualPerc, int OPTION_SHARES_PER_CONTRACT = 100) {



			investedAmount = (sharePrice * quantity * OPTION_SHARES_PER_CONTRACT) - (quantity * optionPremium);
			expectedProfit = optionPremium * quantity;
			expectedProfitPerc = CalculateRawPerc(investedAmount, expectedProfit);
			expectedProfitAnnualPerc = CalculateAnnualPerc(expirationDate, investedAmount, expectedProfit);
			expectedMaxProfit = expectedProfit + ((strike - sharePrice) * OPTION_SHARES_PER_CONTRACT * quantity);
			expectedMaxProfitPerc = CalculateRawPerc(investedAmount, expectedMaxProfit);
			expectedMaxProfitAnnualPerc = CalculateAnnualPerc(expirationDate, investedAmount, expectedMaxProfit);
		}

		private decimal CalculateRawPerc(decimal investedAmount, decimal profit) {
			return profit / investedAmount;
		}
		private decimal CalculateAnnualPerc(DateTime expirationDate, decimal investedAmount, decimal profit) {

			double days = (expirationDate - DateTime.Now.Date).TotalDays;

		}
	}
}
