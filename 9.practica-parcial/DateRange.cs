public class DateRange {
  private DateTime start;
  private DateTime end;
  private TimeSpan duration;

  public DateRange(DateTime start, DateTime end) {
    this.start = start;
    this.end = end;
    this.duration = end - start;
  }

  public DateTime Start {
    get => start;
  }

  public DateTime End {
    get => end;
  }

  public TimeSpan Duration {
    get => duration;
  } 
}
