// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un texto:");
string str = Console.ReadLine();

if (str == "") {
  Console.WriteLine("No puede estar vacío");
} else {
  Console.WriteLine("Elija una opción");
  Console.WriteLine("1. Texto en mayuscula");
  Console.WriteLine("2. Texto en minuscula");
  Console.WriteLine("3. Texto original");
  
  ConsoleKeyInfo opcion = Console.ReadKey();

  if (opcion.Key == ConsoleKey.D1 || opcion.Key == ConsoleKey.NumPad1) {
    Console.WriteLine("\nTexto en mayuscula");
    Console.WriteLine(str.ToUpper());
  }

  if (opcion.Key == ConsoleKey.D2 || opcion.Key == ConsoleKey.NumPad2) {
    Console.WriteLine("\nTexto en minuscula");
    Console.WriteLine(str.ToLower());
  }

  if (opcion.Key == ConsoleKey.D3 || opcion.Key == ConsoleKey.NumPad3) {
    Console.WriteLine("\nTexto original");
    Console.WriteLine(str);
  }
}
