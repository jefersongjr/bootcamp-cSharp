using System;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            InitialGreeting();
            int year = Convert.ToInt32(Console.ReadLine());
            var age = CalculateAgeByYear(year);
            Console.WriteLine("Idade: " + age);
            CheckAge(age);
        }
        catch (AccessViolationException err)
        {
            Console.WriteLine("Erro de permissão: " + err.Message);
        }
        catch (Exception err)
        {
            Console.WriteLine("Erro: " + err.Message);
        }
        finally //sempre executado
        {
            Console.WriteLine("Fim do software");
        }
    }

    public static void InitialGreeting()
    {
        Console.WriteLine("Bem-vindo! Por favor, insira o ano do seu nascimento:");
    }

    public static int CalculateAgeByYear(int year)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - year;
    }

    public static void CheckAge(int age)
    {
        if (age >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
