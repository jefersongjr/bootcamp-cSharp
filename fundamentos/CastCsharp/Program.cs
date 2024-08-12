// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        int someIntNumber = 51;
        long longNumberCast = someIntNumber; //cast implicito - transformar um int em um long automaticamente
        Console.WriteLine(longNumberCast);

        //transforma em inteiro automaticamente mas temos perda de resultado; int = 2; 
        int intResult = 5/2;
        Console.WriteLine(intResult);
        
        //Cast Explicito 

        long someLongNumber = 516144066604654;
        int intNumber = (int) someLongNumber;

        Console.WriteLine(intNumber);

        //gera um erro pq o numero não pode ser convertido para inteiro
        // long anotherSomeLongNumber = 516144564564654;
        // int anotherIntNumber = Convert.ToInt32(anotherSomeLongNumber);
        // Console.WriteLine(anotherIntNumber);

        long anotherSomeLongNumber = 42;
        int anotherIntNumber = Convert.ToInt32(anotherSomeLongNumber);

        Console.WriteLine(anotherIntNumber);


        //cast string para número:

        string someString = "42";
        int convertInt = Convert.ToInt32(someString);

        Console.WriteLine(convertInt);
        
        //tenta fazer a conversão caso possivel 
        // bool canConvert = Int32.TryParse(userEntry, out valueConverted)
    }
}
