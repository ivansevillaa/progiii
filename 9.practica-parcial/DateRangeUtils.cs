public class DateRangeUtils {
  private DateRange[] dateRangeAray; 

  public DateRangeUtils(params DateRange[] arr) {
    this.dateRangeAray = arr;
  }

  public DateRange getRangeUnion() {
    DateTime unionStart = new DateTime(9999, 12, 31);
    DateTime auxStart;

    DateTime unionEnd = new DateTime(0001, 01, 01);
    DateTime auxEnd;

    for (int i = 0; i < dateRangeAray.Length; i++) {
      for (int j = 0; j < dateRangeAray.Length; j++) {
        DateTime startI = dateRangeAray[i].Start;
        DateTime startJ = dateRangeAray[j].Start;
        TimeSpan difStarts = startI - startJ;
        auxStart = difStarts.Days < 0 ? startI : startJ;
        unionStart = (unionStart - auxStart).Days < 0 ? unionStart : auxStart;

        DateTime endI = dateRangeAray[i].End;
        DateTime endJ = dateRangeAray[j].End;
        TimeSpan difEnds = endI - endJ;
        auxEnd = difEnds.Days > 0 ? endI : endJ;
        unionEnd = (unionEnd - auxEnd).Days > 0 ? unionEnd : auxEnd;
      }
    }

    return new DateRange(unionStart, unionEnd);
  }
}
