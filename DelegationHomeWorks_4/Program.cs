using System;

// 4.	Создайте делегат, который принимает массив целых чисел и возвращает их сумму.
// Затем создайте метод, который использует этот делегат для вычисления суммы чисел в массиве. 
namespace DelegationHomeWorks_4 
{
    internal class Program
    {
        public delegate int Numbers(int[] numb);

        public static int CalcNumb(int[] numb)
        {
            int summ = 0;
            foreach (int num in numb)
            {
                summ += num;
            }

            return summ;
        }

        static void Main(string[] args)
        {
            Numbers numbers = new Numbers(CalcNumb);

            int[] numbArray = new int[10] { 5, 8, 20, 50, 17, 26, 13, 22, 1, 6, };

            int result = numbers.Invoke(numbArray);

            Console.WriteLine(result);
        }
    }
}