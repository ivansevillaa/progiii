DateTime dt1 = new DateTime(2022, 05, 01);
DateTime dt2 = new DateTime(2022, 06, 25);
DateRange range1 = new DateRange(dt1, dt2);

DateTime dt3 = new DateTime(2022, 04, 15);
DateTime dt4 = new DateTime(2022, 05, 30);
DateRange range2 = new DateRange(dt3, dt4);

Console.WriteLine("Initials ranges:");
Console.WriteLine("Range 1: {0} - {1}", range1.Start.ToShortDateString(), range1.End.ToShortDateString());
Console.WriteLine("Range 2: {0} - {1}", range2.Start.ToShortDateString(), range2.End.ToShortDateString());

DateRange union = getUnion(range1, range2);
Console.WriteLine("Union: {0} - {1}", union.Start.ToShortDateString(), union.End.ToShortDateString());

DateRange intersection = getIntersection(range1, range2);
Console.WriteLine("Intersection: {0} - {1}", intersection.Start.ToShortDateString(), intersection.End.ToShortDateString());

static DateRange getUnion (DateRange range1, DateRange range2) {
  TimeSpan startDif = range1.Start - range2.Start;
  TimeSpan endDif = range1.End - range2.End;

  DateTime resultStart = startDif.Days > 0 ? range2.Start : range1.Start;
  DateTime resultEnd = endDif.Days > 0 ? range1.End : range2.End;

  return new DateRange(resultStart, resultEnd);
}

static DateRange getIntersection (DateRange range1, DateRange range2) {
  TimeSpan startDif = range1.Start - range2.Start;
  TimeSpan endDif = range1.End - range2.End;

  DateTime resultStart = startDif.Days > 0 ? range1.Start : range2.Start;
  DateTime resultEnd = endDif.Days > 0 ? range2.End : range1.End;

  return new DateRange(resultStart, resultEnd);
}
