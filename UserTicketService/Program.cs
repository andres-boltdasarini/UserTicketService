class Program
{
        static void Main(string[] args)
        {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Subtraction(300, 10));
        }
}
public class Calculator
{
        public int Additional(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
}