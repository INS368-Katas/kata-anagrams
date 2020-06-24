using NUnit.Framework;


namespace tendencias_anagram
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void New_Object_Has_Empty_Array()
        {   
            string[] expected_result = new string[]{};
            Archivo ar = new Archivo();
            string[] output = ar.get_array();
            Assert.AreEqual(output, expected_result);
        }

        [Test]
        public void Returns_The_Correct_Elements(){

            string[] expected_result = new string[]{};
            Archivo ar = new Archivo();
            
            string[] output = ar.get_array();
            Assert.AreEqual(output, expected_result);
        }
    }
}