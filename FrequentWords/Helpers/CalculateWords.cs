using FrequentWords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequentWords.Helpers
{
    public class CalculateWords
    {
        private KeyValuePair<string, int>[] WordsList;
        private int LengthWord = 0;
        public CalculateWords(string lengthWord)
        {
            WordsList = CollectionWords.Get();
            Int32.TryParse(lengthWord, out LengthWord);
        }

        public void PrintResult()
        {
            var resultList = WordsList.Where(x => x.Key.Length > LengthWord).OrderByDescending(x => x.Value).Take(10).ToArray();

            Console.WriteLine();
            Console.WriteLine("Результат обработки");
            foreach (var item in resultList)
            {
                Console.WriteLine("Слово {0}, встречалось {1} раз.", item.Key, item.Value);
            }
            Console.WriteLine("Результат успешно выведены");
        }
    }
}
