namespace CSharpCalculator
{
    class Calculator : ICalculator
    {
        public int add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        public int divide(int operand1, int operand2)
        {
            return operand1 / operand2;
        }

        public int multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        public int subtract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
    }
}