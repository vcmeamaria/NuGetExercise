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

// Calculate and return the area of a rectangle.
static double CalculateRectangleArea(double width, double height)
{
    return width * height;
}

// Calculate and return the area of a circle.
static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}

// Store the results returned by the methods.
double rectangleArea = CalculateRectangleArea(5, 3);
double circleArea = CalculateCircleArea(4);

// Display the results.
Console.WriteLine($"Rectangle area: {rectangleArea}");
Console.WriteLine($"Circle area: {circleArea}");