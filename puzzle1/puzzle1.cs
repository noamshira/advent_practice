using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace targil1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            StreamReader reader = new StreamReader("C:\\Users\\1\\Downloads\\input.txt");

            string file = reader.ReadToEnd();
            // Console.WriteLine(line);
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == '(')
                    count++;
                else
                    count--;
                if (count == -1)
                {
                    Console.WriteLine(i + 1);
                    break;


                }

            }


            reader.Close();







        }
    }
}
