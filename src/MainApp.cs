using System; // no longer needed in .NET Core

public class MainApp
{
    static public void Main(string[] args)
    {
        foreach (string arg in args)
        {
            int num;
            if (int.TryParse(arg, out num))
            {
                var contains3 = arg.Contains("3");
                if (num % 3 == 0)
                {
                    Console.WriteLine(contains3 ? "dumb" : "idiot");
                }
                else
                {
                    Console.WriteLine(contains3 ? "stupid" : "smart");
                }
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
