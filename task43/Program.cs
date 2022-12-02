/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double InputUserData(string userMessage)
{
    Console.WriteLine(userMessage);
    double userData = Convert.ToDouble(Console.ReadLine());
    return userData;
}

double k1 = InputUserData("Введите значение k1 первого уравнения");
double b1 = InputUserData("Введите значение b1 первого уравнения");
double k2 = InputUserData("Введите значение k2 второго уравнения");
double b2 = InputUserData("Введите значение b2 второго уравнения");

double IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
    return x;
}

double result = IntersectionPoint(b1, k1, b2, k2);