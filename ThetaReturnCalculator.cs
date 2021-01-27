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

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
