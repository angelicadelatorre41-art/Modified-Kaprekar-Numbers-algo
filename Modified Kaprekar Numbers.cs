using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'kaprekarNumbers' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER p
     *  2. INTEGER q
     */

    public static void kaprekarNumbers(int p, int q)
    {
        bool found = false;
    
    for (long n = p; n <= q; n++)
    {
        long square = n * n;
        string str = square.ToString();
        int len = str.Length;
        string leftPart = str.Substring(0, len / 2);
        string rightPart = str.Substring(len / 2);

        long left = leftPart == "" ? 0 : long.Parse(leftPart);
        long right = long.Parse(rightPart);

        if (left + right == n)
        {
            Console.Write(n + " ");
            found = true;
        }
    }
    
    if (!found)
        Console.WriteLine("INVALID RANGE");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        Result.kaprekarNumbers(p, q);
    }
}
