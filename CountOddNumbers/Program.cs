Console.Write("Введите максимальное число: "); // До которого выводить
var input = Console.ReadLine();

if (string.IsNullOrEmpty(input)) // Проверка строки на null и ""
{
	Console.WriteLine("Некорректный ввод");
	return;
}

var parseResult = int.TryParse(input, out var number);
if (parseResult is false)
{
	Console.WriteLine("Некорректный ввод числа");
	return;
}

if (number < 2)
{
	Console.WriteLine("Число должно быть больше 2");
	return;
}

// Нечетные
for (int i = 1; i <= number; i++) // До number включительно
{
	if (i % 2 == 0)
	{
		continue;
	}

	Console.WriteLine(i);
}
