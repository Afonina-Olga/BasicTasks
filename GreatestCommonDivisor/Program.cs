// Максимальное число, на которое могут быть без остатка разделены оба числа
// Наибольший общий делитель

Console.Write("Введите первое число: ");
var number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
var number2 = int.Parse(Console.ReadLine()!);

int gcd = 0;

for (int i = 1; i < Math.Max(number1, number2); i++)
{
	if (number1 % i == 0 && number2 % i == 0)
	{
		gcd = i;
	}
}

Console.WriteLine($"Наибольший общий делитель: {gcd}");