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
    static int Hourglass(int[][] arr)
    {

        int b = 0;
        int[][,] hg = new int[16][,];
        for (int f = 0; f < 16; f++)
        {
            hg[f] = new int[3, 3];
        }
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    hg[i][j, k] = arr[j + (i % 4)][k + (i / 4)];
                }
            }
        }



        for (int l = 0; l < 16; l++)
        {
            int a = 0;
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {

                    if (m == 1 && n == 0)
                    {
                        continue;
                    }
                    else if (m == 1 && n == 2)
                    {
                        continue;
                    }
                    a += hg[l][m, n];
                    if (l == 0)
                    {
                        b = a;
                    }
                }
            }
            if (a > b)
            {
                b = a;
            }
        }

        return b;
    }



    static void Main(string[] args)
    {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int result = Hourglass(arr);
        Console.WriteLine(result);
    }
}
