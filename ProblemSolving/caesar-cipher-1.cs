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

    // Complete the caesarCipher function below.
    static string caesarCipher(string s, int k) {
        string res = "";
        for(int i = 0 ; i < s.Length ; i++ )
        {
            if (s[i]<='z' && s[i]>='a')
            {
                res += (char)('a'+ (s[i]-'a' + k)% 26 );
            }
            else if (s[i]<='Z' && s[i]>='A')
            {
                res += (char)('A'+ (s[i]-'A' + k)% 26 );
            }
            else
            {
                res += s[i];
                System.Console.WriteLine(s[i]);
            }
        }
        return res;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
