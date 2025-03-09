// Простое число делится только на 1 и на себя

Console.Write("Введите целое положительное число");
var n = int.Parse(Console.ReadLine());

bool IsPrime(int value)
{
	for (int i = 2; i <= value / 2; i++)
	{
		if (value % i == 0)
		{
			return false;
		}
	}
	return true;
}

// Показать как без метода
// Насколько метод удобнее

var isPrime = true;
for (int i = 2; i <= n / 2; i++)
{
	if (n % i == 0)
	{
		isPrime = false;
		break;
	}
}
