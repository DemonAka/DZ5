using System;

namespace DZ5
{
    internal class Program
    {


        static string[] SeparatWords(string phrase)
        {
            string[] masWord = phrase.Split(' ');
            return masWord;
        }
        static string[] Print()
        {
            string[] printWord = SeparatWords(Console.ReadLine());
            Console.WriteLine("Вот список слов из предложения : ");
            foreach (string word in printWord)
            {
                Console.WriteLine($"{word}");
            }
            return printWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение или бессвязный набор букв, а я разделю их на слова");
            Print();
            Console.ReadKey();
        }

    }
}
