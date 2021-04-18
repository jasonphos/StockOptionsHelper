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

namespace StockOptionsHelper
{
	public partial class ThetaReturnCalculator : Form
	{
		private DataHelper DH;
		public ThetaReturnCalculator()
		{
			DH = DataHelper.Instance;
			InitializeComponent();
			SetupRows(1, 12); //The minimum and maximum tabindex for the columns to the row!
			SetDefaults();
		}
		private static readonly string CSP_PREFIX = "btnCSPToggle";
		private static readonly string CC_PREFIX = "btnCCToggle";

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
					CheckBox cspButton = (CheckBox)control;
					cspButton.Click += new System.EventHandler(this.btnCSPToggle_Click_Handler);
				} else if (control.Name.StartsWith(CC_PREFIX)) {
					CheckBox cspButton = (CheckBox)control;
					cspButton.Click += new System.EventHandler(this.btnCCToggle_Click_Handler);
				}


				IncrementControlInfo(newControl, nSuffix, prefix, rowNum, columnCount);
				this.Controls.Add(newControl);
				newControl.Show();
			}
			
		}

		private void IncrementControlInfo(Control control, int nSuffix, String prefix, int rowNum, int columnCount) {
			nSuffix++;
			String newName = prefix + nSuffix.ToString("000");
			control.Name = newName;
			control.TabIndex = control.TabIndex + (rowNum * columnCount);
		}

		private void SaveScreen() {
			//This will Save the record as a history, if there
		}
		private void btnCSPToggle_Click_Handler(object sender, EventArgs e) {
			handleTogglesClicked( ((CheckBox) sender).Name, CSP_PREFIX, CC_PREFIX);
		}
		private void btnCCToggle_Click_Handler(object sender, EventArgs e) {
			handleTogglesClicked(((CheckBox)sender).Name, CC_PREFIX, CSP_PREFIX);
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

	}
}
