// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumbers(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetPoint(double b1, double b2, double k1, double k2)
{
    double x = (b2-b1)/(k1-k2); 
    double y = k2*x+b2;
    System.Console.WriteLine($"Кординаты точек пересечения: [{x};{y}]");
}

double b1 = GetNumbers("Введите число B1");
double b2 = GetNumbers("Введите число B2");
double k1 = GetNumbers("Введите число K1");
double k2 = GetNumbers("Введите число K2");

GetPoint(b1,b2,k1,k2);