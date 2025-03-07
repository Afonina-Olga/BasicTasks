using System.Text;

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

#region Начало

//var pinkiePie = 0;
//var rainbowDash = 0;
//var appleJack = 0;
//var rarity = 0;

/*
2)что вы из ниже перечисленного любите больше всего?
Спорт и активные игры(Радуга Деш)
Мода и вкус(Рарити)
Хозяйство и домашние дела (ЭплДжек)
Смех и веселье (Пинки Пай)
3)какой твой любимый персонаж?
Радуга
Рарити
ЭплДжек
Пинки Пай
4 Какой у тебя характер?
Веселый(Пинки Пай)
Стремящийся к лидерству (Радуга)
Щедрый (Рарити)
Заботливый (ЭплДжек)
5 что для вас самое важное
Труд- ЭплДжек
Забота-Радуга
Мода- Рарити
Другое-Пинки Пай
*/

//int input;
//do
//{
//	PrintQuestion("Какой твой любимый цвет?", "Розовый", "Синий", "Желтый", "Рарити");
//	Console.Write("Ваш ответ: ");
//	_ = int.TryParse(Console.ReadLine(), out input);
//} while (input < 1 || input > 4);

//_ = input switch
//{
//	1 => pinkiePie++,
//	2 => rainbowDash++,
//	3 => appleJack++,
//	4 => rarity++,
//	_ => throw new ArgumentException()
//};

//Console.WriteLine();

//do
//{
//	PrintQuestion("Вопрос 2", "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4");
//	Console.Write("Ваш ответ: ");
//	_ = int.TryParse(Console.ReadLine(), out input);
//} while (input < 1 || input > 4);

//_ = input switch
//{
//	1 => rarity++,
//	2 => rainbowDash++,
//	3 => appleJack++,
//	4 => pinkiePie++,
//	_ => throw new ArgumentException()
//};

//Console.WriteLine();

//do
//{
//	PrintQuestion("Вопрос 3", "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4");
//	Console.Write("Ваш ответ: ");
//	_ = int.TryParse(Console.ReadLine(), out input);
//} while (input < 1 || input > 4);

//_ = input switch
//{
//	1 => rarity++,
//	2 => rainbowDash++,
//	3 => appleJack++,
//	4 => pinkiePie++,
//	_ => throw new ArgumentException()
//};

//Console.WriteLine();

//do
//{
//	PrintQuestion("Вопрос 4", "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4");
//	Console.Write("Ваш ответ: ");
//	_ = int.TryParse(Console.ReadLine(), out input);
//} while (input < 1 || input > 4);

//_ = input switch
//{
//	1 => rarity++,
//	2 => rainbowDash++,
//	3 => appleJack++,
//	4 => pinkiePie++,
//	_ => throw new ArgumentException()
//};

//Console.WriteLine();

//do
//{
//	PrintQuestion("Вопрос 5", "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4");
//	Console.Write("Ваш ответ: ");
//	_ = int.TryParse(Console.ReadLine(), out input);
//} while (input < 1 || input > 4);

//_ = input switch
//{
//	1 => rarity++,
//	2 => rainbowDash++,
//	3 => appleJack++,
//	4 => pinkiePie++,
//	_ => throw new ArgumentException()
//};

//var max = Max(appleJack, rarity, pinkiePie, rainbowDash);
//PrintResult(max);

//void PrintQuestion(
//	string question, 
//	string answer1, 
//	string answer2, 
//	string answer3, 
//	string answer4)
//{
//	Console.WriteLine(question);
//	Console.WriteLine(answer1);
//	Console.WriteLine(answer2);
//	Console.WriteLine(answer3);
//	Console.WriteLine(answer4);
//}

//int Max(int a, int b, int c, int d)
//{
//	int max = a;

//	if (b > max)
//	{
//		max = b;
//	}
//	else if (c > max)
//	{
//		max = c;
//	}
//	else if (d > max)
//	{
//		max = d;
//	}

//	return max;
//}

//void PrintResult(int max)
//{
//	if (rainbowDash == max)
//	{
//		Console.WriteLine("Вы - Радуга Деш");
//	}

//	if (pinkiePie == max)
//	{
//		Console.WriteLine("Вы - Пинки Пай");
//	}

//	if (appleJack == max)
//	{
//		Console.WriteLine("Вы - Эпл Джек");
//	}

//	if (rainbowDash == max)
//	{
//		Console.WriteLine("Вы - Рарити");
//	}
//}

