using System.Collections;

public class Biblioteca : IEnumerable
{
  private ArrayList arrLibros = new ArrayList();

  public Libro GetLibro(int pos) {
    return (Libro)arrLibros[pos];
  }

  public void AddLibro(Libro libro) {
    arrLibros.Add(libro);
  }

  public int Contar() {
    return arrLibros.Count;
  }

  public IEnumerator GetEnumerator()
  {
    return arrLibros.GetEnumerator();
  }
}
