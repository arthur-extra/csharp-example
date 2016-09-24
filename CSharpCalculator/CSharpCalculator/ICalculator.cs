namespace CSharpCalculator
{
    interface ICalculator
    {
        int add(int operand1, int operand2);
        int subtract(int operand1, int operand2);
        int multiply(int operand1, int operand2);
        int divide(int operand1, int operand2);
    }
}
