namespace NumberSystems
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			numDigit = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			cbSystem = new ComboBox();
			btnCalculate = new Button();
			richTextBox1 = new RichTextBox();
			label3 = new Label();
			txtDigit = new TextBox();
			btnConvert = new Button();
			label4 = new Label();
			cbBase = new ComboBox();
			((System.ComponentModel.ISupportInitialize)numDigit).BeginInit();
			SuspendLayout();
			// 
			// numDigit
			// 
			numDigit.Location = new Point(137, 13);
			numDigit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numDigit.Name = "numDigit";
			numDigit.Size = new Size(194, 27);
			numDigit.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 15);
			label1.Name = "label1";
			label1.Size = new Size(52, 20);
			label1.TabIndex = 1;
			label1.Text = "Число";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 49);
			label2.Name = "label2";
			label2.Size = new Size(67, 20);
			label2.TabIndex = 2;
			label2.Text = "Система";
			// 
			// cbSystem
			// 
			cbSystem.FormattingEnabled = true;
			cbSystem.Items.AddRange(new object[] { "Двоичная", "Восьмеричная", "Шестнадцатиричная" });
			cbSystem.Location = new Point(136, 46);
			cbSystem.Name = "cbSystem";
			cbSystem.Size = new Size(195, 28);
			cbSystem.TabIndex = 3;
			// 
			// btnCalculate
			// 
			btnCalculate.Location = new Point(136, 80);
			btnCalculate.Name = "btnCalculate";
			btnCalculate.Size = new Size(195, 29);
			btnCalculate.TabIndex = 4;
			btnCalculate.Text = "Перевести";
			btnCalculate.UseVisualStyleBackColor = true;
			btnCalculate.Click += BtnCalculate_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new Point(344, 12);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new Size(271, 215);
			richTextBox1.TabIndex = 5;
			richTextBox1.Text = "";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(18, 133);
			label3.Name = "label3";
			label3.Size = new Size(52, 20);
			label3.TabIndex = 1;
			label3.Text = "Число";
			// 
			// txtDigit
			// 
			txtDigit.Location = new Point(137, 130);
			txtDigit.Name = "txtDigit";
			txtDigit.Size = new Size(194, 27);
			txtDigit.TabIndex = 6;
			// 
			// btnConvert
			// 
			btnConvert.Location = new Point(137, 198);
			btnConvert.Name = "btnConvert";
			btnConvert.Size = new Size(195, 29);
			btnConvert.TabIndex = 4;
			btnConvert.Text = "Перевести";
			btnConvert.UseVisualStyleBackColor = true;
			btnConvert.Click += BtnConvert_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(18, 167);
			label4.Name = "label4";
			label4.Size = new Size(87, 20);
			label4.TabIndex = 7;
			label4.Text = "Основание";
			// 
			// cbBase
			// 
			cbBase.FormattingEnabled = true;
			cbBase.Items.AddRange(new object[] { "2", "8", "16" });
			cbBase.Location = new Point(137, 164);
			cbBase.Name = "cbBase";
			cbBase.Size = new Size(194, 28);
			cbBase.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(631, 245);
			Controls.Add(cbBase);
			Controls.Add(label4);
			Controls.Add(txtDigit);
			Controls.Add(richTextBox1);
			Controls.Add(btnConvert);
			Controls.Add(btnCalculate);
			Controls.Add(cbSystem);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(numDigit);
			Name = "Form1";
			Text = "Системы счисления";
			((System.ComponentModel.ISupportInitialize)numDigit).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numDigit;
		private Label label1;
		private Label label2;
		private ComboBox cbSystem;
		private Button btnCalculate;
		private RichTextBox richTextBox1;
		private Label label3;
		private TextBox txtDigit;
		private Button btnConvert;
		private Label label4;
		private ComboBox cbBase;
	}
}
