using System;

namespace DZ5
{
    internal class Program
    {


        static string[] SeparatWords(string phrase)
        {
            string[] masWord = phrase.Split(' ');
            Print(masWord);
            return masWord;
        }

        static string[] Print(string[] masWord)
        {
            foreach (var word in masWord)
            {
                Console.WriteLine($"{word}");
            }
            return masWord;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение или бессвязный набор букв, а я разделю их на слова");
            SeparatWords(Console.ReadLine());
            Console.ReadKey();
        }

    }
}
