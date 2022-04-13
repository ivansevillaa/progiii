// See https://aka.ms/new-console-template for more information
// Calcular la media y la desviación estándar de un conjunto de 10 personas.

// Tome por teclado la altura en cm de cada persona y cárguela en un arreglo.
int[] alturaPersonas = new int[10];
double[] diferenciasConLaMedia = new double[10];
int total = 0;
double totalDiferenciasConLaMedia = 0;
double media = 0;
double varianza = 0;
double desviacionEstandar = 0;

for (int i = 0; i < alturaPersonas.Length; i++) {
  Console.WriteLine($"Ingrese la altura de la persona {i + 1} en cm:");
  alturaPersonas[i] = int.Parse(Console.ReadLine());
  total += alturaPersonas[i];
}

media = total / alturaPersonas.Length;

for (int i = 0; i < alturaPersonas.Length; i++) {
  diferenciasConLaMedia[i] = Math.Pow(alturaPersonas[i] - media, 2);
  totalDiferenciasConLaMedia += diferenciasConLaMedia[i];
}

varianza = totalDiferenciasConLaMedia / diferenciasConLaMedia.Length;
desviacionEstandar = Math.Sqrt(varianza);

// Presente los resultados obtenidos.
Console.WriteLine("Los resultados obtenidos son");
Console.WriteLine($"Media: {media}");
Console.WriteLine($"Desviación estándar: {desviacionEstandar}");

// Muestre qué alturas se encuentran por encima de la media y por debajo de ella.
Console.WriteLine("Las alturas que se encuentran por encima de la media son:");
for (int i = 0; i < alturaPersonas.Length; i++) {
  if (alturaPersonas[i] > media) {
    Console.Write($"{alturaPersonas[i]}, ");
  }
}
Console.WriteLine("\nLas alturas que se encuentran por debajo de la media son:");
for (int i = 0; i < alturaPersonas.Length; i++) {
  if (alturaPersonas[i] < media) {
    Console.Write($"{alturaPersonas[i]}, ");
  }
}
// Muestre qué alturas se encuentran dentro del rango definido por la desviación estándar.
Console.WriteLine("\nLas alturas que se encuentran dentro del rango definido por la desviación estándar son:");
for (int i = 0; i < alturaPersonas.Length; i++) {
  if (alturaPersonas[i] > media - desviacionEstandar && alturaPersonas[i] < media + desviacionEstandar ) {
    Console.Write($"{alturaPersonas[i]}, ");
  }
}
