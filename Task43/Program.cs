// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения для первой прямой:");
Console.Write("Первая точка: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения для второй прямой:");
Console.Write("Первая точка: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка: ");
double k2 = Convert.ToInt32(Console.ReadLine());

string CrossPoint (double bn1, double kn1, double bn2,double kn2)
{
    double xn = (bn2 - bn1) / (kn1 - kn2);
    double yn = kn1* xn + bn1;
    return ($"Точка пересечения двух прямых: ({xn} : {yn})");  
}

string res = CrossPoint(b1,k1,b2,k2);
Console.WriteLine(res);


