
namespace elementaryOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lines 9-12, you're entering the numbers for the operations
            Console.WriteLine("Hello, please enter the first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you. Please enter the next number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            //addition
            //double addition = firstNum + secondNum;

            //substraction
            //double subtraction = firstNum - secondNum;

            //multiplication
            //double multiply = firstNum * secondNum;

            //division exception
            //if ()

            //division exception
            //double divide = firstNum / secondNum;

            Addition (firstNum, secondNum);
            Subtraction(firstNum, secondNum);
            Multiplication(firstNum, secondNum);
            Division(firstNum, secondNum);
        }

        static void Addition(double firstNum, double secondNum)
        {
            double sum = firstNum + secondNum;
            Console.WriteLine("The sum is: " + sum);
        }
        static void Subtraction(double firstNum, double secondNum)
        {
            double difference = firstNum - secondNum;
            Console.WriteLine("The difference is: " + difference);
        }
        static void Multiplication(double firstNum, double secondNum)
        {
            double product = firstNum * secondNum;
            Console.WriteLine("The product is: " + product);
        }
        
        static void Division(double firstNum, double secondNum)
        {
            if (secondNum == 0)
            {
                Console.WriteLine("Sorry, but you can't divide by zero");
            }
            else 
            {
                double quotient = firstNum / secondNum;
                Console.WriteLine("The quotient is: " + quotient);
            }
        }
    }
}