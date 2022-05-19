public class Libro : IColeccionable, IComparable {
  private string autor;
  private string titulo;

  public Libro(string autor, string titulo) {
    this.autor = autor;
    this.titulo = titulo;
  }

  public string Titulo {
    get { return titulo; }
  }

  public int CompareTo(object obj)
  {
      if (obj is Libro) {
        Libro libro1 = (Libro)obj;
        return String.Compare(this.titulo, libro1.Titulo);
      }

      return 0;
  }

  public string Describir() {
    return titulo;
  }
}
