// See https://aka.ms/new-console-template for more information

using Exo4;
using Exo4.Business;
using Exo4.Output;

class Program
{
    static void Main(string[] args)
    {
        CsvFileInput input = new CsvFileInput();
        var result = input.parse("/home/chtitski_icha/RiderProjects/Exo4/Exo4/file/csv.txt");

        var operations = new Operation(args[0]);

        var addedNumbers = operations.process(result);

        var formattedResult = operations.format(result, addedNumbers);

        ConsoleOutput consoleOutput = new ConsoleOutput();
        consoleOutput.print(formattedResult);
        

        /*  for (int i = 0; i < result.Length; i++)
          {
              if (i == 0)
              {
                  Console.WriteLine(result[i]);
                  continue;
              }
              Console.WriteLine(args[0] + result[i] + "(=" +  addedNumbers[i-1]  + ")" );
          }*/

    }
}