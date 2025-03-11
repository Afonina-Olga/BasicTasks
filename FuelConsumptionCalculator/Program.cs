Console.WriteLine("Простой калькулятор расхода топлива");

Console.Write("Введите расстояние (км):");
var distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Потрачено топлива (л):");
var vol = Convert.ToDouble(Console.ReadLine());

var cons = (100 * vol) / distance;

Console.WriteLine($"Автомобиль прошел {distance} км, потратил {vol} литров топлива. Средний расход - {cons:N2} л / 100 км");

// TODO Показать if