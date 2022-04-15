using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProblem;

namespace UserRegistration
{
    [TestClass]
    public class Tests
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void FirstName()
            {
                string msg = "Manoj ";
                string expected = "Valid";
                //Arrange
                UserRegister p = new UserRegister(msg);
                //Act
                string actual = p.FirstName("Valid");
                //Assert
                Assert.AreEqual(expected, actual);
            }

           

            [TestMethod]
            public void LastName()
            {
                string msg = "Saiias";
                string expected = "Valid";
                //Arrange
                UserRegister p = new UserRegister(msg);
                //Act
                string actual = p.LastName("Valid");
                //Assert
                Assert.AreEqual(expected, actual);
            }
           [TestMethod]
            public void Email()
            {
                string msg = " ";
                string expected = "Invalid";
                //Arrange
                UserRegister p = new UserRegister(msg);
                //Act
                string actual = p.Email("Invalid");
                //Assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void MobileNumber()
            {
                string msg = " ";
                string expected = "Invalid";
                //Arrange
                UserRegister p = new UserRegister(msg);
                //Act
                string actual = p.MobileNumber("Invalid");
                //Assert
                Assert.AreEqual(expected, actual);
            }






        }

    }
}