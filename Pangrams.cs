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

class Solution
{

    // Complete the pangrams function below.
    static string pangrams(string s)
    {
        List<int> ch = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            if ((char)(s[i]) < 97)
            {
                if (ch.Contains((char)(s[i]) + 32) == false)
                {
                    ch.Add((char)(s[i]) + 32);
                }
            }
            else
            {
                if (ch.Contains((char)(s[i])) == false)
                    ch.Add((char)(s[i]));
            }
        }
        if (ch.Count == 26)
            return "pangram";
        return "not pangram";

    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        string result = pangrams(s);

        Console.WriteLine(result);
    }
}
