Console.Write("Введите а: ");
var a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b: ");
var b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите c: ");
var c = Convert.ToDouble(Console.ReadLine());

var discriminant = Math.Pow(b, 2) - 4 * a * c;

if (discriminant < 0)
{
	Console.WriteLine("Дискриминант меньше нуля");
}

if (discriminant > 0)
{
	var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
	var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

	Console.WriteLine($"x1 = {x1}");
	Console.WriteLine($"x2 = {x2}");
}
else if (discriminant == 0)
{
	var x = (-b + Math.Sqrt(discriminant)) / (2 * a);
	Console.WriteLine($"x = {x}");
}
else
{
	var real = -b / (2 * a);
	var imaginary = Math.Sqrt(-discriminant) / (2 * a);
	Console.WriteLine($"x1 = {real}+{imaginary:N2}i");
	Console.WriteLine($"x2 = {real}-{imaginary:N2}i");
}
