using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace ConsoleApp4
{
    internal class Program //Guess_the_number Multiplication_table Number_divisors
    {
        static void Main(string[] args)
        {
            Boolean check = true;
            do
            {


                Console.WriteLine("Выбери то что тебе нужно:\r\n1. Игра Угадай число\r\n2. Таблица умножения\r\n3. Вывод делителей числа\r\n4. Очистить консоль\r\n5. Выйти из программы");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Guess_the_number();
                }
                else if (choice == 2)
                {
                    Multiplication_table();
                }
                else if (choice == 3)
                {
                    Number_divisors();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                }
                else if (choice == 5)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Убедительно прошу ввести число от одного до пяти");
                }
            }
            while (check);
        }
        static void Guess_the_number()
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            //Получить случайное число (в диапазоне от 0 до 100)
            int value = rnd.Next(1, 100);
            Boolean did_not_guess = true;
            do
            {
                Console.WriteLine("Введите число");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise != value & choise > value)
                {
                    Console.WriteLine("Перелёт");
                }
                else if (choise != value & choise < value)
                {
                    Console.WriteLine("Недолёт");
                }
                else
                {
                    Console.WriteLine("Ура победа");
                    did_not_guess = false;
                }
            } while (did_not_guess);
        }
        static void Multiplication_table()
        {
            int[,] Multiplication_table = new int[10, 10];

            int line; // переменная для указания строк
            int column; // переменная для указания столбцов
            int element = 1; // Переменная для заполнения массива (ничо лучше не пидумал, если конечно есть со получше, хотя я уверен что есть))

            for (line = 1; line < 10; ++line)
            {
                for (column = 1; column < 10; ++column)
                {
                    element = line * column;
                    Multiplication_table[line, column] = element; // Значение элементу массива присваиваю я (Как магистр ЙодаXD)
                    Console.Write(" " + Multiplication_table[line, column] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Number_divisors()
        {
            double result;
            Boolean decision = true;
            do
            {
                Console.WriteLine("\r\nВведите число. Чтобы вернуться в меню введите слово выйти ");
                string entered = Console.ReadLine();
                if (entered == "выйти") //довольно кастыльно,но когда не спал почти сутки норм 
                {
                    decision = false;
                }
                else
                {
                    Double number = Convert.ToDouble(entered);
                    for (double i = number; i >= 1; i--)
                    {
                        result = number / i;
                        if (Convert.ToInt32(result) == Convert.ToDouble(result))
                        {
                            Console.Write(result + "\t");
                        }
                    }
                }
            } while (decision);
        }
    }
}