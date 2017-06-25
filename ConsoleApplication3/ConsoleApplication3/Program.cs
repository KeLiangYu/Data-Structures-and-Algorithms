using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            int i, j;
            int x, y, dir;

            Path p = new Path();
            Stack stack = new Stack();

            int[] x1 = new int[100];
            int[] y1 = new int[100];

            int[] move1 = new int[8];
            int[] move2 = new int[8];

            move1[0] = -1; move2[0] = 0;
            move1[1] = -1; move2[1] = 1;
            move1[2] = 0; move2[2] = 1;
            move1[3] = 1; move2[3] = 1;
            move1[4] = 1; move2[4] = 0;
            move1[5] = 1; move2[5] = -1;
            move1[6] = 0; move2[6] = -1;
            move1[7] = -1; move2[7] = -1;

            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                Console.WriteLine("請輸入迷宮大小 ROW COL：");

                string input = Console.ReadLine();
                String[] value = input.Split(' ');
                i = int.Parse(value[0]);
                j = int.Parse(value[1]);

                int[,] maze = new int[i,j];

                Console.WriteLine("請輸入迷宮的資料：");

                for (int t1 = 0; t1 < i; t1++)
                {
                    input = Console.ReadLine();
                    value = input.Split(' ');
                    for (int t2 = 0; t2 < j; t2++)
                    {
                        maze[t1,t2]= int.Parse(value[t2]);
                    }
                    Console.WriteLine();
                }

                int[,] mark = new int[i,j];
                
                Path temp = new Path();

                x = 1; y = 1;

                while (!(x == i && y == j))
                {
                    dir = 0;
                    while (dir < 8)
                    {
                        int tmpi = x + move1[dir];
                        int tmpj = y + move2[dir];
                        if (tmpi <= i && tmpi > 0 && tmpj <= j && tmpj > 0 && maze[tmpi - 1, tmpj - 1] != 1 && mark[tmpi - 1, tmpj - 1] != 1)
                        {
                            mark[x - 1, y - 1] = 1;

                            temp.X = x;
                            temp.Y = y;
                            temp.Direction = dir;

                            stack.Push(temp);

                            x = tmpi;
                            y = tmpj;
                            
                            break;
                        }
                        dir++;
                    }
                    if (dir == 8)
                    {
                        if (stack.Count > 0)
                        {
                            p = (Path)stack.Pop();

                            maze[x - 1, y - 1] = 1;

                            x = p.X;
                            y = p.Y;
                        }
                        else
                        {
                            Console.WriteLine("888 888");
                            break;
                        }
                    }
                }
                if(stack.Count!=0)
                {
                    dir = stack.Count;
                    while (stack.Count != 0)
                    {
                        p = (Path)stack.Pop();
                        x1[stack.Count] = p.X;
                        y1[stack.Count] = p.Y;
                    }

                    x1[dir] = i;
                    y1[dir] = j;
                    for (int tt = 0; tt <= dir; tt++)
                    {
                        Console.WriteLine("{0} {1}", x1[tt], y1[tt]);
                    }
                }
                
                Console.WriteLine("999 999");
                t--;
            }
            Console.ReadLine();
        }
    }
    public struct Path
    {
        public int X;
        public int Y;
        public int Direction;
    }
}

