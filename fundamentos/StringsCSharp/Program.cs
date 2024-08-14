public class Program
{
    public static void Main() 
    {
        //concatenando strings
        string textOne = "Você está aprendendo sobre ";
        string textTwo = "Strings em C#, ";
        string textThree = "e agora sabe concatenar textos utilizando a função Concat()!";
        string concatResult = string.Concat(textOne, textTwo, textThree);

        Console.WriteLine(concatResult);

        //separando string com Split
        string emails = "email1@trybe.com;email2@trybe.com;email3@trybe.com";
        string[] splittedEmails = emails.Split(';');

        foreach (string email in splittedEmails)
        {
            Console.WriteLine(email);
        }

        //encontrando letra por index 
        string trybe = "Trybe";
        int index = trybe.IndexOf("y");

        Console.WriteLine(index);

        //encontrando letra por index a partir de determinado index
        string trybe2 = "I love Trybe";
        int index2 = trybe2.IndexOf("e", 6);
        Console.WriteLine(index);

        List<string> languages = new List<string>
           {
           "c#",
           "java",
           "javascript",
           "python"
            };
        bool languageExists = languages.Contains("java");

        if (languageExists)
        {
            Console.WriteLine("A linguagem 'java' existe na lista!");
        }
        else
        {
            Console.WriteLine("A linguagem 'java' não existe na lista!");
        }

        //criaremos a string concatenando cada item dessa lista e separando-os por vírgula.
    IEnumerable<int> listNumbers = Enumerable.Range(1, 10);
    string numbersText = string.Join(',', listNumbers);
    Console.WriteLine(numbersText);
}

    }