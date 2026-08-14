// ==============================
// NuGet Practice - Newtonsoft.Json
// ==============================

// Import Newtonsoft.Json so we can work with JSON.
using Newtonsoft.Json;

// Create a student object.
var student = new
{
    Name = "Maria",
    Course = "Cyber Security"
};

// Convert the student object into JSON.
string json = JsonConvert.SerializeObject(student, Formatting.Indented);

// Display the JSON.
Console.WriteLine("Student as JSON:");
Console.WriteLine();
Console.WriteLine(json);

Console.WriteLine();


// ==============================
// Exercise 1 - Personalised Greeting
// ==============================

// Create a method that accepts a name and city.
static void Introduce(string name, string city)
{
    Console.WriteLine($"{name} lives in {city}.");
}

// Call the method with different values.
Introduce("Maria", "Rugby");
Introduce("Ana", "London");
Introduce("Lucas", "Birmingham");

Console.WriteLine();


// ==============================
// Exercise 2 - Area Calculator
// ==============================

// Calculate the area of a rectangle.
static double CalculateRectangleArea(double width, double height)
{
    return width * height;
}

// Calculate the area of a circle.
static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

double rectangleArea = CalculateRectangleArea(5, 3);
double circleArea = CalculateCircleArea(4);

Console.WriteLine($"Rectangle area: {rectangleArea}");
Console.WriteLine($"Circle area: {circleArea}");

Console.WriteLine();


// ==============================
// Exercise 3 - Refactor the Calculator
// ==============================

// Create a method for each calculation.
static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a - b;
}

static double Multiply(double a, double b)
{
    return a * b;
}

static double Divide(double a, double b)
{
    if (b == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
        return 0;
    }

    return a / b;
}

static double Modulus(double a, double b)
{
    return a % b;
}

// Choose two numbers.
double number1 = 10;
double number2 = 5;

// Choose which operation to perform.
string operation = "+";

double result = 0;

// Call the correct method using a switch.
switch (operation)
{
    case "+":
        result = Add(number1, number2);
        break;

    case "-":
        result = Subtract(number1, number2);
        break;

    case "*":
        result = Multiply(number1, number2);
        break;

    case "/":
        result = Divide(number1, number2);
        break;

    case "%":
        result = Modulus(number1, number2);
        break;

    default:
        Console.WriteLine("Invalid operation.");
        break;
}

// Display the result.
Console.WriteLine($"Calculator result: {result}");

// ==============================
// Exercise 4 - Find Statistics
// ==============================

// Store a fixed set of marks in an array.
int[] marks = { 67, 82, 91, 54, 76, 88 };

// Start the total at 0.
int total = 0;

// Start highest and lowest using the first mark.
int highest = marks[0];
int lowest = marks[0];

// Go through each mark in the array.
foreach (int mark in marks)
{
    total += mark;

    if (mark > highest)
    {
        highest = mark;
    }

    if (mark < lowest)
    {
        lowest = mark;
    }
}

// Calculate the average.
double average = (double)total / marks.Length;

// Display the results.
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Highest: {highest}");
Console.WriteLine($"Lowest: {lowest}");