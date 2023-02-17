namespace Exo4;

public class CsvFileInput : IInput
{
    public string[] parse(string filename)
    {
        string[] result;
        // read a file with a name
        using (StreamReader streamReader = File.OpenText(filename))
        {
            string text = streamReader.ReadToEnd();
            result = text.Split(Environment.NewLine);
            
        }

        return result;
    }


}