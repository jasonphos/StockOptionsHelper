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

		public void CalculateCoveredCallReturn(DateTime expirationDate, decimal sharePrice, decimal strike, int quantity, decimal contractPrice,
			out decimal investedAmount, out decimal expectedProfit, out decimal expectedProfitPerc, out decimal expectedProfitAnnualPerc,
			out decimal expectedMaxProfit, out decimal expectedMaxProfitPerc, out decimal expectedMaxProfitAnnualPerc, int OPTION_SHARES_PER_CONTRACT = 100) {

			investedAmount = (sharePrice * quantity * OPTION_SHARES_PER_CONTRACT) - (quantity * contractPrice * OPTION_SHARES_PER_CONTRACT);
			expectedProfit = contractPrice * quantity * OPTION_SHARES_PER_CONTRACT;
			expectedProfitPerc = CalculateRawPerc(investedAmount, expectedProfit);
			expectedProfitAnnualPerc = CalculateAnnualPerc(expirationDate, investedAmount, expectedProfit);
			expectedMaxProfit = expectedProfit + ((strike - sharePrice) * OPTION_SHARES_PER_CONTRACT * quantity);
			expectedMaxProfitPerc = CalculateRawPerc(investedAmount, expectedMaxProfit);
			expectedMaxProfitAnnualPerc = CalculateAnnualPerc(expirationDate, investedAmount, expectedMaxProfit);
		}

		public void CalcualteCashSecuredPutReturn(DateTime expirationDate, decimal sharePrice, decimal strike, int quantity, decimal contractPrice,
			out decimal investedAmount, out decimal expectedProfit, out decimal expectedProfitPerc, out decimal expectedProfitAnnualPerc,
			out decimal expectedMaxProfit, out decimal expectedMaxProfitPerc, out decimal expectedMaxProfitAnnualPerc, int OPTION_SHARES_PER_CONTRACT = 100) {

			investedAmount = (strike * quantity * OPTION_SHARES_PER_CONTRACT) - (quantity * contractPrice * OPTION_SHARES_PER_CONTRACT);
			expectedProfit = contractPrice * quantity * OPTION_SHARES_PER_CONTRACT;
			expectedProfitPerc = CalculateRawPerc(investedAmount, expectedProfit);
			expectedProfitAnnualPerc = CalculateAnnualPerc(expirationDate, investedAmount, expectedProfit);
			expectedMaxProfit = expectedProfit;
			expectedMaxProfitPerc = expectedProfitPerc;
			expectedMaxProfitAnnualPerc = expectedProfitAnnualPerc;
		}


		private decimal CalculateRawPerc(decimal investedAmount, decimal profit) {
			return profit / investedAmount;
		}
		private decimal CalculateAnnualPerc(DateTime expirationDate, decimal investedAmount, decimal profit) {

			//(1 + Return) ^ (1 / N) - 1    (i.e. for a 1.5 return over 5 years, it would be (1 + 1.5) ^ (1 / 5) - 1 = 20% )
			double days = (expirationDate - DateTime.Now.Date).TotalDays;

			double onePlusReturn = (double) (1 + (profit / investedAmount));
			double toReturn = Math.Pow(onePlusReturn, 1 / (days / 365)) - 1; //Technically you could factor in leap years instead of hardcoding 365 days/year, but its probably not worth it, plus how would you do it? Would be complicated to come up with something, and it would have such a small impact, I doubt it would be useful.
			return (decimal) toReturn; 

		}
	}
}
