Console.WriteLine(IsPalindrome("1234"));
Console.WriteLine(IsPalindrome("12345"));
Console.WriteLine(IsPalindrome("1221"));
Console.WriteLine(IsPalindrome("12321"));

static bool IsPalindrome(string value)
{
	for (int i = 0; i < value.Length / 2; i++) // Если не делить на 2, то ошибки не будет, но будут лишние действия
	{
		if (value[i] != value[value.Length - i - 1]) 
		{
			return false;
		}
	}
	return true;
}
