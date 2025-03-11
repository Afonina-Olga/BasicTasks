Console.Write("Введите положительное целое число: ");
ulong number = Convert.ToByte(Console.ReadLine());
ulong factorial = 1;

for (ulong i = 1; i <= number; i++)
{
	factorial *= i;
	// factorial = factorial * i;
	Console.WriteLine($"i = {i}");
	Console.WriteLine($"factorial = {factorial}");
	Console.WriteLine("-----------------------------");
}

Console.WriteLine($"Факториал = {factorial}");
