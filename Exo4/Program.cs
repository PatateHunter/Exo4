// See https://aka.ms/new-console-template for more information

using Exo4;
using Exo4.Business;
using Exo4.Output;

class Program
{
    static void Main(string[] args)
    {
        // manque de temps, c'est sommaire
        CsvFileInput input = new CsvFileInput();
        var result = input.parse("/home/chtitski_icha/RiderProjects/Exo4/Exo4/file/csv.txt");

        var operations = new Operation(args[0]);

        var addedNumbers = operations.process(result);

        var formattedResult = operations.format(result, addedNumbers);

        ConsoleOutput consoleOutput = new ConsoleOutput();
        consoleOutput.print(formattedResult);
        
        
    }
}