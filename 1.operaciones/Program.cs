// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa 1 numero:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresa otro numero:");
int b = int.Parse(Console.ReadLine());
// int b = int.TryParse(Console.ReadLine()); investigar como usar TryParse

Console.WriteLine($"La suma da: {a + b}");
Console.WriteLine($"La resta da: {a - b}");
Console.WriteLine($"La multiplicación da: {a * b}");
Console.WriteLine($"La división da: {a / b}");
