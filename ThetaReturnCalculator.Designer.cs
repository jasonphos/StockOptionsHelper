
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
			this.btnCSPToggle = new System.Windows.Forms.CheckBox();
			this.btnCCToggle = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCSPToggle
			// 
			this.btnCSPToggle.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCSPToggle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCSPToggle.Location = new System.Drawing.Point(12, 12);
			this.btnCSPToggle.Name = "btnCSPToggle";
			this.btnCSPToggle.Size = new System.Drawing.Size(171, 51);
			this.btnCSPToggle.TabIndex = 0;
			this.btnCSPToggle.Text = "Cash Secured Put";
			this.btnCSPToggle.UseVisualStyleBackColor = true;
			// 
			// btnCCToggle
			// 
			this.btnCCToggle.Appearance = System.Windows.Forms.Appearance.Button;
			this.btnCCToggle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCCToggle.Location = new System.Drawing.Point(209, 12);
			this.btnCCToggle.Name = "btnCCToggle";
			this.btnCCToggle.Size = new System.Drawing.Size(174, 51);
			this.btnCCToggle.TabIndex = 1;
			this.btnCCToggle.Text = "Covered Call";
			this.btnCCToggle.UseVisualStyleBackColor = true;
			this.btnCCToggle.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(138, 209);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(56, 29);
			this.textBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(134, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Quantity";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Expiration Date";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 122);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(164, 32);
			this.comboBox1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 21);
			this.label3.TabIndex = 8;
			this.label3.Text = "Share Price";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(12, 209);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 29);
			this.textBox2.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(225, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 21);
			this.label4.TabIndex = 10;
			this.label4.Text = "Strike";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(229, 209);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(56, 29);
			this.textBox3.TabIndex = 9;
			// 
			// ThetaReturnCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 438);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnCCToggle);
			this.Controls.Add(this.btnCSPToggle);
			this.Name = "ThetaReturnCalculator";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox btnCSPToggle;
		private System.Windows.Forms.CheckBox btnCCToggle;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
	}
}

