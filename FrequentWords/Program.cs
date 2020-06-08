#define Debug
using FrequentWords.Entity;
using FrequentWords.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequentWords
{
    public class Program
    {
        static void Main(string[] args)
        {
#if Debug
            args = new string[2];
            args[0] = "D:\\Project\\Docs";
            args[1] = "5";
#endif
            if (args.Length != 2)
            {
                Console.WriteLine("Необходимо указать путь до файла и длинну слова");
                return;
            }
            var pathList = new Files(args[0]);
            StartJob.GenerateJob(pathList.GetFileList());

            var calculateResult = new CalculateWords(args[1]);
            calculateResult.PrintResult();
            Console.ReadLine();
        }
    }
}
