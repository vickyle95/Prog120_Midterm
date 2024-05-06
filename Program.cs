using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Prog120_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Vicky Le
            // Class: Programming 120
            // Date: 5/5/2024
            // Assignment: Midterm

            //PersonalCalculator();
            //FinanceCalculator();
            //GeometryCalculator();
            //CartesianPlane();
            Menu();

        } // Main

        public static void PersonalCalculator()
        {
            Console.WriteLine("Personal Calculator");
            bool continueCalculating = true;

            do
            {
                try
                {
                    // User input first number
                    Console.Write("Enter the first number: ");
                    double userInput1 = double.Parse(Console.ReadLine());

                    // Ask user for the operation
                    Console.Write("Choose an operation (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    // User input second number
                    Console.Write("Enter the second number: ");
                    double userInput2 = double.Parse(Console.ReadLine());

                    // Select operation and display the result
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"{userInput1} + {userInput2} = {userInput1 + userInput2}");
                            break;
                        case "-":
                            Console.WriteLine($"{userInput1} - {userInput2} = {userInput1 - userInput2}");
                            break;
                        case "*":
                            Console.WriteLine($"{userInput1} * {userInput2} = {userInput1 * userInput2}");
                            break;
                        case "/":
                            if (userInput2 != 0)
                            {
                                Console.WriteLine($"{userInput1} / {userInput2} = {userInput1 / userInput2}");
                            }
                            else
                            {
                                Console.WriteLine($"Error: Cannot divide by zero");
                            }
                            break;
                    }

                    // Ask user if they want to continue
                    Console.Write("Do you want to perform another calculation? (yes/no): ");
                    string userContinueInput = Console.ReadLine().ToLower();

                    if (userContinueInput != "yes")
                    {
                        continueCalculating = false;
                    }
                }
                catch
                {
                    Console.WriteLine($"Invalid input. Please enter a valid number.");
                }
            } while (continueCalculating);
        } // PersonalCalculator()

        public static void FinanceCalculator()
        {
            bool continueCalculating = true;
            Console.WriteLine("Finance Calculator");

            do
            {
                try
                {
                    Console.WriteLine("Select a finance option: ");
                    Console.WriteLine("1. Net Income");
                    Console.WriteLine("2. Rule 72");
                    Console.WriteLine("3. Net Worth");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        // Calculate net income
                        Console.Write("Enter Total Revenues: ");
                        double totalRevenues = double.Parse(Console.ReadLine());

                        Console.Write("Enter Total Costs: ");
                        double totalCosts = double.Parse(Console.ReadLine());

                        double netIncome = totalRevenues - totalCosts;
                        Console.WriteLine($"Net Income : {netIncome.ToString("c")}");
                    }
                    else if (choice == 2)
                    {
                        // Calculate rule 72
                        Console.Write("Enter the interest rate (r): ");
                        double interestRate = double.Parse(Console.ReadLine());

                        if (interestRate != 0)
                        {
                            double numberOfYears = 72.0 / interestRate;
                            double roundedNumberOfYears = Math.Round(numberOfYears, 1);
                            Console.WriteLine($"With an interest rate of {interestRate}, your money will double in {roundedNumberOfYears} years.");
                        }
                        else
                        {
                            Console.WriteLine("Error: Interest rate (r) cannot be zero.");
                        }
                    }
                    else if (choice == 3)
                    {
                        // Calculate net worth
                        Console.Write("Enter Total Assets: ");
                        double totalAssets = double.Parse(Console.ReadLine());

                        Console.Write("Enter Total Liabilities: ");
                        double totalLiabilities = double.Parse(Console.ReadLine());

                        double netWorth = totalAssets - totalLiabilities;
                        Console.WriteLine($"Your Net Worth is: {netWorth.ToString("c")}");
                    }
                    else if (choice == 4)
                    {
                        // Exit the program
                        continueCalculating = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                if (continueCalculating)
                {
                    Console.Write("Do you want to perform another finance calculation? (yes/no): ");
                    string userContinueInput = Console.ReadLine().ToLower();
                    if (userContinueInput != "yes")
                    {
                        continueCalculating = false;
                    }
                }
            } while (continueCalculating);
        } // FinanceCalculator()

        public static void GeometryCalculator()
        {
            Console.WriteLine("Geometry Calculator");
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Select a shape to calculate: ");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Right Cone");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 0 || choice > 5))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
                if (choice == 1)
                {
                    // Calculate square
                    Console.Write("Enter the side length of the square: ");
                    double sideLength = double.Parse(Console.ReadLine());

                    double squareArea = sideLength * sideLength;
                    double squarePerimeter = 4 * sideLength;

                    Console.WriteLine($"Square Area: {squareArea}");
                    Console.WriteLine($"Square Perimeter: {squarePerimeter}");
                }
                else if (choice == 2)
                {
                    // Calculate Rectangle
                    Console.Write("Enter the length of the rectangle: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    double width = double.Parse(Console.ReadLine());

                    double rectangleArea = length * width;
                    double rectanglePerimeter = 2 * (length + width);

                    Console.WriteLine($"Rectangle Area: {rectangleArea}");
                    Console.WriteLine($"Ractangle Perimeter: {rectanglePerimeter}");
                }
                else if (choice == 3)
                {
                    // Calculate Circle
                    Console.Write("Enter the radius of the circle: ");
                    double radius = double.Parse(Console.ReadLine());

                    double circleArea = Math.PI * radius * radius;
                    double circleCircumference = 2 * Math.PI * radius;

                    Console.WriteLine($"Circle Area: {circleArea}");
                    Console.WriteLine($"Circle Circumference: {circleCircumference}");
                }
                else if (choice == 4)
                {
                    // Calculate Right Cone
                    Console.Write("Enter the radius of the cone's base: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height of the cone: ");
                    double height = double.Parse(Console.ReadLine());

                    double coneVolume = (Math.PI * radius * radius * height) / 3;

                    Console.WriteLine($"Right Cone Volume: {coneVolume}");
                }
                else if (choice == 5)
                {
                    // Exit program
                    continueCalculating = false;
                }
            }
        } // GeometryCalculator()

        public static void CartesianPlane()
        {
            Console.WriteLine("Cartesian Plane");

            bool continueCalculating = true;
            while (continueCalculating)
            {
                // User enter x and y values
                Console.Write("Enter the x-coordinate (or type 'exit' to quit): ");
                string userInputX = Console.ReadLine();

                if (userInputX.ToLower() == "exit")
                {
                    break;
                }

                int x;
                if (!int.TryParse(userInputX, out x))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'exit'.");
                    continue;
                }

                Console.Write("Enter the y-coordinate: ");
                int y;
                if (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                // Check the quadrant or position of the point
                if (x > 0 && y > 0)
                {
                    Console.WriteLine($"Your coordinates at ({x}, {y} are in Quadrant I)");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine($" Your coordinates at ({x}, {y} are in Quadrant II)");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine($"Your coordinates at ({x}, {y}) are in Quadrant III)");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine($"Your coordinates at ({x}, {y}) are in Quadrant IV)");
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine($"Your coordinates at ({x}, {y}) are on the y-axis)");
                }
                else if (x != 0 && y == 0)
                {
                    Console.WriteLine($"Your coordinates at ({x}, {y}) are on the x-axis)");
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine("Your coordinates are at the origin (0,0)");
                }
                else
                {
                    Console.WriteLine("Unexpected input. Please enter valid integer coordinates.");
                }
            }
        } // CartesianPlane()

        public static void Menu()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Calculator Menu:");
                Console.WriteLine("1. Personal Calculator");
                Console.WriteLine("2. Finance Calculator");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Cartesian Plane");
                Console.WriteLine("5. Exit");

                Console.Write("Please enter your option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    PersonalCalculator();
                }
                else if (choice == "2")
                {
                    FinanceCalculator();
                }
                else if (choice == "3")
                {
                    GeometryCalculator();
                }
                else if (choice == "4")
                {
                    CartesianPlane();
                }
                else if (choice == "5")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid choice.");
                }
            }    
        } // Menu()
    } // Class
} // Namespace
