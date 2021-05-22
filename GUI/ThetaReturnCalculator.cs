using StockOptionsHelper.Controllers;
using StockOptionsHelper.Data;
using StockOptionsHelper.ThirdParty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static StockOptionsHelper.Controllers.ThetaReturnCalculatorController;

namespace StockOptionsHelper
{
	public partial class ThetaReturnCalculator : Form
	{
		private DataHelper DH;
		private FormController formController = new FormController();
		private ThetaReturnCalculatorController calculator = new ThetaReturnCalculatorController();
		
		public ThetaReturnCalculator()
		{
			DH = DataHelper.Instance;
			InitializeComponent();
			SetupRows(1, 15); //The minimum and maximum tabindex for the columns to the row!
			SetDefaults();
		}

		private static string SYMBOL_PREFIX = "txtSymbol";
		private static readonly string SHARE_PRICE_PREFIX = "txtSharePrice";
		private static readonly string CSP_PREFIX = "btnCSPToggle";
		private static readonly string CC_PREFIX = "btnCCToggle";
		
		private static readonly string EXP_DATE_PREFIX = "cmboExpDate";
		private static readonly string STRIKE_PRICE_PREFIX = "txtStrike";
		private static readonly string CONTRACT_QUANTITY_PREFIX = "txtQuantity";
		private static readonly string CONTRACT_PRICE_PREFIX = "txtContractPrice";
		private static readonly string INVESTED_AMOUNT_PREFIX = "txtInvAmt";
		private static readonly string EXPECTED_PROFIT_AMT_PREFIX = "txtExpProfitAmt";
		private static readonly string EXPECTED_PROFIT_PERCENT_PREFIX = "txtExpProfitPerc";
		private static readonly string EXPECTED_PROFIT_PERCENT_APR_PREFIX = "txtExpProfitPercAPR";
		private static readonly string MAX_PROFIT_AMT_PREFIX = "txtMaxProfitAmt";
		private static readonly string MAX_PROFIT_PERCENT_PREFIX = "txtMaxProfitPerc";
		private static readonly string MAX_PROFIT_PERCENT_APR_PREFIX = "txtMaxProfitPercAPR";




		private void SetDefaults() {
			//Defaults should set it equal to the previous setting

		}

		/// <summary>
		/// This Method will setup the number of Rows specified, and hookup events for each control. Note: It determines what to include in the row based
		/// upon the min and max tab stop values. This way, if a control is ever added (or removed), it will still work!
		/// </summary>
		private void SetupRows(int minRowTabIndex, int maxRowTabIndex) {
			//1. Get the number of rows.
			//2. Assign the minimum and maximum tabstop values for the controls that will be duplicated, also get the initial max count of controls.
			//3. Loop through all controls on the form (up to the initial max count), and if the control's tabstop value is within min/max, then duplicate it!
			int numberRows;
			
			try {
				numberRows = int.Parse(txtRows.Text);
			} catch (Exception e) {
				//Todo: Log exception to an application log file.
				numberRows = 6; //Default to 6
			}
			int rowsLeft = numberRows - 1; //How many rows we have let to create.
			int initialMax = Controls.Count;

			while (rowsLeft > 0) {
				for (int i = 0; i < initialMax; i++) {
					Control control = Controls[i];
					if (control.TabIndex >= minRowTabIndex && control.TabIndex <= maxRowTabIndex) {
						DuplicateControlForRow(control, numberRows - rowsLeft, maxRowTabIndex - minRowTabIndex);
					}
				}
				rowsLeft--;
			}
		}

