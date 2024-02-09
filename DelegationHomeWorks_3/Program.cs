using System;
// 3.Создайте делегат, который принимает 2 строки. Делегат должен возвращать строку. Создайте соответствующий метод. Пример на вход подается
// “Hello it is me”.
// “it”

namespace DelegationHomeWorks_1
{
    internal class Program
    {
        public delegate string FindWordInString(string a, string b); // создание 

        public static string EnterString(string a, string b)
        {
            string message = "There is no string";

            string[] wordOfA = a.Split(' ');

            foreach (string word in wordOfA)
            {

                if (word.ToLower() == b.ToLower()) 
                {
                    message = $"There is this ({word}) word in the line";
                    break; // прекратить после первого совпадения
                }
            }
            return message;
        }

        static void Main(string[] args)
        {
            FindWordInString findWordInString = new FindWordInString(EnterString);

            string _message = findWordInString.Invoke("Hello it is me", "i");
            Console.WriteLine(_message);
        }
    }
}