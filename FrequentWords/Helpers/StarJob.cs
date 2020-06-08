using System.Collections.Generic;
using System.Threading;

namespace FrequentWords.Helpers
{
    public class StartJob
    {
        public static void GenerateJob(List<string> pathList)
        {
            List<Thread> ThreadList = new List<Thread>();
            foreach (var file in pathList)
            {
                var param = new object[1];
                param[0] = file;

                var thread = new Thread(ReadFile.Parse);
                thread.IsBackground = true;
                thread.Start(param);

                ThreadList.Add(thread);
            }

            WaidEndJob(ThreadList);
        }

        private static void WaidEndJob(List<Thread> threadList)
        {
            foreach (var thread in threadList)
            {
                thread.Join();
            }
        }
    }
}
