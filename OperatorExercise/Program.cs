namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // two integer variables
            int a = 17;
            int b = 4;


            // Operator:
            // Additcion: x + y
            // Subraction: x - y
            // Multiply: x * y
            // Division x / y
            // Modulas: x % y

            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;
            // display results with string interpolation
            Console.WriteLine($"{a}/{b} is {quotient} remainder{1}");
            
            //prompt
            Console.WriteLine("Enter in a radius");
            
            //user input as a string
            string userInput = Console.ReadLine();
            
            //parse string into an double
            double parsedRadius = double.Parse(userInput);
            
            // Asking for radius of circle
            // Double radius = AreaofCircle
            // Console.WriteLine(answer);
            
            Console.WriteLine("Please input the radius value for a circle");
            double radius = double.Parse(Console.ReadLine());
            double answer = AreaofCircle(radius);
            Console.WriteLine($"The value of the area of the circle is {answer}");
            
        }
        //Method for AreaofCircle

        public static double AreaofCircle(double radius)
        {
            // Math.PI * Math.Pow(radius, 2);
            return (Math.PI * Math.Pow(radius, 2));

        }

        static int Add(int number1, int number2)
            {
                int sum = number1 + number2;
                return sum;
            }
        
    }

}
