using System;
using System.Collections.Generic;
using System.Text;

namespace dummy_anagrams.Src
{
    public class Anagrams
    {
        public Anagrams(Dictionary<string, List<String>> map) { }

        public List<String> ProcessKeys(Dictionary<string, List<String>> map)
        {
            List<String> value = new List<string>();
            foreach (KeyValuePair<String, List<String>> entry in map)
            {
                value.Add(entry.Key);
            }
            return value;
        }
        public void print(Dictionary<string, List<String>> map, List<String> value)
        {
            int k = 0;
            foreach (KeyValuePair<String, List<String>> entry in map)
            {
                List<String> values = map[value[k++]];
                if (values.Count > 1)
                {
                    int len = 1;
                    foreach (String word in values)
                    {
                        Console.Write(word);
                        if (len++ < values.Count)
                        {
                            Console.Write(", ");
                        }
                    }
					Console.WriteLine();
                }
            }
        }
    }
}

