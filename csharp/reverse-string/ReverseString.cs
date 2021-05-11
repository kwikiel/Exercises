using System;
using System.Collections.Generic;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] inputPieces = input.ToCharArray();
        Array.Reverse(inputPieces);

        string output = new string(inputPieces);
        return output;

    }
}