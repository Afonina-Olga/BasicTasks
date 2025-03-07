Console.Write("Введите первое число: ");
if (int.TryParse(Console.ReadLine(), out var a) is false)
{
	Console.WriteLine("Некорректный ввод");
}

Console.Write("Введите второе число: ");
if (int.TryParse(Console.ReadLine(), out var b) is false)
{
	Console.WriteLine("Некорректный ввод");
}

Console.Write("Введите третье число: ");
if (int.TryParse(Console.ReadLine(), out var c) is false)
{
	Console.WriteLine("Некорректный ввод");
}

#region Очевидный способ

var max = 0;

if (a >= b && a >= c)
{
	max = a;
}
else if (b >= a && b >= c)
{
	max = b;
}
else if (c >= a && c >= b)
{
	max = c;
}

Console.WriteLine($"Max = {max}");

#endregion

#region Еще один способ

max = a;

if (b >= max)
{
	max = b;
}
// Почему нельзя else объяснить
if (c >= max)
{
	max = c;
}

Console.WriteLine($"Max = {max}");

#endregion

#region Ну тогда уж и еще один способ

max = int.MinValue;

if (a >= max)
{
	max = a;
}

if (b >= max)
{
	max = b;
}

if (c >= max)
{
	max = c;
}

Console.WriteLine($"Max = {max}");

#endregion