using System;
using System.Collections.Generic;
namespace dummy_anagrams.ArchivoClass
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
        String words = new string(characters);
        if (anagrams.ContainsKey(words))
        {
          anagrams[words].Add(word);
        }
        else
        {
          List<string> listWords = new List<string>();
          listWords.Add(word);
          anagrams[words] = listWords;
        }
      }
      return anagrams;
    }



  }
}