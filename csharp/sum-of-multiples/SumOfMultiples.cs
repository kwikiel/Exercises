using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> m = new HashSet<int>();

        foreach (int num in multiples)
        {
            // Case if num is zero 
            if (num == 0)
            {
                continue;
            }
            int i = 1;
            while (num * i < max)
            {
                if (num * i < max)
                {
                    m.Add(num * i);
                }
                i++;
            }
        }
        var total = m.Sum();
        return total;
    }
}