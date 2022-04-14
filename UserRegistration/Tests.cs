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
                string msg = " ";
                string expected = "Valid";

                UserRegister p = new UserRegister(msg);

                string actual = p.FirstName("Valid");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void LastName()
            {
                string msg = " ";
                string expected = "Valid";

                UserRegister p = new UserRegister(msg);

                string actual = p.LastName("Valid");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Email()
            {
                string msg = " ";
                string expected = "Invalid";

                UserRegister p = new UserRegister(msg);

                string actual = p.Email("Invalid");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void MobileNumber()
            {
                string msg = " ";
                string expected = "Invalid";

                    UserRegister p = new UserRegister(msg);

                string actual = p.MobileNumber("Invalid");

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Password()
            {
                string msg = " ";
                string expected = "Invalid";

                UserRegister p = new UserRegister(msg);

                string actual = p.Password("Invalid");

                Assert.AreEqual(expected, actual);
            }
        }
    }
}