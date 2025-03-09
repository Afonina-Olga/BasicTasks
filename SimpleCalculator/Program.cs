// Простой калькулятор с case

Console.Write("Введите первое число: ");
var number1 = double.Parse(Console.ReadLine());

Console.Write("Введите операцию (+, -, /, *) ");
var operation = Console.ReadLine();

Console.Write("Введите второе число: ");
var number2 = double.Parse(Console.ReadLine());

switch (operation)
{
	case "+":
		break;

	default:
		Console.WriteLine("Такая операция не реализована");
		break;
}