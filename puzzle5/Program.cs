using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace puzzle5
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
                bool flag2 = true;
                int countpnim = 0;
                char lastCharacter = s[s.Length - 1];
                if (lastCharacter == 'a' || lastCharacter == 'e' || lastCharacter == 'u' ||
                    lastCharacter == 'i' || lastCharacter == 'o')
                    countpnim++;
                for (int i = 0; i < s.Length-1; i++)
                {
                    
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'u' || s[i] == 'i' || s[i] == 'o')
                        countpnim++;

                    if (s[i] == s[i + 1])
                        flag1 = true;
                    var str = string.Concat(s[i], s[i + 1]);
                    if (str == "ab" || str == "cd" || str == "pq" || str == "xy")
                        flag2 = false;

                }
                if ((countpnim >= 3) && (flag1 == true) && (flag2 == true))
                    count++;

            }

            Console.WriteLine(count);




        }
    }
}
