Console.Write("Введите положительное целое число: ");
ulong number = Convert.ToUInt64(Console.ReadLine());
ulong factorial = 1;

for (ulong i = 1; i <= number; i++)
{
	factorial *= i;
}

Console.WriteLine($"Факториал = {factorial}");
