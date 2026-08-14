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