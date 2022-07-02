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
    /* Тут я сам не понимаю! Из-за того, что компилятор пишет, что есть риск обращения "number[0]" в NULL, данная программа не может работать с вводом 4-хзначных чисел.
       Но, при вводе 6-тизначного числа и более, проходит проверку и выводит нужную мне надпись "Ошибка ввода! Введенное число не пятизначное!" */
}
