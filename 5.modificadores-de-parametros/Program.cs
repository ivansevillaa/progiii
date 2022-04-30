using System;

namespace MyApp {
  internal class Program {
    static void Main(string[] args) {
      int moda = 0, valorMinimo = 0, valorMaximo = 0;

      Moda(out moda, out valorMinimo, out valorMaximo, 3, 7, 5, 13, 20, 23, 39, 23, 40, 23, 14, 12, 56, 23, 29);
      Console.WriteLine("La moda es {0}", moda);
      Console.WriteLine("El valor minimo es {0}", valorMinimo);
      Console.WriteLine("El valor maximo es {0}", valorMaximo);
    }

    static void Moda(
      out int moda,
      out int valorMinimo,
      out int valorMaximo,
      params int[] valores
    ) {
      int maxVeces = 0, modaAux = 0, minAux = 99999, maxAux = 0;

      for (int i = 0; i < valores.Length; i++) {
        int numActualVeces = 0;

        for (int j = 0; j < valores.Length; j++) {
          if (valores[i] == valores[j]) {
            numActualVeces += 1;
          }
        }

        if (numActualVeces > maxVeces) {
          maxVeces = numActualVeces;
          modaAux = valores[i];
        }

        if (valores[i] > maxAux) {
          maxAux = valores[i];
        }

        if (valores[i] < minAux) {
          minAux = valores[i];
        }
      }

      moda = modaAux;
      valorMinimo = minAux;
      valorMaximo = maxAux;
    }
  }
}
