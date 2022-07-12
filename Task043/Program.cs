//программа, которая находит точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 

System.Console.WriteLine("Программа находит точку пересечения двух прямых");
System.Console.WriteLine("Введите значение уровнений.");
System.Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double y;
double x;

x = (b2 - b1) / (k1-k2);
y = k2 * x + b2;
System.Console.WriteLine(x);
System.Console.WriteLine(y);