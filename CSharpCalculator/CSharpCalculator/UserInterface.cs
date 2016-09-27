using System;

namespace CSharpCalculator
{
    class UserInterface
    {
        private ICalculator calculator;

        public UserInterface(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        public void demo()
        {
            int sum = calculator.add(2, 2);
            int product = calculator.multiply(3, 4);
            Console.WriteLine("The sum of 2 and 2 is " + sum);
            Console.WriteLine("The product of 3 and 4 is " + product);
            Console.ReadLine();
        }
    }
}