		private void DuplicateControlForRow(Control control, int rowNum, int columnCount) {
			//c.GetType() == typeof(TForm)
			int RowSpace = 15; //Space between rows
			int ROW_SIZE_DIGITS = 3; //Assumes that row controls are named with 3 characters on the end for the row number;
			int SOURCE_ROW_NUMBER = 1;

			String suffix = control.Name.Substring(control.Name.Length - ROW_SIZE_DIGITS);
			String prefix = control.Name.Substring(0, control.Name.Length - ROW_SIZE_DIGITS);

			int nSuffix = SOURCE_ROW_NUMBER; //Only do this for those named with 001 on the end
			try {
				nSuffix = int.Parse(suffix);

			} catch (Exception e) {
				//If tabindex is within range but it isn't named as a row entry, then ignore.. TODO: Add logging here, probably info level or something like that since this can be legitimate...
			}
			if (nSuffix == SOURCE_ROW_NUMBER) {
				Control newControl = ControlFactory.CloneCtrl(control);
				newControl.Location = new Point(newControl.Location.X, newControl.Location.Y + (newControl.Height + RowSpace)*rowNum);

				if (control.Name.StartsWith(CSP_PREFIX)) {
					CheckBox cspButton = (CheckBox)newControl;
					cspButton.Click += new System.EventHandler(this.btnCSPToggle_Click_Handler);
				} else if (control.Name.StartsWith(CC_PREFIX)) {
					CheckBox ccButton = (CheckBox)newControl;
					ccButton.Click += new System.EventHandler(this.btnCCToggle_Click_Handler);
				} else if (control.Name.StartsWith(SHARE_PRICE_PREFIX) || control.Name.StartsWith(STRIKE_PRICE_PREFIX) || control.Name.StartsWith(CONTRACT_QUANTITY_PREFIX)) {
					TextBox field = (TextBox)newControl;
					field.TextChanged += new EventHandler(this.handleTextBoxChanged);
				} else if (control.Name.StartsWith(EXP_DATE_PREFIX)) {
					ComboBox box = (ComboBox)newControl;
					box.TextChanged += new EventHandler(this.handleTextBoxChanged);
				}


				IncrementControlInfo(newControl, prefix, rowNum+1, columnCount);
				this.Controls.Add(newControl);
				newControl.Show();
			}
			
		}

		private void IncrementControlInfo(Control control, String prefix, int rowNum, int columnCount) {
			String newName = prefix + rowNum.ToString("000"); //Note: Hardcoding a limit of 999 rows with this. Not likely to ever need more, but if we do will need to refactor.
			control.Name = newName;
			control.TabIndex = control.TabIndex + (rowNum * columnCount);
		}

		private void SaveScreen() {
			//This will Save the record as a history, if there
		}
		private void btnCSPToggle_Click_Handler(object sender, EventArgs e) {
			handleTogglesClicked( ((CheckBox) sender).Name, CSP_PREFIX, CC_PREFIX);
			//Also, this should trigger handleTextBoxChanged, because that will run the calculator if all textboxes are ready.
			handleTextBoxChanged(sender, e);
		}
		private void btnCCToggle_Click_Handler(object sender, EventArgs e) {
			handleTogglesClicked(((CheckBox)sender).Name, CC_PREFIX, CSP_PREFIX);
			//Also, this should trigger handleTextBoxChanged, because that will run the calculator if all textboxes are ready.
			handleTextBoxChanged(sender, e);
		}

		private void handleTogglesClicked(string clickedName, string clickedPrefix, string otherPrefix) {
			string suffix = clickedName.Substring(clickedPrefix.Length);
			CheckBox btnClicked = (CheckBox) this.Controls.Find(clickedPrefix + suffix, true).FirstOrDefault();
			CheckBox btnOther = (CheckBox)this.Controls.Find(otherPrefix + suffix, true).FirstOrDefault();

			if (btnClicked.Checked == true) {
				btnOther.Checked = false;
			} else {
				btnOther.Checked = true;
			}
		}

		private void handleTextBoxChanged(object sender, EventArgs e) {
			Control source = (Control)sender;
			//If all of the fields needed to do the calculation are filled out, then do it and display the results!
			String suffix = determineSuffix(source.Name);
			if (isRowReady(suffix)) {

				decimal investedAmount; decimal expectedProfit; decimal expectedProfitPerc; decimal expectedProfitAnnualPerc;
				decimal expectedMaxProfit; decimal expectedMaxProfitPerc; decimal expectedMaxProfitAnnualPerc;
				switch (getCalculationType(suffix)) {
					case ReturnCalculationType.CoveredCall:
						calculator.CalculateCoveredCallReturn(getFieldValueDateTime(EXP_DATE_PREFIX, suffix), getFieldValueDecimal(SHARE_PRICE_PREFIX, suffix),
							getFieldValueDecimal(STRIKE_PRICE_PREFIX, suffix), getFieldValueInt(CONTRACT_QUANTITY_PREFIX, suffix),
							getFieldValueInt(CONTRACT_PRICE_PREFIX, suffix), out investedAmount, out expectedProfit, out expectedProfitPerc, out expectedProfitAnnualPerc,
							out expectedMaxProfit, out expectedMaxProfitPerc, out expectedMaxProfitAnnualPerc);
						break;
					case ReturnCalculationType.CashSecuredPut:
						calculator.CalcualteCashSecuredPutReturn(getFieldValueDateTime(EXP_DATE_PREFIX, suffix), getFieldValueDecimal(SHARE_PRICE_PREFIX, suffix),
							getFieldValueDecimal(STRIKE_PRICE_PREFIX, suffix), getFieldValueInt(CONTRACT_QUANTITY_PREFIX, suffix),
							getFieldValueInt(CONTRACT_PRICE_PREFIX, suffix), out investedAmount, out expectedProfit, out expectedProfitPerc, out expectedProfitAnnualPerc,
							out expectedMaxProfit, out expectedMaxProfitPerc, out expectedMaxProfitAnnualPerc);
						break;
				}



			}
		}

