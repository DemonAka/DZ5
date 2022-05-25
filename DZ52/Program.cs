using System;

namespace DZ52
{
    internal class Program
    {

        static string[] SeparatWords(string phrase)
        {
            string[] masWord = phrase.Split(' ');
            return masWord;
        }
        static string ReversWords(string inputPhrase)
        {
            string[] printWord = SeparatWords(inputPhrase);
            Console.WriteLine("Вуаля магия : ");
            string resultString = "";
            Array.Reverse(printWord);

            foreach (var word in printWord)
            {
                resultString += word + " ";
            }
            Console.WriteLine(resultString);
            return resultString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение или бессвязный набор букв, а я поменяю слова местами");
            ReversWords(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
