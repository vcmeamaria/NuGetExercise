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