using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        char[] charArr = phoneNumber.ToCharArray();

        var c2 = charArr.Where(x => Char.IsDigit(x)).Select(x => x);
       

        return String.Join("", c2.Select(p => p.ToString()).ToArray());
    }
}