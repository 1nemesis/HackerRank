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

    // Complete the cavityMap function below.
    static string[] cavityMap(string[] grid) {
        
        for (int i=1; i<grid.Length-1; i++)
        {
            for (int j=1; j<grid.Length-1; j++)
            {
                StringBuilder s =new StringBuilder(grid[i]);
                StringBuilder su =new StringBuilder(grid[i-1]);
                StringBuilder sd =new StringBuilder(grid[i+1]);
                
                    if(Convert.ToInt32(s[j])>Convert.ToInt32(s[j-1]) && Convert.ToInt32(s[j])>Convert.ToInt32(s[j+1]) && Convert.ToInt32(s[j])>Convert.ToInt32(su[j]) &&Convert.ToInt32(s[j])>Convert.ToInt32(sd[j]))
                    s[j]='X';
                
                grid[i]=s.ToString();
            }
        }
        return grid;


    }

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        string[] grid = new string [n];

        for (int i = 0; i < n; i++) {
            string gridItem = Console.ReadLine();
            grid[i] = gridItem;
        }

        string[] result = cavityMap(grid);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
