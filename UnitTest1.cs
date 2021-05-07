using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {


        /*  UC1:- As a User need to enter a valid First Name - First name starts with Cap and has minimum 3 characters
         */
        [TestMethod]
        [DataRow("Shubh", true)]   //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("Dikole", true)]
        public void UnitTestPatternValidation_ValidName(string FirstName, bool expected)
        {
            string FirstNamePattern = @"^[A-Z][a-z ]{2,}$"; //Define Pattern
            bool actual = Program.PatternValidation(FirstName, FirstNamePattern); //passing parameter

            Assert.AreEqual(expected, actual);  // section verifies that the action of the method under test behaves as expected.
        }
        
        
        [TestMethod]
        [DataRow("1252", "Invalid")]  //add parameters using the [DataRow] attribute values from the [DataRow] attribute will be passed to the test method
        [DataRow("ok", "Invalid")]
        [DataRow(".dfgjs", "Invalid")]
        public void UnitTestPatternValidation_InvalidName(string FirstName, string expected)
        {
            try
            {
                string FirstNamePattern = @"^[A-Z][a-z ]{2,}$";  //Define Pattern
                Program.PatternValidation(FirstName, FirstNamePattern);  
            }
            catch (InvalidDataException ex)
            {

                Assert.AreEqual(expected, ex.Message); // section verifies that the action of the method under test behaves as expected.
            }

        }



    }
}
