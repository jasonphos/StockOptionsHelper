using StockOptionsHelper.Data;
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
			SetDefaults();
		}
		private static readonly string CSP_PREFIX = "btnCSPToggle";
		private static readonly string CC_PREFIX = "btnCCToggle";

		private void SetDefaults() {
			//Defaults should set it equal to the previous setting

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