		/// <summary>
		/// This function knows whether a row is ready to calculate the return or not, by checking each individual control (i.e. dependent textboxes, buttons)
		/// anyFieldName - This can be the field name for any field in the row.
		/// </summary>
		/// <param name="anyFieldName"></param>
		/// <returns></returns>
		private bool isRowReady(String suffix) {
			if (isFieldReady(SHARE_PRICE_PREFIX, suffix) && isFieldReady(EXP_DATE_PREFIX, suffix) && isFieldReady(STRIKE_PRICE_PREFIX, suffix) 
				&& isFieldReady(CONTRACT_QUANTITY_PREFIX, suffix) && areToggleButtonsReady(CSP_PREFIX, CC_PREFIX, suffix)) {
				return true;
			}
			return false;
		}

		private bool isFieldReady(String name, String suffix = "") {
			//Todo: Could do better validation checks on the fields, but for now we'll just make sure they are valued.
			String value = getFieldValue(name, suffix);
			if (String.IsNullOrWhiteSpace(value))
				return false;
			return true;
		}

		/// <summary>
		/// For TextBox fields and ComboBox fields, and possibly more. May or may not be useful for other fields, as currently it will return ctrl.Text for any control, so use carefully for non text boxes.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="suffix"></param>
		/// <returns></returns>
		private String getFieldValue(String name, String suffix = "") {
			Control ctrl = this.Controls.Find(name + suffix, true).FirstOrDefault();
			return ctrl.Text;
		}
		private DateTime getFieldValueDateTime(String name, String suffix = "") {
			Control ctrl = this.Controls.Find(name + suffix, true).FirstOrDefault();
			return DateTime.Parse(ctrl.Text);
		}
		private Decimal getFieldValueDecimal(String name, String suffix = "") {
			Control ctrl = this.Controls.Find(name + suffix, true).FirstOrDefault();
			return Decimal.Parse(ctrl.Text);
		}
		private int getFieldValueInt(String name, String suffix = "") {
			Control ctrl = this.Controls.Find(name + suffix, true).FirstOrDefault();
			return int.Parse(ctrl.Text);
		}

		private Control getControl(String name, String suffix = "") {
			return this.Controls.Find(name + suffix, true).FirstOrDefault();
		}

		private void setFieldValue
		private ReturnCalculationType getCalculationType(String suffix) {
			CheckBox cspButton = (CheckBox) this.Controls.Find(CSP_PREFIX + suffix, true).FirstOrDefault();
			CheckBox ccButton = (CheckBox)this.Controls.Find(CC_PREFIX + suffix, true).FirstOrDefault();
			if (cspButton.Checked)
				return ReturnCalculationType.CashSecuredPut;
			else
				return ReturnCalculationType.CoveredCall;
		}

		private bool areToggleButtonsReady(String name1, String name2, String suffix = "") {
			//This check may end up not being necessary, because we have the feature to default the value of the cc or csp, but for now it makes logical sense so I will put it in.
			CheckBox button1 = (CheckBox)this.Controls.Find(name1 + suffix, true).FirstOrDefault();
			CheckBox button2 = (CheckBox)this.Controls.Find(name2 + suffix, true).FirstOrDefault();
			if (button1.Checked || button2.Checked) { //XOR would be appropriate, but also this buttons are toggle so only one can be set, will assume that is working so no XOR needed
				return true;
			}
			return false;
		}
		private String determinePrefix(String name) {
			String suffix; String prefix;
			determinePrefixSuffix(name, out prefix, out suffix);
			return prefix;
		}

		private String determineSuffix(String name) {
			String suffix; String prefix;
			determinePrefixSuffix(name, out prefix, out suffix);
			return suffix;
		}

		private void determinePrefixSuffix(String name, out String prefix, out String suffix) {
			//This assumes for rows that our fields our named as alpha prefixes, followed by numeric suffix. In fact, the prefix can contain
			//numeric characters, just so long as the last character in the prefix is not numeric!
			int pos = name.Length;
			while (!Char.IsLetter(name[pos-1])) {
				--pos;
			}
			prefix = name.Substring(0, pos);
			suffix = name.Substring(pos - 1);
		}

	}
}
