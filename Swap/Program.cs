using System.Runtime.Intrinsics.X86;

Console.Write("Введите первое число: ");
var first = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
var second = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"До замены первое число = {first}, второе число = {second}");

var tmp = first;
first = second;
second = tmp;

Console.WriteLine($"После замены первое число = {first}, второе число = {second}");

Console.WriteLine("Способ без дополнительной переменной");

first += second;
second = first - second;
first -= second;

Console.WriteLine($"После замены первое число = {first}, второе число = {second}");
