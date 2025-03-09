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
Console.WriteLine($"Обратное число = {Reverse(number.ToString())}");

// Способ с массивами показать
string Reverse(string value)
{
	var array = "1234".ToCharArray();
	for (int i = 0; i < array.Length / 2; i++)
	{
		char temp = array[i];
		array[i] = array[array.Length - i - 1];
		array[array.Length - i - 1] = temp;
	}
	return new(array); // или array.ToString();
}


