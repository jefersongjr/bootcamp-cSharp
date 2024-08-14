public class Program
{
    public static void Main()
    {
      var dataType = DateTime.Now;
      Console.WriteLine(dataType.GetType());
      //data de agora
      Console.WriteLine($"a data de hoje é {dataType}");

      // Instanciando uma data
      var date = new DateTime(2022, 10, 2, 8, 35, 0);
      var dateOnly = date.Date;
      var dayOnly = date.Day;
      var monthOnly = date.Month;
      var yearOnly = date.Year;


      Console.WriteLine(dateOnly.ToString());
      Console.WriteLine(dayOnly.ToString());
      Console.WriteLine(monthOnly.ToString() + "/" + yearOnly.ToString());

      var today = DateTime.Now;
      Console.WriteLine(today.ToString());

      //Adiciona 36 dias a data atual    
      var answer = today.AddDays(36);

      Console.WriteLine(answer.ToString());

      /*
    .AddYears(int value): Adiciona uma quantidade de anos a uma data.
    .AddMonths(int value): Adiciona uma quantidade de meses a uma data.
    .AddDays(double value): Adiciona uma quantidade de dias a uma data.
    .AddHours(double value): Adiciona uma quantidade de horas a uma data.
    .AddMinutes(double value): Adiciona uma quantidade de minutos a uma data.
    .AddSeconds(double value): Adiciona uma quantidade de segundos a uma data.
    .AddMilliseconds(double value): Adiciona uma quantidade de milissegundos a uma data.
    .AddTicks(long value): Adiciona uma quantidade de ticks a uma data.
    */

    DateTime lastDate = new DateTime(2010, 9, 1, 5, 0, 0);
    Console.WriteLine("A data é " +lastDate.ToString("D"));

    /* 
    “d” 	6/15/2008
    “D” 	Sunday, June 15, 2008
    “f” 	Sunday, June 15, 2008 9:15 PM
    “F” 	Sunday, June 15, 2008 9:15:07 PM
    “g” 	6/15/2008 9:15 PM
    “G” 	6/15/2008 9:15:07 PM
    “m” 	June 15
    “o” 	2008-06-15T21:15:07.0000000
    “R” 	Sun, 15 Jun 2008 21:15:07 GMT
    “s” 	2008-06-15T21:15:07
    “t” 	9:15 PM
    “T” 	9:15:07 PM
    “u” 	2008-06-15 21:15:07Z
    “U” 	Monday, June 16, 2008 4:15:07 AM
    “y” 	June, 2008  */

    }

}