public class Tiempo {
  public int obtenerDiasCalendario(DateTime fecha1, DateTime fecha2) {
    TimeSpan dif = fecha1 - fecha2;
    return Math.Abs(dif.Days);
  }

  public int obtenerDiasLaborales(DateTime fecha1, DateTime fecha2) {
    int diasLaborales = 0;

    while (fecha1 < fecha2) {
      if (!(fecha1.DayOfWeek == DayOfWeek.Saturday || fecha1.DayOfWeek == DayOfWeek.Sunday)) {
        diasLaborales += 1;
      }

      fecha1 = fecha1.AddDays(1);
    }

    return diasLaborales;
  }

  public DateTime sumarDiasLaborales(DateTime fecha1, int diasASumar) {
    int diasLaboralesSumados = 0;

    while (diasLaboralesSumados <= diasASumar) {
      if (!(fecha1.AddDays(1).DayOfWeek == DayOfWeek.Saturday || fecha1.AddDays(1).DayOfWeek == DayOfWeek.Sunday)) {
        diasLaboralesSumados += 1;
      }

      fecha1 = fecha1.AddDays(1);
    }


    return fecha1;
  }
}
