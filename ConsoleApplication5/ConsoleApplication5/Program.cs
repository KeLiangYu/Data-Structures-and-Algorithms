using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            string i, j;

            t = int.Parse(Console.ReadLine());
            string[] pairI = new string[t];
            string[] pairJ = new string[t];

            string input = Console.ReadLine();
            Regex regex = new Regex(" ");
            string[] subinput = regex.Split(input);
            i = subinput[0];
            j = subinput[1];

            string[] first = new string[int.Parse(j)+1];
            int o = int.Parse(i);
            for (int k = int.Parse(i); k <= int.Parse(j); k++)
            {
                first[k] = o.ToString();
                o++;
            }
            /*for (int k = int.Parse(i); k <= int.Parse(j); k++)
            {
                Console.WriteLine(first[k]);
            }*/

            for (int k = 0; k < t; k++)
            {
                input = Console.ReadLine();
                regex = new Regex(" ");
                subinput = regex.Split(input);
                pairI[k] = subinput[0];
                pairJ[k] = subinput[1];
            }
            /*for (int k = 0; k < t; k++)
            {
                Console.Write(pairI[k]);
                Console.WriteLine(pairJ[k]);
            }*/

            for (int k = int.Parse(i); k <= int.Parse(j); k++)
            {
                while(k.ToString() == pairI[k-1])
                {

                }
            }
            Console.ReadLine();
        }
    }
}
