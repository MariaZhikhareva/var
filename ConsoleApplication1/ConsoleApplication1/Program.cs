using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите второе число для умножения");
            //Ввод числа с клавиатуры
            string s = Console.ReadLine();
            int a = Convert.ToInt32(s);
           //Формула умножения
            int b = 2 * a;
            //Вывод ответа на экран
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
