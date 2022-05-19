Libro[] biblioteca = { new Libro("Maxi", "Hola"), new Libro("Mati", "Chau"), new Libro("Juan", "Jeje") };

for (int i = 0; i < biblioteca.Length; i++) {
  Array.Sort(biblioteca);
}

for (int i = 0; i < biblioteca.Length; i++) {
  Console.WriteLine(biblioteca[i].Describir());
}
