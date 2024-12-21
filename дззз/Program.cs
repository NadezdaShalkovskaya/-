using System.Net.NetworkInformation;

class Program
{
    static void Main()
    {
      string input = "Пример строки";
        if (input.Length > 0)
        { 
            string result = " " +
                " " + input.Substring(1, input.Length - 2) + ".";
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Строка пуста");
        }
    } 
}
   
