using System;
using static DelegationHomeWorks_1.Program;
// 1. Создайте делегат с названием Numbers, который возвращает число,
// а принимает 2 параметра. Метод возвращает сумму 2 чисел. 
// 2. Присоедините еще один метод к нему, который также принимает 2 числа,
// но возвращает возведение числа в степень.
// Вызовите делегат. Потом отсоедините второй метод и покажите как сработает делегат

// Указатель на метод!!! - Делегат

namespace DelegationHomeWorks_1 
{
    internal class Program
    {
        public delegate int Numbers(int a, int b); // создание 

        private static int CalculateNumbs(int a, int b) // метод обработки делегата
        {
            return a + b;
        }

        private static int ExponentiationNumb(int a, int b)
        {
            return (int)Math.Pow(a, b); // 
        }
        
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers(CalculateNumbs);
            numbers += new Numbers(ExponentiationNumb); // присоединил еще один метод в этот экземпляр делегата

            int numbResult = numbers.Invoke(10, 20); // если присоединить еще один метод, в котором есть return(тот который должен, что то возвращать), то будет вызван только последний метод, тоесть метод ExponentiationNumb

            // для вызовов отдельных методов, нужно создать два отдельных экзампляра делегатов
            // Numbers numbers = new Numbers(CalculateNumbs);
            // Numbers numbers2 = new Numbers(ExponentiationNumb);
            // int numbResult = numbers.Invoke(10, 20);
            // int numbResult = numbers.Invoke(10, 20);
            //Console.WriteLine("The sum is: " + numbResult); // результат
            //Console.WriteLine("The expo is: " + expoResult); // результат

            Console.WriteLine("The sum is: " + numbResult); // результат


        }
    }
}
