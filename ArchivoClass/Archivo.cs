using System;
using NUnit.Framework;
using System.IO;
using System.Collections.Generic;

namespace tendencias_anagram
{
    public class Archivo
    {
        string[] internal_array = null;

        public Archivo(){

            internal_array = new string[]{};
        }

        public void decode_file (String path){
            StreamReader sr = new StreamReader(path);
            string line;
            List<string> List = new List<string>();

            while ((line = sr.ReadLine()) != null){
                List.Add(line);
            }

            this.internal_array = List.ToArray();
        }

        public string[] get_array(){
            return this.internal_array;
        }

    }
}
