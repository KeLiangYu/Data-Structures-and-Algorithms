using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            int mod;
            string tmp1, tmp2;
            Stack stack = new Stack();
            Stack stack1 = new Stack();

            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                mod = int.Parse(Console.ReadLine());

                string input = Console.ReadLine();
                Regex regex = new Regex("");
                string[] subinput = regex.Split(input);

                if (mod == 1)
                {
                    stack.Push("#");

                    for (int i = subinput.Length - 1; i > 0; i--)
                    {
                        switch (subinput[i])
                        {
                            case ")":              // 運算子堆疊
                                stack.Push(subinput[i]);
                                break;
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                                while (priority(Convert.ToString(stack.Peek())) > priority(subinput[i]))
                                {
                                    //Console.Write(Convert.ToString(stack.Pop()));
                                    stack1.Push(stack.Pop());
                                }
                                stack.Push(subinput[i]); // 存入堆疊 
                                break;
                            case "(":
                                while (Convert.ToString(stack.Peek()) != ")")
                                {
                                    stack1.Push(stack.Pop());
                                }
                                if (Convert.ToString(stack.Peek()) == ")") stack.Pop();
                                break;
                            default:
                                stack1.Push(subinput[i]);
                                break;
                        }
                    }
                    while (Convert.ToString(stack.Peek()) != "#")
                    {
                        //Console.Write(Convert.ToString(stack.Pop()));
                        stack1.Push(stack.Pop());
                    }
                    while (Convert.ToString(stack1.Peek()) != "")
                    {
                        Console.Write(Convert.ToString(stack1.Pop()));
                        //stack1.Push(stack.Pop());
                    }
                }
                else if (mod == 2)
                {
                    stack.Push("#");

                    for (int i = subinput.Length - 1; i > 0; i--)
                    {
                        switch (subinput[i])
                        {
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                                tmp1 = Convert.ToString(stack.Pop());
                                tmp2 = Convert.ToString(stack.Pop());
                                stack.Push("("+tmp1 + subinput[i] + tmp2+")"); // 存入堆疊 
                                break;
                            default:
                                stack.Push(subinput[i]);
                                break;
                        }
                    }
                    while (Convert.ToString(stack.Peek()) != "#")
                    {
                        Console.Write(Convert.ToString(stack.Pop()));
                    }
                }

                Console.WriteLine();
                t--;
            }
            Console.ReadLine();
        }
        public static int priority(string op)
        {
            switch (op)
            {
                case "+": case "-": return 1;
                case "*": case "/": return 2;
                default: return 0;
            }
        }
    }
}
