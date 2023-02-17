using System.Reflection.Metadata;

namespace Exo4.Business;

public class Operation
{
    private string sign;

    public Operation(string sign)
    {
        this.sign = sign;
    }

    public int[] process(string[] numbers)
    {
        if (sign != "+")
        {
            return new int[] { };
        }


        var numbersint = new List<int>();
        var addedNumbers = new List<int>();

        foreach (var VARIABLE in numbers)
        {

            numbersint.Add(int.Parse(VARIABLE));
        }


        for (int i = 1; i < numbers.Length; i++)
        {
            var tmp = numbersint[i] + numbersint[i - 1];
            addedNumbers.Add(tmp);

        }

        return addedNumbers.ToArray();
    }
    
    
    public string format(string[] numbers,int[] addedNumbers)
    {
        string result = "";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                result += numbers[i];
                result += "\n";
                continue;
            }
            result += sign + numbers[i] + "(=" +  addedNumbers[i-1]  + ")" + "\n";
        }

        var numbersInt = Array.ConvertAll(numbers, int.Parse);



        result += "---------" + "\n" + "total = " + numbersInt.ToList().Sum();
        return result;
    }
}