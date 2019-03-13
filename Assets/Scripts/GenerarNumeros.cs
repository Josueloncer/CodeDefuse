using System.Collections;
using System.Collections.Generic;


public class GenerarNumeros
{
    private static System.Random rnd = new System.Random();

    public List<int> CreateRandomList(int min, int max, int count)
    {
        var result = new List<int>();

        for(var i= 0; i<count; i++)
        {

            int num;
            num = rnd.Next(min, max);
            result.Add(num);
        }
        return result;
    }
}
