using System.Numerics;

namespace NumberSystems
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cbSystem.SelectedIndex = 0;
			cbBase.SelectedIndex = 0;
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			switch (cbSystem.SelectedIndex)
			{
				case 0:

					Print(Converter.ToBinary((int)numDigit.Value), 2);
					break;

				case 1:
					Print(Converter.To((int)numDigit.Value, 8), 8);
					break;

				case 2:
					Print(Converter.ToHex((int)numDigit.Value), 16);
					break;
			}
		}

		private void BtnConvert_Click(object sender, EventArgs e)
		{
			try
			{
				switch (cbBase.SelectedIndex)
				{
					case 0:
						Print(Converter.From(txtDigit.Text, 2), 2);
						break;

					case 1:
						Print(Converter.From(txtDigit.Text, 3), 3);
						break;

					case 2:
						Print(Converter.From(txtDigit.Text, 4), 4);
						break;

					case 3:
						Print(Converter.From(txtDigit.Text, 5), 5);
						break;

					case 4:
						Print(Converter.From(txtDigit.Text, 6), 6);
						break;

					case 5:
						Print(Converter.From(txtDigit.Text, 7), 7);
						break;

					case 6:
						Print(Converter.From(txtDigit.Text, 8), 8);
						break;

					case 7:
						Print(Converter.From(txtDigit.Text, 9), 9);
						break;
				}
			}
			catch(Exception ex)
			{
				richTextBox1.Text += $"Ошибка: {ex.Message}\n";
			}
		}

		private void Print(string value, int toBase)
		{
			richTextBox1.Text += $"Результат: {numDigit.Value} -> {value}\n";
			richTextBox1.Text += $"Должно получиться: {Convert.ToString((int)numDigit.Value, toBase)}\n";
		}

		private void Print(int value, int fromBase)
		{
			richTextBox1.Text += $"Результат: {txtDigit.Text} -> {value}\n";
			richTextBox1.Text += $"Должно получиться: {Convert.ToInt32(txtDigit.Text, fromBase)}\n";
		}
	}
}
