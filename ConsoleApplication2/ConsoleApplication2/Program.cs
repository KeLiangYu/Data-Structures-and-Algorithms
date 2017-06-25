using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, k;
            int i, j;
            int t1, t2;
            int[,] board = new int[8, 8];
            int[] ktmov1 = new int[8];
            int[] ktmov2 = new int[8];

            ktmov1[0] = -2; ktmov2[0] = 1;
            ktmov1[1] = -1; ktmov2[1] = 2;
            ktmov1[2] = 1; ktmov2[2] = 2;
            ktmov1[3] = 2; ktmov2[3] = 1;
            ktmov1[4] = 2; ktmov2[4] = -1;
            ktmov1[5] = 1; ktmov2[5] = -2;
            ktmov1[6] = -1; ktmov2[6] = -2;
            ktmov1[7] = -2; ktmov2[7] = -1;

            t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        board[x, y] = 0;
                    }
                }

                Console.WriteLine("請輸入Knight的起始位置：");

                string input = Console.ReadLine();
                String[] value = input.Split(' ');
                i = int.Parse(value[0]);
                j = int.Parse(value[1]);
                t1 = i;
                t2 = j;

                int[] nexti = new int[8];
                int[] nextj = new int[8];

                board[i, j] = 0;

                for (k = 1; k < 64; k++)
                {
                    int[] count = new int[8];
                    int[] exists = new int[8];
                    //int count = 0;
                    for (int z = 0; z < 8; z++)
                    {
                        nexti[z] = i + ktmov1[z];
                        nextj[z] = j + ktmov2[z];
                        if (0 <= nexti[z] && nexti[z] <= 7 && 0 <= nextj[z] && nextj[z] <= 7 && board[nexti[z], nextj[z]] == 0 && !(nexti[z] == t1 && nextj[z] == t2))
                        {
                            count[z] = 1;

                            for (int f = 0; f < 8; f++)
                            {
                                int tmpi = nexti[z] + ktmov1[f];
                                int tmpj = nextj[z] + ktmov2[f];

                                if (0 <= tmpi && tmpi <= 7 && 0 <= tmpj && tmpj <= 7 && board[tmpi, tmpj] == 0 && !(tmpi == t1 && tmpj == t2))
                                {
                                    exists[z]++;
                                }
                            }

                        }
                    }
                    
                    int tmp = 8; int p = 0;
                    for (int l = 0; l < 8; l++)
                    {
                        if(k!=63)
                        {
                            if (exists[l] < tmp && count[l] == 1 && exists[l] != 0)
                            {
                                tmp = exists[l];
                                p = l;
                            }
                        }
                        else
                        {
                            if (exists[l] < tmp && count[l] == 1)
                            {
                                tmp = exists[l];
                                p = l;
                            }
                        }                        
                    }
                    
                    i = nexti[p];
                    j = nextj[p];
                    board[i, j] = k;
                }
                
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        if (y == 7) Console.Write("{0}\n", board[x, y]);
                        else Console.Write("{0} ", board[x, y]);
                    }
                }
                t--;
            }
            Console.ReadLine();
        }
    }
}
