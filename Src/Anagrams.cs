using System;
using System.Collections.Generic;
using System.Text;

namespace dummy_anagrams.Src
{
    public class Anagrams
    {
        public Dictionary<string, List<String>> anagram_sets = new Dictionary<string, List<string>>();
        public string longest_key = "";
        public int anagram_words_count = 0;
        public int anagrams_sets_quantity = 0;
        public List<string> longests_words = new List<string>();
        public List<string> longests_set = new List<string>();
        public void Print(Dictionary<string, List<String>> map)
        {

            foreach (var set in map)
            {
                if (set.Value.Count > 1)
                {
                    anagram_words_count += set.Value.Count;
                    anagrams_sets_quantity++;
                    anagram_sets.Add(set.Key, set.Value);
                    Console.WriteLine(string.Join(", ", set.Value));
                }
            }
        }

        public void ObtainLongestWord()
        {
            foreach (var set in anagram_sets)
            {
                if (set.Key.Length > longest_key.Length)
                {
                    longests_words = set.Value;
                    longest_key = set.Key;
                }
            }
        }
        public void ObtainLongestSet()
        {
            foreach (var set in anagram_sets)
            {
                if (set.Value.Count > longests_set.Count)
                {

                    longests_set = set.Value;

                }
            }
        }


    }
}

