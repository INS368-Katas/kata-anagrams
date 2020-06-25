using NUnit.Framework;


namespace tendencias_anagram
{
    public class Tests
    {

        [Test]
        public void New_Object_Has_Empty_Array()
        {   
           string[] expected_resultd = new string[]{};
           Archivo ar = new Archivo();
           string[] output = ar.get_array();
           Assert.AreEqual(output, expected_resultd);
        }

        [Test]
        public void Object_Returns_Array_With_String_(){
            string[] expected_result = new string[]{"jun","adriel"};
           Archivo ar = new Archivo(@"/home/alejandro/Documents/anagrams/dummy-anagrams/obj/Debug/netcoreapp3.1/ejemplo.txt");

           string[] output = ar.get_array();

           Assert.AreEqual(output, expected_result);
        }

        
    }
}