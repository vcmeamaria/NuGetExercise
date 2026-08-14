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

Console.WriteLine();


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

Console.WriteLine();


// ==============================
// Exercise 5 - Shopping List
// ==============================

// Create a shopping list.
List<string> shoppingList = new();

// Add products to the list.
shoppingList.Add("Milk");
shoppingList.Add("Bread");
shoppingList.Add("Eggs");
shoppingList.Add("Coffee");
shoppingList.Add("Chocolate");

// Remove one product.
shoppingList.Remove("Bread");

// Display how many products are left.
Console.WriteLine($"Items in shopping list: {shoppingList.Count}");

// Display each product.
foreach (string item in shoppingList)
{
    Console.WriteLine(item);
}

Console.WriteLine();


// ==============================
// Exercise 6 - Student Marks Dictionary
// ==============================

// Create a dictionary with student names and marks.
Dictionary<string, int> studentMarks = new();

studentMarks["Maria"] = 82;
studentMarks["Ana"] = 67;
studentMarks["Lucas"] = 54;
studentMarks["Sofia"] = 91;
studentMarks["Daniel"] = 43;

// Convert a mark into a grade.
static string GetGrade(int mark)
{
    if (mark >= 70)
    {
        return "Distinction";
    }
    else if (mark >= 60)
    {
        return "Merit";
    }
    else if (mark >= 50)
    {
        return "Pass";
    }
    else
    {
        return "Fail";
    }
}

// Display each student's name, mark and grade.
foreach (var entry in studentMarks)
{
    string grade = GetGrade(entry.Value);

    Console.WriteLine(
        $"{entry.Key}: {entry.Value} - {grade}"
    );
}

Console.WriteLine();


// ==============================
// Exercise 7 - Product Class
// ==============================

// Create three product objects.
Product laptop = new Product(1, "Laptop", 850.00m, 5);
Product mouse = new Product(2, "Mouse", 25.00m, 10);
Product keyboard = new Product(3, "Keyboard", 45.00m, 7);

// Change the stock.
laptop.IncreaseStock(2);
mouse.ReduceStock(3);
keyboard.IncreaseStock(1);

// Display the products.
Console.WriteLine($"{laptop.Name}: £{laptop.Price} - Stock: {laptop.StockQuantity}");
Console.WriteLine($"{mouse.Name}: £{mouse.Price} - Stock: {mouse.StockQuantity}");
Console.WriteLine($"{keyboard.Name}: £{keyboard.Price} - Stock: {keyboard.StockQuantity}");

Console.WriteLine();


// ==============================
// Exercise 8 - Vehicle Hierarchy
// ==============================

// Create a list with different vehicle types.
List<Vehicle> vehicles = new()
{
    new Car("AB12 CDE", "Toyota", 5),
    new Motorcycle("XY34 ZFG", "Honda", 600)
};

// Display information about each vehicle.
foreach (Vehicle vehicle in vehicles)
{
    vehicle.Describe();
}

Console.WriteLine();


// ==============================
// Exercise 9 - Safe Division
// ==============================

// Ask the user for the first number.
Console.Write("Enter the first number: ");
string firstInput = Console.ReadLine() ?? "";

// Ask the user for the second number.
Console.Write("Enter the second number: ");
string secondInput = Console.ReadLine() ?? "";

// Convert the inputs safely.
if (int.TryParse(firstInput, out int firstNumber) &&
    int.TryParse(secondInput, out int secondNumber))
{
    if (secondNumber == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        double divisionResult = (double)firstNumber / secondNumber;
        Console.WriteLine($"Result: {divisionResult}");
    }
}
else
{
    Console.WriteLine("Please enter valid whole numbers.");
}

// ==============================
// Exercise 10 - Save Names to Disk
// ==============================

// File used to store the names.
string namesFile = "names.txt";

// Create a list to store the names.
List<string> names = new();

// Load existing names if the file already exists.
if (File.Exists(namesFile))
{
    names.AddRange(File.ReadAllLines(namesFile));
}

// Ask the user for a new name.
Console.Write("Enter a name to save: ");
string newName = Console.ReadLine() ?? "";

// Add the name if it is not empty.
if (!string.IsNullOrWhiteSpace(newName))
{
    names.Add(newName);
}

// Save all names to the file.
File.WriteAllLines(namesFile, names);

// Display all saved names.
Console.WriteLine("Saved names:");

foreach (string name in names)
{
    Console.WriteLine(name);
}

// ==============================
// Product Class for Exercise 7
// ==============================

public class Product
{
    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; private set; }
    public int StockQuantity { get; private set; }

    // Set the starting product information.
    public Product(int id, string name, decimal price, int stockQuantity)
    {
        if (price < 0)
        {
            throw new ArgumentException("Price cannot be negative.");
        }

        if (stockQuantity < 0)
        {
            throw new ArgumentException("Stock cannot be negative.");
        }

        Id = id;
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    // Add more stock.
    public void IncreaseStock(int amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative.");
        }

        StockQuantity += amount;
    }

    // Remove stock.
    public void ReduceStock(int amount)
    {
        if (amount < 0 || amount > StockQuantity)
        {
            throw new ArgumentException("Invalid stock amount.");
        }

        StockQuantity -= amount;
    }
}


// ==============================
// Vehicle Classes for Exercise 8
// ==============================

// Base class shared by all vehicles.
public class Vehicle
{
    public string RegistrationNumber { get; set; }
    public string Make { get; set; }

    public Vehicle(string registrationNumber, string make)
    {
        RegistrationNumber = registrationNumber;
        Make = make;
    }

    // Derived classes can replace this method.
    public virtual void Describe()
    {
        Console.WriteLine($"{Make} vehicle - {RegistrationNumber}");
    }
}


// Car inherits from Vehicle.
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string registrationNumber, string make, int numberOfDoors)
        : base(registrationNumber, make)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Describe()
    {
        Console.WriteLine(
            $"Car: {Make} - {RegistrationNumber} - Doors: {NumberOfDoors}"
        );
    }
}


// Motorcycle also inherits from Vehicle.
public class Motorcycle : Vehicle
{
    public int EngineSize { get; set; }

    public Motorcycle(string registrationNumber, string make, int engineSize)
        : base(registrationNumber, make)
    {
        EngineSize = engineSize;
    }

    public override void Describe()
    {
        Console.WriteLine(
            $"Motorcycle: {Make} - {RegistrationNumber} - Engine: {EngineSize}cc"
        );
    }
}