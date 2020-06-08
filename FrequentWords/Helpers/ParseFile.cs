using FrequentWords.Entity;
using System.Text.RegularExpressions;

namespace FrequentWords.Helpers
{
    public class ParseFile
    {
        public static void ParseLine(string strLine)
        {
            if (string.IsNullOrEmpty(strLine))
                return;

            var arrWord = Regex.Split(strLine, @"\s|\d|\W", RegexOptions.Compiled);
            if(arrWord.Length > 0)
                CollectionWords.Add(arrWord);
        }
    }
}
