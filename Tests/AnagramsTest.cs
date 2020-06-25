using System.Collections.Generic;
using NUnit.Framework;
using System;
using dummy_anagrams.Src;
using System.IO;

namespace dummy_anagrams.Tests
{
    [TestFixture]
    public class AnagramTest
    {
        [Test]
        public void Print_Correct_Output()
        {

            string[] words = new string[] { "cat", "tca", "cta", "bos", "obs", "sob", "water" };
            string[] anagrams_set = new string[] { "cat, tca, cta", "bos, obs, sob" };
            Hashing hashmap = new Hashing(words);
            Anagrams anagrams = new Anagrams();
            using (StringWriter sw = new StringWriter())
            {   
                Console.SetOut(sw);
                anagrams.Print(hashmap.anagrams);
                Assert.AreEqual(string.Join(Environment.NewLine, anagrams_set) + "\r\n", sw.ToString());
            }
        }


    }
}