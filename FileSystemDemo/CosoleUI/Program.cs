// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your age: ?");
string ageText = Console.ReadLine();

bool isValid = int.TryParse(ageText, out int age);

Console.WriteLine($"Your age is {age}");


