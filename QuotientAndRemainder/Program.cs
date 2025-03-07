Console.Write("Введите делимое: ");
var divident = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите делитель: ");
var divisor = Convert.ToDouble(Console.ReadLine());
var quotient = divident / divisor;
var remainder = divident % divisor;
Console.WriteLine($"Частное {quotient} Остаток {remainder}");
