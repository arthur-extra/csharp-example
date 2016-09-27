namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();
            UserInterface ui = new UserInterface(calculator);
            ui.demo();
        }
    }
}
