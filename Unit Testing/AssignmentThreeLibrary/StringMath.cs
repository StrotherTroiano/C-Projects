using LibraryInterfaces;
using System;

namespace AssignmentThreeLibrary
{
    public class StringMath
    {
        private readonly ILogger _logger;

        /// <summary>
        /// Construct an instance of the StringMath class.
        /// </summary>
        /// <param name="logger">
        /// An instance of a class that implements the <see cref="ILogger"/> interface
        /// </param>
        public StringMath(ILogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Add the integer equivalent of the two passed strings and return the
        /// result.
        /// </summary>
        /// <param name="int1">The first integer, as a string</param>
        /// <param name="int2">The second integer, as a string</param>
        /// <returns>The sum of the passed values</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if either input parameter cannot be represented as an integer
        /// </exception>
        public int AddIntegers(string int1, string int2)
        {
            int op1;

            if (!int.TryParse(int1, out op1))
            {
                throw new ArgumentException("The input was not an integer", nameof(int1));
            }

            int op2;

            if (!int.TryParse(int2, out op2))
            {
                throw new ArgumentException("The input was not an integer", nameof(int2));
            }

            int result = op1 + op2;

            _logger.Log($"{int1} + {int2} = {result}");

            return result;
        }

        /// <summary>
        /// Takes the reciprocal of the passed string (if it is an integer) and
        /// returns the result as a double.
        /// </summary>
        /// <param name="integerDenominator">A string representation of an integer</param>
        /// <returns>The reciprocal of the input as a double</returns>
        /// <exception cref="ArgumentException">
        /// Thrown if the input cannot be represented as an integer
        /// </exception>
        /// <exception cref="DivideByZeroException">
        /// Thrown if the input is parsed as the integer value zero
        /// </exception>
        public double Reciprocal(string integerDenominator)
        {
            int divisor;

            if (!int.TryParse(integerDenominator, out divisor))
            {
                throw new ArgumentException("The input was not a double", nameof(integerDenominator));
            }

            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }

            if (integerDenominator == null)
            {
                throw new ArgumentNullException("Cannot pass in a null value");
            }

            double result = 1.0 / divisor;

            _logger.Log($"1 / {integerDenominator} = {result}");

            return result;
        }
    }
}
