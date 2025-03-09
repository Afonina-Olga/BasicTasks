// Наименьшее общее кратное двух целых чисел m и n есть наименьшее натуральное число, которое
// делится на m и n без остатка

Console.Write("Введите первое число: ");
var number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
var number2 = int.Parse(Console.ReadLine());

var lcm = (number1 > number2) ? number1 : number2;

while (true)
{
	if (lcm % number1 == 0 && lcm % number2 == 0)
	{
		Console.WriteLine($"НОК = {lcm}");
		break; // Обязательно должно быть условие выхода из цикла
	}

	lcm++;
}

Console.WriteLine($"НОК = {lcm}");

// Второй вариант НОК = (number1 * number2) / НОД
int gcd = 0;

for (int i = 1; i < Math.Max(number1, number2); i++)
{
	if (number1 % i == 0 && number2 % i == 0)
	{
		gcd = i;
	}
}

// НОК (16,36) =144
Console.WriteLine("НОК = " + (number2 * number1) / gcd);
