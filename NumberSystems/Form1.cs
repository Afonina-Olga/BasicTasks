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

					Print(Converter.To((int)numDigit.Value, 2), 2);
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
						Print(Converter.From(txtDigit.Text, 8), 8);
						break;

					case 2:
						Print(Converter.FromHex(txtDigit.Text), 16);
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
