using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWordRemoval
{
    class Program
    {
        public static List<string> sentenceList;

        static void Main(string[] args)
        {
            string sentence = "";
            sentenceList = new List<string>();

            Console.WriteLine("Please enter a sentence and I'll display DISTINCT words");
            sentence = Console.ReadLine();

            sentenceList = sentence.ToLower().Split().Distinct().ToList();

            var query = from word in sentenceList
                        orderby word
                        select word;

            foreach (var element in query)
                Console.WriteLine(element);

            Console.ReadLine();

        }
    }
}
