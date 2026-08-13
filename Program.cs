using Newtonsoft.Json;

var student = new
{
    Name = "Maria",
    Course = "Cyber Security"
};

string json = JsonConvert.SerializeObject(student, Formatting.Indented);

Console.WriteLine("Student as JSON:");
Console.WriteLine();
Console.WriteLine(json);