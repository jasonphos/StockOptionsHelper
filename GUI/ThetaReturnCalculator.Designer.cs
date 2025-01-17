﻿
namespace StockOptionsHelper
{
	partial class ThetaReturnCalculator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCSPToggleDefault = new System.Windows.Forms.CheckBox();
			this.btnCCToggleDefault = new System.Windows.Forms.CheckBox();
			this.txtQuantity001 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmboExpDate001 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSharePrice001 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStrike001 = new System.Windows.Forms.TextBox();
			this.lblSymbol001 = new System.Windows.Forms.Label();
			this.txtSymbol001 = new System.Windows.Forms.TextBox();
			this.btnCSPToggle001 = new System.Windows.Forms.CheckBox();
			this.btnCCToggle001 = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmboExpDateDefault = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtSymbolDefault = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtInvAmt001 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtExpProfitAmt001 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtExpProfitPerc001 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtMaxProfitPerc001 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtMaxProfitAmt001 = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.label22 = new System.Windows.Forms.Label();
			this.txtContractPrice001 = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtExpProfitPercAPR001 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txtMaxProfitPercAPR001 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCSPToggleDefault
			// 
			this.btnCSPToggleDefault.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCSPToggleDefault.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCSPToggleDefault.Location = new System.Drawing.Point(22, 131);
			this.btnCSPToggleDefault.Margin = new System.Windows.Forms.Padding(4);
			this.btnCSPToggleDefault.Name = "btnCSPToggleDefault";
			this.btnCSPToggleDefault.Size = new System.Drawing.Size(208, 58);
			this.btnCSPToggleDefault.TabIndex = 3;
			this.btnCSPToggleDefault.Text = "Cash Secured Put";
			this.btnCSPToggleDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCSPToggleDefault.UseVisualStyleBackColor = true;
			this.btnCSPToggleDefault.Click += new System.EventHandler(this.btnCSPToggle_Click_Handler);
			// 
			// btnCCToggleDefault
			// 
			this.btnCCToggleDefault.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCCToggleDefault.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCCToggleDefault.Location = new System.Drawing.Point(246, 131);
			this.btnCCToggleDefault.Margin = new System.Windows.Forms.Padding(4);
			this.btnCCToggleDefault.Name = "btnCCToggleDefault";
			this.btnCCToggleDefault.Size = new System.Drawing.Size(209, 58);
			this.btnCCToggleDefault.TabIndex = 4;
			this.btnCCToggleDefault.Text = "Covered Call";
			this.btnCCToggleDefault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCCToggleDefault.UseVisualStyleBackColor = true;
			this.btnCCToggleDefault.Click += new System.EventHandler(this.btnCCToggle_Click_Handler);
			// 
			// txtQuantity001
			// 
			this.txtQuantity001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantity001.Location = new System.Drawing.Point(645, 331);
			this.txtQuantity001.Margin = new System.Windows.Forms.Padding(4);
			this.txtQuantity001.Name = "txtQuantity001";
			this.txtQuantity001.Size = new System.Drawing.Size(66, 33);
			this.txtQuantity001.TabIndex = 7;
			this.txtQuantity001.TextChanged += new System.EventHandler(this.handleTextBoxChanged);
			this.txtQuantity001.AutoSize = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(640, 290);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 33);
			this.label1.TabIndex = 30;
			this.label1.Text = "Quantity";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(404, 290);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 30);
			this.label2.TabIndex = 30;
			this.label2.Text = "Expiration Date";
			// 
			// cmboExpDate001
			// 
			this.cmboExpDate001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmboExpDate001.FormattingEnabled = true;
			this.cmboExpDate001.ItemHeight = 24;
			this.cmboExpDate001.Location = new System.Drawing.Point(410, 330);
			this.cmboExpDate001.Margin = new System.Windows.Forms.Padding(4);
			this.cmboExpDate001.Name = "cmboExpDate001";
			this.cmboExpDate001.Size = new System.Drawing.Size(136, 33);
			this.cmboExpDate001.TabIndex = 5;
			this.cmboExpDate001.TextChanged += new System.EventHandler(this.handleTextBoxChanged);
			this.cmboExpDate001.AutoSize = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(87, 290);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 25);
			this.label3.TabIndex = 30;
			this.label3.Text = "Share Price";
			// 
			// txtSharePrice001
			// 
			this.txtSharePrice001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSharePrice001.Location = new System.Drawing.Point(91, 332);
			this.txtSharePrice001.Margin = new System.Windows.Forms.Padding(4);
			this.txtSharePrice001.Name = "txtSharePrice001";
			this.txtSharePrice001.Size = new System.Drawing.Size(119, 33);
			this.txtSharePrice001.TabIndex = 2;
			this.txtSharePrice001.TextChanged += new System.EventHandler(this.handleTextBoxChanged);
			this.txtSharePrice001.AutoSize = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(562, 290);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 33);
			this.label4.TabIndex = 30;
			this.label4.Text = "Strike";
			// 
			// txtStrike001
			// 
			this.txtStrike001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStrike001.Location = new System.Drawing.Point(567, 332);
			this.txtStrike001.Margin = new System.Windows.Forms.Padding(4);
			this.txtStrike001.Name = "txtStrike001";
			this.txtStrike001.Size = new System.Drawing.Size(66, 33);
			this.txtStrike001.TabIndex = 6;
			this.txtStrike001.TextChanged += new System.EventHandler(this.handleTextBoxChanged);
			this.txtStrike001.AutoSize = false;
			// 
			// lblSymbol001
			// 
			this.lblSymbol001.AutoSize = true;
			this.lblSymbol001.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSymbol001.Location = new System.Drawing.Point(4, 290);
			this.lblSymbol001.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSymbol001.Name = "lblSymbol001";
			this.lblSymbol001.Size = new System.Drawing.Size(79, 25);
			this.lblSymbol001.TabIndex = 30;
			this.lblSymbol001.Text = "Symbol";
			// 
			// txtSymbol001
			// 
			this.txtSymbol001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSymbol001.Location = new System.Drawing.Point(9, 332);
			this.txtSymbol001.Margin = new System.Windows.Forms.Padding(4);
			this.txtSymbol001.Name = "txtSymbol001";
			this.txtSymbol001.Size = new System.Drawing.Size(77, 33);
			this.txtSymbol001.TabIndex = 1;
			this.txtSymbol001.AutoSize = false;
			// 
			// btnCSPToggle001
			// 
			this.btnCSPToggle001.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCSPToggle001.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCSPToggle001.Location = new System.Drawing.Point(219, 331);
			this.btnCSPToggle001.Margin = new System.Windows.Forms.Padding(4);
			this.btnCSPToggle001.Name = "btnCSPToggle001";
			this.btnCSPToggle001.Size = new System.Drawing.Size(94, 33);
			this.btnCSPToggle001.TabIndex = 3;
			this.btnCSPToggle001.Text = "C.S. Put";
			this.btnCSPToggle001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCSPToggle001.UseVisualStyleBackColor = true;
			this.btnCSPToggle001.Click += new System.EventHandler(this.btnCSPToggle_Click_Handler);
			// 
			// btnCCToggle001
			// 
			this.btnCCToggle001.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCCToggle001.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCCToggle001.Location = new System.Drawing.Point(321, 332);
			this.btnCCToggle001.Margin = new System.Windows.Forms.Padding(4);
			this.btnCCToggle001.Name = "btnCCToggle001";
			this.btnCCToggle001.Size = new System.Drawing.Size(82, 33);
			this.btnCCToggle001.TabIndex = 4;
			this.btnCCToggle001.Text = "C. Call";
			this.btnCCToggle001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCCToggle001.UseVisualStyleBackColor = true;
			this.btnCCToggle001.Click += new System.EventHandler(this.btnCCToggle_Click_Handler);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(214, 290);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 25);
			this.label5.TabIndex = 30;
			this.label5.Text = "Strategy";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtRows);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.cmboExpDateDefault);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtSymbolDefault);
			this.groupBox1.Controls.Add(this.btnCSPToggleDefault);
			this.groupBox1.Controls.Add(this.btnCCToggleDefault);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(15, 7);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(474, 211);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Defaults";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(16, 27);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(61, 25);
			this.label19.TabIndex = 21;
			this.label19.Text = "Rows";
			this.label19.Visible = false;
			// 
			// txtRows
			// 
			this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRows.Location = new System.Drawing.Point(22, 59);
			this.txtRows.Margin = new System.Windows.Forms.Padding(4);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(81, 29);
			this.txtRows.TabIndex = 0;
			this.txtRows.TabStop = false;
			this.txtRows.Text = "10";
			this.txtRows.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 99);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 25);
			this.label8.TabIndex = 19;
			this.label8.Text = "Strategy";
			// 
			// cmboExpDateDefault
			// 
			this.cmboExpDateDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmboExpDateDefault.FormattingEnabled = true;
			this.cmboExpDateDefault.ItemHeight = 24;
			this.cmboExpDateDefault.Location = new System.Drawing.Point(260, 48);
			this.cmboExpDateDefault.Margin = new System.Windows.Forms.Padding(4);
			this.cmboExpDateDefault.Name = "cmboExpDateDefault";
			this.cmboExpDateDefault.Size = new System.Drawing.Size(196, 32);
			this.cmboExpDateDefault.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(144, 18);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 25);
			this.label6.TabIndex = 18;
			this.label6.Text = "Symbol";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(255, 17);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(188, 30);
			this.label7.TabIndex = 17;
			this.label7.Text = "Expiration Date";
			// 
			// txtSymbolDefault
			// 
			this.txtSymbolDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSymbolDefault.Location = new System.Drawing.Point(150, 50);
			this.txtSymbolDefault.Margin = new System.Windows.Forms.Padding(4);
			this.txtSymbolDefault.Name = "txtSymbolDefault";
			this.txtSymbolDefault.Size = new System.Drawing.Size(81, 29);
			this.txtSymbolDefault.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label21);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(504, 16);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(1092, 242);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Definitions";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(11, 196);
			this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(781, 21);
			this.label21.TabIndex = 24;
			this.label21.Text = "Contract Price - The amount per contract per share, so normal pricing (i.e. $1 fo" +
    "r a call that costs $100)";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(11, 158);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(792, 21);
			this.label20.TabIndex = 23;
			this.label20.Text = "Save and View History - Not Yet Implemented. Will Save current screen so it can b" +
    "e viewed from history.";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(11, 124);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(891, 21);
			this.label18.TabIndex = 22;
			this.label18.Text = "Max Profit - Maximum Profit for the Trade. For CSP, will match Expected. For CC, " +
    "profit if stock is above call strike.\r\n";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(11, 84);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(931, 21);
			this.label12.TabIndex = 21;
			this.label12.Text = "Expected Profit - Profit if stock remains above strike price for Cash Secured Put" +
    ", or above purchase price for Covered Call";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(11, 45);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(487, 21);
			this.label9.TabIndex = 20;
			this.label9.Text = "Invested Amount - Dollar amount risked (invested) for the trade.";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(833, 264);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 55);
			this.label10.TabIndex = 30;
			this.label10.Text = "Invested Amount";
			// 
			// txtInvAmt001
			// 
			this.txtInvAmt001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtInvAmt001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInvAmt001.Location = new System.Drawing.Point(834, 331);
			this.txtInvAmt001.Margin = new System.Windows.Forms.Padding(4);
			this.txtInvAmt001.Name = "txtInvAmt001";
			this.txtInvAmt001.Size = new System.Drawing.Size(118, 33);
			this.txtInvAmt001.TabIndex = 9;
			this.txtInvAmt001.AutoSize = false;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(962, 265);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(155, 37);
			this.label11.TabIndex = 30;
			this.label11.Text = "Expected Profit";
			// 
			// txtExpProfitAmt001
			// 
			this.txtExpProfitAmt001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtExpProfitAmt001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExpProfitAmt001.Location = new System.Drawing.Point(966, 330);
			this.txtExpProfitAmt001.Margin = new System.Windows.Forms.Padding(4);
			this.txtExpProfitAmt001.Name = "txtExpProfitAmt001";
			this.txtExpProfitAmt001.Size = new System.Drawing.Size(128, 33);
			this.txtExpProfitAmt001.TabIndex = 10;
			this.txtExpProfitAmt001.AutoSize = false;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(962, 295);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 33);
			this.label13.TabIndex = 30;
			this.label13.Text = "Amount";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(1107, 296);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 33);
			this.label14.TabIndex = 30;
			this.label14.Text = "Percent";
			// 
			// txtExpProfitPerc001
			// 
			this.txtExpProfitPerc001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtExpProfitPerc001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExpProfitPerc001.Location = new System.Drawing.Point(1112, 330);
			this.txtExpProfitPerc001.Margin = new System.Windows.Forms.Padding(4);
			this.txtExpProfitPerc001.Name = "txtExpProfitPerc001";
			this.txtExpProfitPerc001.Size = new System.Drawing.Size(69, 33);
			this.txtExpProfitPerc001.TabIndex = 11;
			this.txtExpProfitPerc001.AutoSize = false;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(1431, 296);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(116, 33);
			this.label15.TabIndex = 29;
			this.label15.Text = "Percent";
			// 
			// txtMaxProfitPerc001
			// 
			this.txtMaxProfitPerc001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtMaxProfitPerc001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxProfitPerc001.Location = new System.Drawing.Point(1436, 330);
			this.txtMaxProfitPerc001.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaxProfitPerc001.Name = "txtMaxProfitPerc001";
			this.txtMaxProfitPerc001.Size = new System.Drawing.Size(82, 33);
			this.txtMaxProfitPerc001.TabIndex = 14;
			this.txtMaxProfitPerc001.AutoSize = false;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(1285, 295);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(116, 33);
			this.label16.TabIndex = 30;
			this.label16.Text = "Amount";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(1286, 266);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(115, 37);
			this.label17.TabIndex = 30;
			this.label17.Text = "Max Profit";
			// 
			// txtMaxProfitAmt001
			// 
			this.txtMaxProfitAmt001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtMaxProfitAmt001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxProfitAmt001.Location = new System.Drawing.Point(1287, 330);
			this.txtMaxProfitAmt001.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaxProfitAmt001.Name = "txtMaxProfitAmt001";
			this.txtMaxProfitAmt001.Size = new System.Drawing.Size(131, 33);
			this.txtMaxProfitAmt001.TabIndex = 13;
			this.txtMaxProfitAmt001.AutoSize = false;
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(19, 230);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(184, 43);
			this.btnSave.TabIndex = 31;
			this.btnSave.TabStop = false;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnHistory
			// 
			this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHistory.Location = new System.Drawing.Point(224, 230);
			this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(184, 43);
			this.btnHistory.TabIndex = 32;
			this.btnHistory.TabStop = false;
			this.btnHistory.Text = "View History";
			this.btnHistory.UseVisualStyleBackColor = true;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(724, 263);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(95, 57);
			this.label22.TabIndex = 34;
			this.label22.Text = "Contract Price";
			// 
			// txtContractPrice001
			// 
			this.txtContractPrice001.BackColor = System.Drawing.SystemColors.Info;
			this.txtContractPrice001.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContractPrice001.Location = new System.Drawing.Point(730, 329);
			this.txtContractPrice001.Margin = new System.Windows.Forms.Padding(4);
			this.txtContractPrice001.Name = "txtContractPrice001";
			this.txtContractPrice001.Size = new System.Drawing.Size(78, 33);
			this.txtContractPrice001.TabIndex = 8;
			this.txtContractPrice001.TextChanged += new System.EventHandler(this.handleTextBoxChanged);
			this.txtContractPrice001.AutoSize = false;
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(1193, 296);
			this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(84, 33);
			this.label23.TabIndex = 36;
			this.label23.Text = "APR";
			// 
			// txtExpProfitPercAPR001
			// 
			this.txtExpProfitPercAPR001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtExpProfitPercAPR001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExpProfitPercAPR001.Location = new System.Drawing.Point(1198, 330);
			this.txtExpProfitPercAPR001.Margin = new System.Windows.Forms.Padding(4);
			this.txtExpProfitPercAPR001.Name = "txtExpProfitPercAPR001";
			this.txtExpProfitPercAPR001.Size = new System.Drawing.Size(69, 33);
			this.txtExpProfitPercAPR001.TabIndex = 12;
			this.txtExpProfitPercAPR001.AutoSize = false;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(1526, 296);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(84, 33);
			this.label24.TabIndex = 38;
			this.label24.Text = "APR";
			// 
			// txtMaxProfitPercAPR001
			// 
			this.txtMaxProfitPercAPR001.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtMaxProfitPercAPR001.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaxProfitPercAPR001.Location = new System.Drawing.Point(1531, 330);
			this.txtMaxProfitPercAPR001.Margin = new System.Windows.Forms.Padding(4);
			this.txtMaxProfitPercAPR001.Name = "txtMaxProfitPercAPR001";
			this.txtMaxProfitPercAPR001.Size = new System.Drawing.Size(69, 33);
			this.txtMaxProfitPercAPR001.TabIndex = 15;
			this.txtMaxProfitPercAPR001.AutoSize = false;
			// 
			// ThetaReturnCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(1658, 655);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.txtMaxProfitPercAPR001);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.txtExpProfitPercAPR001);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.txtContractPrice001);
			this.Controls.Add(this.btnHistory);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtMaxProfitPerc001);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtMaxProfitAmt001);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtExpProfitPerc001);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtExpProfitAmt001);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtInvAmt001);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCCToggle001);
			this.Controls.Add(this.btnCSPToggle001);
			this.Controls.Add(this.lblSymbol001);
			this.Controls.Add(this.txtSymbol001);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtStrike001);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSharePrice001);
			this.Controls.Add(this.cmboExpDate001);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtQuantity001);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ThetaReturnCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.Text = "Wheel Return Calculator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox btnCSPToggleDefault;
		private System.Windows.Forms.CheckBox btnCCToggleDefault;
		private System.Windows.Forms.TextBox txtQuantity001;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmboExpDate001;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSharePrice001;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtStrike001;
		private System.Windows.Forms.Label lblSymbol001;
		private System.Windows.Forms.TextBox txtSymbol001;
		private System.Windows.Forms.CheckBox btnCSPToggle001;
		private System.Windows.Forms.CheckBox btnCCToggle001;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmboExpDateDefault;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSymbolDefault;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtInvAmt001;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtExpProfitAmt001;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtExpProfitPerc001;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMaxProfitPerc001;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtMaxProfitAmt001;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtRows;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnHistory;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtContractPrice001;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtExpProfitPercAPR001;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox txtMaxProfitPercAPR001;
	}
}

