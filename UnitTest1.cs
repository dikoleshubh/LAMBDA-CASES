﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest1
    {

    [TestClass]
    public class Test
    {
        /// <summary>
        /// Given Valid First Name should return true
        /// </summary>
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            //Arrange
          
            bool expected = true;
            //Act
            bool output = UserDetail.validateFirstName("Ankita");
            //Assert
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            bool expected = true;
            bool output = UserDetail.validateLastName("Patil");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {
            //Arrange
            bool expected = true;
            //Act
            bool output = UserDetail.validateEmail("abc@gmail.com");
           // Assert
            Assert.AreEqual(expected, output);
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            bool expected = true;
            bool output =UserDetail.validateMobileNo("91 9146293697");
            Assert.AreEqual(expected, output);
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            bool expected = true;
            bool output =UserDetail.validatePassword("Anki@123");
            Assert.AreEqual(expected, output);
        }
    }
}
}
