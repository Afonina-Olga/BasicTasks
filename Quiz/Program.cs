// https://kupidonia.ru/viktoriny/viktorina-geroi-multfilmov
var result = 0;
var count = 2;

Console.WriteLine(new string('-', 60)); // строчка из 60 тире
Console.WriteLine("1. Какой герой мультфильма испугался Того-кто-сидит-в-пруду?");
Console.WriteLine("1. Крошка енот");
Console.WriteLine("2. Котенок Гав");
Console.WriteLine("3. Голубой щенок");
Console.WriteLine();
Console.Write("Ваш ответ: ");

var answer1 = Console.ReadLine();
if (answer1 == "1")
{
	result++;
}

Console.WriteLine();

Console.WriteLine(new string('-', 60));
Console.WriteLine("2. Какой герой мультфильма назвал себя «лучшим в мире привидением с мотором»?");
Console.WriteLine("1. Крокодил Гена");
Console.WriteLine("2. Кентервильское привидение");
Console.WriteLine("3. Карлсон");
Console.WriteLine();
Console.Write("Ваш ответ:");

var answer2 = Console.ReadLine();
if (answer2 == "3")
{
	result++;
}

// TODO

Console.WriteLine($"Вы ответили верно на {result} вопросов из {count}");

