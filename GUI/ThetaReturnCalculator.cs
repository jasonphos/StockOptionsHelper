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
			//this.MaximumSize = new System.Drawing.Size(3500, 2500);

			//this.Size = new Size(1630, 800);
			//System.Windows.Forms.MessageBox.Show(this.Size.ToString());

			SetDefaults();
		}

		private void SetDefaults() {
			//Defaults should set it equal to the previous setting

		}
		private void SaveScreen() {
			//This will Save the record as a history, if there
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e) {

		}

		private void label14_Click(object sender, EventArgs e) {

		}

		private void textBox6_TextChanged(object sender, EventArgs e) {

		}
	}
}
