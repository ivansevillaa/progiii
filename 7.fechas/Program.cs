Tiempo tiempo = new Tiempo();

DateTime dt1 = new DateTime(2022, 04, 25);
DateTime dt2 = new DateTime(2022, 05, 2);

int diasCalendarios = tiempo.obtenerDiasCalendario(dt1, dt2);
int diasLaborales = tiempo.obtenerDiasLaborales(dt1, dt2);
DateTime diasLaboralesSumados = tiempo.sumarDiasLaborales(dt2, 10);

Console.WriteLine("{0} días calendario", diasCalendarios);
Console.WriteLine("{0} días laborales", diasLaborales);
Console.WriteLine("{0}", diasLaboralesSumados.ToShortDateString());
