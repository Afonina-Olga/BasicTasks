var pinkiePie = 0;
var rainbowDash = 0;
var appleJack = 0;
var rarity = 0;

Console.WriteLine("*****************************");
Console.WriteLine("Введите число от 1 до 4");
Console.WriteLine("*****************************");
Console.WriteLine("1. Какой твой любимый цвет?");
Console.WriteLine("*****************************");
Console.WriteLine("1. Розовый");
Console.WriteLine("2. Синий");
Console.WriteLine("3. Желтый");
Console.WriteLine("4. Фиолетовый");

Console.Write("Ваш ответ: ");
var input = Console.ReadLine();

switch (input)
{
	case "1":
		pinkiePie++;
		break;

	case "2":
		rainbowDash++;
		break;

	case "3":
		appleJack++;
		break;

	case "4":
		rarity++;
		break;
}

Console.WriteLine("*****************************");
Console.WriteLine("2. Что вы из ниже перечисленного любите больше всего?");
Console.WriteLine("*****************************");
Console.WriteLine("1. Спорт и активные игры");
Console.WriteLine("2. Мода и вкус");
Console.WriteLine("3. Хозяйство и домашние дела");
Console.WriteLine("4. Смех и веселье");

Console.Write("Ваш ответ: ");
input = Console.ReadLine();

switch (input)
{
	case "1":
		rainbowDash++;
		break;

	case "2":
		rarity++;
		break;

	case "3":
		appleJack++;
		break;

	case "4":
		pinkiePie++;
		break;
}

Console.WriteLine("*****************************");
Console.WriteLine("3. Какой твой любимый персонаж?");
Console.WriteLine("*****************************");
Console.WriteLine("1. Радуга");
Console.WriteLine("2. Рарити");
Console.WriteLine("3. Эпл Джек");
Console.WriteLine("4. Пинки Пай");

Console.Write("Ваш ответ: ");
input = Console.ReadLine();

switch (input)
{
	case "1":
		rainbowDash++;
		break;

	case "2":
		rarity++;
		break;

	case "3":
		appleJack++;
		break;

	case "4":
		pinkiePie++;
		break;
}

Console.WriteLine("*****************************");
Console.WriteLine("4. Какой у тебя характер?");
Console.WriteLine("*****************************");
Console.WriteLine("1. Веселый");
Console.WriteLine("2. Стремящийся к лидерству");
Console.WriteLine("3. Щедрый");
Console.WriteLine("4. Заботливый");

Console.Write("Ваш ответ: ");
input = Console.ReadLine();

switch (input)
{
	case "1":
		pinkiePie++;
		break;

	case "2":
		rainbowDash++;
		break;

	case "3":
		rarity++;
		break;

	case "4":
		appleJack++;
		break;
}

Console.WriteLine("*****************************");
Console.WriteLine("5. Что для вас самое важное");
Console.WriteLine("*****************************");
Console.WriteLine("1. Труд");
Console.WriteLine("2. Забота");
Console.WriteLine("3. Мода");
Console.WriteLine("4. Другое");

Console.Write("Ваш ответ: ");
input = Console.ReadLine();

var max = Max(appleJack, rarity, pinkiePie, rainbowDash);
PrintResult(max);

switch (input)
{
	case "1":
		appleJack++;
		break;

	case "2":
		rainbowDash++;
		break;

	case "3":
		rarity++;
		break;

	case "4":
		appleJack++;
		break;
}

int Max(int a, int b, int c, int d)
{
	int max = a;

	if (b > max)
	{
		max = b;
	}
	else if (c > max)
	{
		max = c;
	}
	else if (d > max)
	{
		max = d;
	}

	return max;
}

void PrintResult(int max)
{
	if (rainbowDash == max)
	{
		Console.WriteLine("Вы - Радуга Деш");
	}

	if (pinkiePie == max)
	{
		Console.WriteLine("Вы - Пинки Пай");
	}

	if (appleJack == max)
	{
		Console.WriteLine("Вы - Эпл Джек");
	}

	if (rainbowDash == max)
	{
		Console.WriteLine("Вы - Рарити");
	}
}
