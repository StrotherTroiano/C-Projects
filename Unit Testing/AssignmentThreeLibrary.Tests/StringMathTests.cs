using System;
using LibraryInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssignmentThreeLibrary.Tests
{
    [TestClass]
    public class StringMathTests
    {
        /// <summary>
        /// Test the 'normal' path for AddIntegers, i.e. valid inputs with
        /// assertion that the returned result equals some expected value
        /// </summary>
        [TestMethod]
        public void StringMath_AddIntegers_Normal()
        {
            // test values
            const int expected = 42;

            const string int1 = "41";
            const string int2 = "1";

            // create a new instance and pass an ILogger
            StringMath math = new StringMath(new TestLogger());

            // execute the method to tests and get the result
            int actual = math.AddIntegers(int1, int2);

            // assert that the actual result matches the expected value
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test that the 'Reciprocal' method throws a
        /// <see cref="DivideByZeroException"/> when passed a string
        /// representation of zero.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void StringMath_Reciprocal_DivByZero()
        {
            // nothing to set up for this test except creating a StringMath
            // instance
            StringMath math = new StringMath(new TestLogger());

            // execute the method with the bad input, if the expected exception
            // is thrown (see the 'ExpectedException' on the method), the test
            // passes, otherwise it fails
            math.Reciprocal("0");
        }

        // add additional tests for 'AddIntegers' and 'Reciprocal' here...
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void StringMath_NullException()
        {
            StringMath NullMath = new StringMath(new TestLogger());

            NullMath.Reciprocal(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StringMath_TooLong()
        {
            StringMath TooLongMath = new StringMath(new TestLogger());

            TooLongMath.Reciprocal("999999999999999999999999999999999");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void StringMath_SpecialCharacters()
        {
            StringMath SpecialMath = new StringMath(new TestLogger());

            SpecialMath.Reciprocal("$%^@@");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void StringMath_EmptyString()
        {
            StringMath EmptyMath = new StringMath(new TestLogger());

            EmptyMath.Reciprocal("");
        }
    }

    /// <summary>
    /// An implementation of the ILogger interface for testing purposes.
    /// </summary>
    public class TestLogger : ILogger
    {
        // your implementation of the ILogger interface goes here...
        public void Log(string message)
        {
            throw new NotImplementedException();
        }
    }
}
