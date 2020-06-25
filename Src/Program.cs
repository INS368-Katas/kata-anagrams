using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace dummy_anagrams.Src
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            Archivo file = new Archivo("wordlist.txt");
            Hashing diccionary = new Hashing(file.get_array());
            Anagrams anagram = new Anagrams();
            anagram.Print(diccionary.anagrams);
            timer.Stop();
            Console.WriteLine();
            Console.WriteLine($"Cantidad de tiempo: {timer.Elapsed}");
            Console.WriteLine($"Cantidad de palabras: {file.get_array().Length}");
            Console.WriteLine($"Cantidad de sets de anagramas: {anagram.anagrams_sets_quantity}");
            Console.WriteLine($"Cantidad de palabras con anagramas: {anagram.anagram_words_count}");
            anagram.ObtainLongestSet();
            anagram.ObtainLongestWord();
            Console.WriteLine($"Set de anagramas con mas palabras: {string.Join(", ", anagram.longests_set)} \nTamaño: {anagram.longests_set.Count}");
            Console.WriteLine($"Set de anagramas con palabras mas largas: {string.Join(", ", anagram.longests_words)} \nTamaño: {anagram.longest_key.Length}");

        }
    }
}
