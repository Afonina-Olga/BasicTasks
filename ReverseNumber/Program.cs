Console.Write("Введите целое число: ");
var number = long.Parse(Console.ReadLine());

// 1. Вычислить остаток от деления на 10
// 2. Постепенно формируем обратное число - постепенно умножаем его на 10 и
// добавляем остаток от предыдущей операции деления

var result = 0L;

while (number != 0)
{
	var remainder = number % 10;
	result = result * 10 + remainder;
	number /= 10;
}

Console.WriteLine($"Обратное число = {result}");

// Способ с массивами показать
