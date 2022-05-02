public class DateRange {
  private DateTime start;
  private DateTime end;

  public DateTime Start {
    get => start;
  }

  public DateTime End {
    get => end;
  }

  public DateRange (DateTime start, DateTime end) {
    this.start = start;
    this.end = end;
  }
}
