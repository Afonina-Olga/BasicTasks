Console.Write("Введите максимальное число: "); // До которого выводить
var number = int.Parse(Console.ReadLine()!);
if (number < 0)
{
	Console.WriteLine("Число должно быть положительным");
	return;
}

for (int i = 1; i <= number; i++) // До number включительно
{
	if (i % 2 == 0)
	{
		continue;
	}

	Console.WriteLine(i);
}

