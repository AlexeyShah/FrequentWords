using System.Collections.Concurrent;
using System.Collections.Generic;

namespace FrequentWords.Entity
{
    public class CollectionWords
    {
        private static ConcurrentDictionary<string, int> collectionWords;
        public static void Add(string[] arrWords)
        {
            if (collectionWords == null)
                collectionWords = new ConcurrentDictionary<string, int>();

            foreach (var word in arrWords)
                if(!string.IsNullOrEmpty(word))
                    collectionWords.AddOrUpdate(word, 1, (key, oldValue) => oldValue + 1);
        }
        public static KeyValuePair<string,int>[] Get()
        {
            return collectionWords.ToArray();
        }
    }
}
