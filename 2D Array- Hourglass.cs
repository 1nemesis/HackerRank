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

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        int a = Int32.MinValue;
        for (int i =0; i<16; i++)
        {
                int b =0;
                for (int k=0; k<3; k++)
                {
                    for (int l=0; l<3; l++)
                    {
                        if (k==1 && l==0)
                        continue;
                        if (k==1 && l==2)
                        continue;
                        b+=arr[i/4 + k][i%4 + l];
                    }
                }
                if (b>a)
                a=b;
        }
        return a;


    }

    static void Main(string[] args) {
        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        Console.WriteLine(result);
    }
}
