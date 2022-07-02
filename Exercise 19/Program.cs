// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Программа определяет является ли введенное пятизначное число палиндромом");
Console.Write("Впишите ваше пятизначное число: ");

string number = Console.ReadLine();

char firstChar = number[0];
char secondChar = number[1];
char forthChar = number[3];
char fifthChar = number[4];

if (number.Length == 5)
{
	if (firstChar == fifthChar && secondChar == forthChar) 
	{
		Console.WriteLine("Введенное число " + number + " является палиндромом!");
	}
	else
	{
		Console.WriteLine("Введенное число " + number + " не является палиндромом!");
	}
}
if (number.Length <= 4 || number.Length >= 6)
{
	Console.WriteLine("Ошибка ввода! Введенное число не пятизначное!");
}
