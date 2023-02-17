namespace Exo4.Output;

public class ConsoleOutput:IOutput
{

    public void print(string value)
    {
        Console.WriteLine(value);
    }

}