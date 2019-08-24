using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    //note: a reference to the StringLibrary was made by right clicking dependencies
    /*note: UnitTest1.cs was Saved As a UTF-8 encoded file. Should this have not been done,
     VS saves it as an ASCII file and the runtime doesn't accurately decode all the
     characters outside the ASCII range (like the Greek and Cyrillic chars) correctly,
     returning innacurate test results*/
     /*note: if the library is single use, include as project. If for general use,
      distribute as NuGet project.*/

    [TestClass] //each class tagged with this attribute is executed automatically
    //upon running the unit test
    public class UnitTest1
    {
        [TestMethod] //defines TestMethod1 as a test method for an automatic execution
        //when the unit test is run
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            /*this part would be considered the args where these automatically pass upon
             starting. When tested these defaults will return true, but replacing them
             will cause the test to fail. Notice there are greek letter involved. This is
             why we Save As UTF-8 Encoded File, else those will register in error too.*/
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                       String.Format("Expected for '{0}': true; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            //same happens here
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                       String.Format("Expected for '{0}': false; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { string.Empty, null };
            //if the User writes nothing, the program simply closes 
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                       String.Format("Expected for '{0}': false; Actual: {1}",
                                     word == null ? "<null>" : word, result));
            }
        }
    }
}