#endregion

#region Окончательный результат

var topics = new Topic[] {
	new("Вопрос 1", [
	new("Вариант 1", MyLittlePony.AppleJack),
	new("Вариант 2", MyLittlePony.Rarity),
	new("Вариант 3", MyLittlePony.PinkiePie),
	new("Вариант 4", MyLittlePony.RainbowDash)]),

	new("Вопрос 2", [
	new("Вариант 1", MyLittlePony.AppleJack),
	new("Вариант 2", MyLittlePony.Rarity),
	new("Вариант 3", MyLittlePony.PinkiePie),
	new("Вариант 4", MyLittlePony.RainbowDash)]),

	new("Вопрос 3", [
	new("Вариант 1", MyLittlePony.AppleJack),
	new("Вариант 2", MyLittlePony.Rarity),
	new("Вариант 3", MyLittlePony.PinkiePie),
	new("Вариант 4", MyLittlePony.RainbowDash)]),

	new("Вопрос 4", [
	new("Вариант 1", MyLittlePony.AppleJack),
	new("Вариант 2", MyLittlePony.Rarity),
	new("Вариант 3", MyLittlePony.PinkiePie),
	new("Вариант 4", MyLittlePony.RainbowDash)]),

	new("Вопрос 5", [
	new("Вариант 1", MyLittlePony.AppleJack),
	new("Вариант 2", MyLittlePony.Rarity),
	new("Вариант 3", MyLittlePony.PinkiePie),
	new("Вариант 4", MyLittlePony.RainbowDash)]),
};

foreach (var topic in topics)
{
	byte answer;

	do
	{
		Console.WriteLine();
		Console.WriteLine(topic.ToString());
		Console.Write("Ваш ответ: ");
		_ = byte.TryParse(Console.ReadLine(), out answer);
	} while (answer < 1 || answer > 4);

	var res = topic.Answers[answer - 1];
	Result.Answer(res.Result);
}

Console.WriteLine(Result.GetResult());

class Topic(string question, Item[] answers)
{
	public string Question { get; set; } = question;
	public Item[] Answers { get; set; } = answers;

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append(Question);
		sb.Append(Environment.NewLine);

		for (int i = 0; i < Answers.Length; i++)
		{
			sb.Append($"{i + 1}. ");
			sb.Append(Answers[i].Option);
			sb.Append(Environment.NewLine);
		}

		return sb.ToString();
	}
}

class Item(string option, MyLittlePony result)
{
	public MyLittlePony Result { get; set; } = result;
	public string Option { get; set; } = option;
}

static class Result
{
	class Item(MyLittlePony name, byte value)
	{
		public MyLittlePony Name { get; set; } = name;
		public byte Value { get; set; } = value;
	}

	public static byte PinkiePie { get; set; } = 0;
	public static byte RainbowDash { get; set; } = 0;
	public static byte AppleJack { get; set; } = 0;
	public static byte Rarity { get; set; } = 0;

	// Напечатать результат
	public static string GetResult()
	{
		var tmp = new Item[]
		{
			new (MyLittlePony.PinkiePie, PinkiePie),
			new (MyLittlePony.Rarity, Rarity),
			new (MyLittlePony.AppleJack, AppleJack),
			new (MyLittlePony.RainbowDash, RainbowDash),
		};

		var sorted = tmp.OrderByDescending(x => x.Value).ToArray();

		var sb = new StringBuilder();

		sb.Append("Результат теста: ");
		sb.Append(Environment.NewLine);

		foreach (var s in sorted)
		{
			sb.Append($"{s.Name} - {s.Value}");
			sb.Append(Environment.NewLine);
		}

		sb.Append(Environment.NewLine);

		var maxValue = sorted[0].Value;
		var result = sorted.Where(x => x.Value == maxValue);

		sb.Append("Из мира My Little Pony Вы: ");
		sb.Append(string.Join(", ", result.Select(x => x.Name)));

		return sb.ToString();
	}

	// Ответить на вопрос
	public static void Answer(MyLittlePony answer) => _ = answer switch
	{
		MyLittlePony.PinkiePie => PinkiePie++,
		MyLittlePony.RainbowDash => RainbowDash++,
		MyLittlePony.AppleJack => AppleJack++,
		MyLittlePony.Rarity => Rarity++,
		_ => throw new ArgumentException()
	};
}

enum MyLittlePony
{
	PinkiePie,
	RainbowDash,
	AppleJack,
	Rarity
}

#endregion