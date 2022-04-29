public class Dado {
  private Random random = new Random();
  private int numero;
  private int apuesta;
  
  public Dado(int apuesta) {
    this.apuesta = apuesta;
  }

  public void lanzar() {
    this.numero = random.Next(1, 7);

    Console.WriteLine("El número que salió es: {0}", this.numero);
  
    if (this.apuesta == this.numero) {
      Console.WriteLine("GANASTE! 🥳");
    } else {
      Console.WriteLine("PERDISTE! 🙄");
    }
  }
}
