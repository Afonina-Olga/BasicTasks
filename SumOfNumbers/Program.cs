Console.Write("Введите положительное целое число: ");
var number = int.Parse(Console.ReadLine()!);

if (number <= 0)
{
	Console.WriteLine("Ну положительное же число!");
	return;
}

var sum = 0;

#region for

for (int i = 0; i <= number; i++)
{
	sum += i;
}

Console.WriteLine($"Сумма = {sum}");

#endregion


#region While

// Удобно использовать, если мы не знаем точно количество итераций

sum = 0;
var j = 0;

while (j <= number)
{
	sum += j;
	j++;
}

Console.WriteLine($"Сумма = {sum}");

#endregion