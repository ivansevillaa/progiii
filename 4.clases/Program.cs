Console.WriteLine("Ingresá el número que crees que va a salir: ");
int apuesta = int.Parse(Console.ReadLine());

if (apuesta < 1 || apuesta > 6) {
  Console.WriteLine("Ese número no existe en el dado 🙄");
} else {
  Dado dado = new Dado(apuesta);
  dado.lanzar();
}
