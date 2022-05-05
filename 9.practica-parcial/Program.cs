DateTime d1 = new DateTime(2022, 01, 23);
DateTime d2 = new DateTime(2022, 03, 16);

DateTime d3 = new DateTime(2022, 02, 15);
DateTime d4 = new DateTime(2022, 04, 27);

DateTime d5 = new DateTime(2022, 01, 30);
DateTime d6 = new DateTime(2022, 02, 13);

DateTime d7 = new DateTime(2022, 04, 29);
DateTime d8 = new DateTime(2022, 05, 04);

DateRange A = new DateRange(d1, d2);
DateRange B = new DateRange(d3, d4);
DateRange C = new DateRange(d5, d6);
DateRange D = new DateRange(d7, d8);

DateRange[] ranges = { A, B, C, D};

DateRangeUtils dateRangeUtil = new DateRangeUtils(ranges);
DateRange rangeUnion = dateRangeUtil.getRangeUnion();
Console.WriteLine("{0} - {1}", rangeUnion.Start.ToShortDateString(), rangeUnion.End.ToShortDateString());
