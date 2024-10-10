using System;

namespace Math.operations
{
        public class Relationaloperations
        {
            public double number1, number2;
            public bool GreaterThan(double number1, double number2)
            {
                return (number1 > number2);
            }

            public bool Equal(double number1, double number2)
            {
                return (number1 == number2);
            }
        }

        public class Arithmeticoperations
        {
            public double number1, number2;

            public double add(double number1, double number2)
            {
                return (number1 + number2);
            }

            public double subtract(double number2, double number1)
            {
                return (number2 - number1);
            }
        }
}
