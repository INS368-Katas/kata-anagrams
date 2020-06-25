using System;
using System.Collections.Generic;
using NUnit.Framework;
using dummy_anagrams.Src;

namespace dummy_anagrams.Tests
{
    [TestFixture]
    public class HashingTest
    {
        [Test]
        public void Assert_Dictionary_Hashmap()
        {
            Hashing hashmap = new Hashing();
            Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>();
            Assert.AreEqual(hashmap.anagrams, expected);
        }

        [Test]
        public void Assert_Sorting_Dictionary()
        {
            string[] words = new string[] { "cat", "tca", "cta", "bos", "obs", "sob", "water" };
            Hashing hashmap = new Hashing(words);
            Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>()
            {
                ["act"] = new List<string>() { "cat", "tca", "cta" },
                ["bos"] = new List<string>() { "bos", "obs", "sob" },
                ["aertw"] = new List<string>() { "water" },
            };
            Assert.AreEqual(hashmap.anagrams, expected);
        }

    }
}