using System;
using System.Collections.Generic;
using System.Linq;

namespace dummy_anagrams.Src
{
    public class Hashing
    {
        public Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        public Hashing()
        {

        }

        public Hashing(string[] lines)
        {
            this.anagrams = SortWords(lines);
        }

        private Dictionary<string, List<string>> SortWords(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i];
                char[] characters = word.ToCharArray();
                Array.Sort(characters);
                String sorted_word = new string(characters).ToLower();
                if (anagrams.ContainsKey(sorted_word))
                {
                    anagrams[sorted_word].Add(word);
                }
                else
                {
                    List<string> listWords = new List<string>();
                    listWords.Add(word);
                    anagrams[sorted_word] = listWords;
                }
            }
            return anagrams;
        }
    }
}