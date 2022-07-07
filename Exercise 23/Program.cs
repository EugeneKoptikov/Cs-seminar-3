//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Программа выводит табличные данныые по числам возведенных в третью степень.");
Console.Write("Укажите интересуемое число, до которого вам нужно вывести значения таблицы: ");

int number = Convert.ToInt32(Console.ReadLine());
int tab;

// Решил использовать рукописный метод, хотя без него можно обойтись:
int Cube(int arg1, int arg2, int arg3)
{
	int result = arg1 * arg2 * arg3;
	return result;
}

for (int i = 1; i <= number; i++)
{
	tab = Cube(i, i, i);
	Console.WriteLine(i + "^3 = " + tab );
}
