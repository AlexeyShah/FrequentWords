using System.IO;

namespace FrequentWords.Helpers
{
    public class ReadFile
    {
        public static void Parse(object obj)
        {
            var objArr = (object[])obj;
            var file = (string)objArr[0];

            using (StreamReader sr = new StreamReader(file))
            {
                while (!sr.EndOfStream)
                {
                    var strLine = sr.ReadLine();
                    ParseFile.ParseLine(strLine);
                }
            }
        }
    }
}
