using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        while (!endApp)
        {
            string? num1 = "";
            string? num2 = "";
            double result = 0;

            Console.WriteLine("Type a number and press enter");
            num1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(num1, out cleanNum1))
            {
                Console.WriteLine("Please input digit.");
                num1 = Console.ReadLine();
            }

            Console.WriteLine("Type another number and press enter");
            num2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(num2, out cleanNum2))
            { 
                Console.WriteLine("Please input digit.");
                num2 = Console.ReadLine();
            }

            Console.WriteLine("Enter an operation from options below:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\tb - Subtract");
            Console.WriteLine("\tc - Multiply");
            Console.WriteLine("\td - Divide");

            string? op = Console.ReadLine();

            if (op == null || ! Regex.IsMatch(op, "[a|b|c|d]"))
            {
                Console.WriteLine("Please select from given option.");
            }
            else 
            {
                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Mathematical error output");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }

                catch (Exception e)
                {
                    Console.WriteLine("An exception occured. Refer to:" + e.Message);
                }                
            }
        Console.WriteLine("Press 'x' and enter to close the calculator");
        if (Console.ReadLine() == "x") endApp = true;
        Console.WriteLine("\n");
        }
    return;
    }
}