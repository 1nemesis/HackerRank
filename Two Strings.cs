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

    // Complete the twoStrings function below.
    static string twoStrings(string s1, string s2)
    {
        List<char> li = new List<char>();
        for (int i = 0; i < s1.Length; i++)
        {
            if (li.Contains(s1[i]) == false)
                li.Add(s1[i]);
        }
        for (int i = 0; i < s2.Length; i++)
        {
            if (li.Contains(s2[i]))
                return "YES";
        }
        return "NO";
    }

    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            string result = twoStrings(s1, s2);

            Console.WriteLine(result);
        }
    }
}
