using System;
// 5.	Создайте делегат для нахождения корней квадратных уравнений. Делегат принимает 3 числа ,
// но ничего не возвращает. Добавьте так же к этому делегату еще метод,
// который находит площадь треугольника по формуле Герона. 
namespace DelegationHomeWorks_5
{
    internal class Program
    {
        public delegate void NumbersFoArea(int a, int b, int c); // void

        public static void AreaOfATriangle(int a, int b, int c) // void
        {
            double p = (a + b + c) / 2.0;
     
            double areaTriangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Площадь треугольника : { areaTriangle.ToString()}");
   
        }

        public static void SquareRootLebel(int a, int b, int c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни уравнения: x1 = {0}, x2 = {1}", root1, root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {0}", root);
            }
            else
            {
                Console.WriteLine("Уравнение не имеет вещественных корней");
            }

        }
        // добавить, еще метод 
        static void Main(string[] args)
        {
            NumbersFoArea numbers = new NumbersFoArea(AreaOfATriangle);
            numbers += SquareRootLebel; // добавление еще одного метода в numbers
            numbers.Invoke(1, -26, 120);
            numbers.Invoke(20, 30, 40);

        }
    }
}

