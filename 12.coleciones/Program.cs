// Libro[] biblioteca = { new Libro("Maxi", "Hola"), new Libro("Mati", "Chau"), new Libro("Juan", "Jeje") };
Biblioteca biblioteca = new Biblioteca();

biblioteca.AddLibro(new Libro("Maxi", "Hola"));
biblioteca.AddLibro(new Libro("Franco", "Chau"));

Console.WriteLine(biblioteca.Contar());
