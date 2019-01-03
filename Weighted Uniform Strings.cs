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
    static string[] weightedUniformStrings(string s, int[] queries)
    {
        List<int> weights = new List<int>();
        string[] results = new string[queries.Length];
        int a = 0;
        int b = 0;
        weights.Add((char)(s[0]) - 96);
        a = (char)(s[0]) - 96;
        b = (char)(s[0]) - 96;
        for (int i = 1; i < s.Length; i++)
        {
            if ((char)(s[i]) - 96 == b)
            {
                a += (char)(s[i]) - 96;
                weights.Add(a);
            }
            else
            {
                b = (char)(s[i]) - 96;
                a = (char)(s[i]) - 96;
                weights.Add(a);
            }

        }
        weights.Sort();
        for (int i = 0; i < queries.Length; i++)
        {
            if (weights.BinarySearch(queries[i]) >= 0)
            {
                results[i] = "Yes";
            }
            else
            {
                results[i] = "No";
            }
        }
        return results;
    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        int[] queries = new int[queriesCount];

        for (int i = 0; i < queriesCount; i++)
        {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        string[] result = weightedUniformStrings(s, queries);

        Console.WriteLine(string.Join("\n", result));
    }
}
