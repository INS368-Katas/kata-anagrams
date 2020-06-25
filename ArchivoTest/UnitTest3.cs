using dummy_anagrams.ArchivoClass;
using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace dummy_anagrams.ArchivoTest
{
  public class UnitTest3
  {
    [Test]
    public void Assert_Anagrams_Keys()
    {
      string[] words = new string[] { "cat", "tca", "cta", "bos", "obs", "sob", "water" };
      Hashing hashmap = new Hashing(words);
      Anagrams anagrams = new Anagrams(hashmap.anagrams);
      List<String> keys = anagrams.ProcessKeys(hashmap.anagrams);
      List<String> expected = new List<string>() { "act", "bos", "aertw" };
      Assert.AreEqual(keys, expected);
    }
  }
}