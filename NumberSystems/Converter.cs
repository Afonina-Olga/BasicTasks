namespace NumberSystems
{
	public static class Converter
	{
		// https://ci-sharp.ru/algoritmy-i-struktury-dannyh/sistemy-schisleniya/perevod-iz-desiatichnoi-sistemy-schisleniia-v-troichnuiu-v-c/
		// https://ci-sharp.ru/algoritmy-i-struktury-dannyh/sistemy-schisleniya/perevod-iz-desiatichnoi-sistemy-schisleniia-v-dvoichnuiu-v-c/
		// https://vscode.ru/articles/dvoichnaya-sistema-schisleniya.html
		// Из десятичной системы в двоичную

		// 1. Делите десятичное число на 2.
		// 2. Записывайте остаток от деления(0 или 1) — это будет очередной бит двоичного числа.
		// 3. Обновите десятичное число, присвоив ему значение частного от предыдущего деления.
		// 4. Повторяйте шаги 1-3, пока десятичное число не станет равно 0.
		// 5. Двоичное число — это записанные остатки в обратном порядке.
		public static string ToBinary(int number)
		{
			if (number == 0)
			{
				return "0";
			}

			var result = "";

			while (number > 0)
			{
				int remainder = number % 2;
				result = remainder + result;
				number /= 2;
			}

			return result;
		}

		public static string To(int number, int @base)
		{
			if (number == 0)
			{
				return "0";
			}

			var result = "";

			while (number > 0)
			{
				int remainder = number % @base;
				result = remainder + result;
				number /= @base;
			}

			return result;
		}

		// Перевод числа из двоичной в десятичную систему счисления осуществляется путем сложения
		// произведений каждой цифры числа на 2, возведенную в степень, соответствующую позиции
		// этой цифры.Например, двоичное число 1101 будет преобразовано в десятичное следующим
		// образом: 1*2^3 + 1*2^2 + 0*2^1 + 1*2^0 = 8 + 4 + 0 + 1 = 13.
		public static int From(string number, int fromBase)
		{
			switch (fromBase)
			{
				case 2:
					if (IsCorrectDigit(number, '0', '1') is false)
					{
						throw new FormatException("Неверный формат двоичного числа");
					}
					break;
			}

			var result = 0;

			for (int i = 0; i < number.Length; i++)
			{
				var current = int.Parse(number[number.Length - i - 1].ToString());

				if (current != '0')
				{
					result += current * (int)Math.Pow(fromBase, i);
				}
			}

			return result;
		}

		public static int FromHex(string number)
		{
			number = number.ToLower();

			if (IsCorrectDigit(number, '0', 'f') is false)
			{
				throw new FormatException("Неверный формат шестнадцатеричного числа");
			}

			var result = 0;

			for (int i = 0; i < number.Length; i++)
			{
				var current = number[number.Length - i - 1];
				int value;

				if (current >= 'a' && current <= 'f')
				{
					value = current switch
					{
						'a' => 10,
						'b' => 11,
						'c' => 12,
						'd' => 13,
						'e' => 14,
						'f' => 15,
						_ => throw new NotImplementedException(),
					};
				}
				else
				{
					value = int.Parse(current.ToString());
				}

				if (current != '0')
				{
					result += value * (int)Math.Pow(16, i);
				}
			}

			return result;
		}

		// 1. Делим десятичное число на 16 и записываем остаток от деления.
		// 2. Результат деления вновь делим на 16 и опять записываем остаток.
		// 3. Повторяем операцию до тех пор пока результат деления не будет равен нулю.
		// 4. Запишем полученные остатки в обратном порядке и получим искомое число.
		public static string ToHex(int number)
		{
			if (number == 0)
			{
				return "0";
			}

			var result = "";

			while (number > 0)
			{
				int remainder = number % 16;
				// Записываем
				var value = remainder.ToString();

				if (remainder >= 10)
				{
					value = remainder switch
					{
						10 => "A",
						11 => "B",
						12 => "C",
						13 => "D",
						14 => "E",
						15 => "F",
						_ => throw new NotImplementedException()
					};
				}

				result = value + result;
				number /= 16;
			}

			return result;
		}

		private static bool IsCorrectDigit(string digit, char start, char end)
		{
			var count = 0;
			for (int i = 0; i < digit.Length; i++)
			{
				if (digit[i] >= start || digit[i] <= end)
				{
					count++;
				}
			}

			return count == digit.Length;
		}
	}
}
