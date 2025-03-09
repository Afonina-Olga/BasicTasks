// Подсчет цифр в числе

// Можно сделать совсем просто, но наша цель изучать алгоритмы
Console.Write("Введите целое число: ");
var input = Console.ReadLine();

var number = long.Parse(input);

var count = 0;

while (number != 0)
{
	number /= 10;
	count++;
}

Console.WriteLine($"Количество цифр = {count}");

// Вариант совсем простой
Console.WriteLine($"Количество цифр = {input.Length}");