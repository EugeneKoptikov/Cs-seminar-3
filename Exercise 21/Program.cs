// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Программа поиска растояния между двумя точками в трехмерном пространстве.");
Console.WriteLine("Введите координаты первой точки.");

// Координаты первой точки.
Console.Write("Введите значение х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите значение y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите значение z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

Console.WriteLine("Введите координаты второй точки.");

// Координаты второй точки.
Console.Write("Введите значение х2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите значение y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Введите значение z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(" ");

// Рукописный метод, описывающий формулу для нахождения расстояния между двумя точками.
double Distance(double arg1, double arg2, double arg3, double arg4, double arg5, double arg6)
{
	double result = Math.Sqrt(((arg4 - arg1) * (arg4 - arg1)) + ((arg5 - arg2) * (arg5 - arg2)) + ((arg6 - arg3) * (arg6 - arg3)));

    if (result < 0)
    {
        result *= -1;
    }

	return result;
}

double dis = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine("Расстояние между точками " + dis);