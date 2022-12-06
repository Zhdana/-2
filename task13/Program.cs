Console.WriteLine("Введите число:");
string stringnumber = Console.ReadLine();

if (stringnumber.Length <3)
Console.WriteLine("третьей цифры нет!");
else
Console.WriteLine("третья цифра: " + stringnumber[2]);
