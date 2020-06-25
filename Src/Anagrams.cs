using System;
using System.Collections.Generic;
using System.Text;

namespace dummy_anagrams.Src
{
    public class Anagrams
    {
        public int anagramSets;
        public int ammount_Of_Words;

        public Anagrams()
        {
            this.anagramSets = 0;
            this.ammount_Of_Words = 0;
        }
        public List<String> ProcessKeys(Dictionary<string, List<String>> map)
        {
            List<String> value = new List<string>();
            foreach (KeyValuePair<String, List<String>> entry in map)
            {
                value.Add(entry.Key);
            }
            return value;
        }
        public void print(Dictionary<string, List<String>> map)
        {
            foreach (List<string> set in map.Values)
            {
                if (set.Count > 1)
                {
                    Console.WriteLine(string.Join(", ", set));
                    this.ammount_Of_Words += set.Count;
                    this.anagramSets++;
                }
            }
        }
    }
}

