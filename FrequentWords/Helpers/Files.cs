using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrequentWords.Helpers
{
    public class Files
    {
        private readonly string RootPath = "D:\\Project\\Docs";
        private List<string> PathsList;
        public Files(string newPath)
        {
            RootPath = newPath;

            PathsList = new DirectoryInfo(RootPath).GetFiles("*.txt").Select(x => x.FullName).ToList();
        }

        public List<string> GetFileList()
        {
            return PathsList;
        }
    }
}
