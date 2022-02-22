using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace puzzle5part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\1\\Desktop\\noamis.txt";
            string[] readText = File.ReadAllLines(path, Encoding.UTF8);
            int count = 0;
            foreach (string s in readText)
            {
                bool flag1 = false;
                bool flag2 = false;
                for (int i = 0; i < s.Length - 2; i++)
                {
                    if (s[i]  == s[i + 2])
                        flag2 = true;
                    string str = string.Concat(s[i], s[i + 1]);
                    for (int j=i+2; j<s.Length-1; j++)
                    {
                        string str1 = string.Concat(s[j], s[j + 1]);
                        if (str == str1)
                            flag1 = true;
                    }


                }
                if (flag1 == true && flag2 == true)
                    count++;
            }

            Console.WriteLine(count);




        }
    }
}
