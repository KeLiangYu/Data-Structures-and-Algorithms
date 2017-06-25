using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n, k;
            string data;

            Console.Write("請輸入盤數：");
            data = Console.ReadLine();
            n = System.Convert.ToInt32(data);
            k = n;
            int[] A = new int[n + 1];
            int[] B = new int[n + 1];
            int[] C = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                A[i] = i + 1;
            }
            A[n] = 1;
            B[n] = 2;
            C[n] = 3;

            Console.Write("A(");
            for (int i = 0; i < k; i++)
            {
                if (i == 0) Console.Write(A[i]);
                else Console.Write(",{0}", A[i]);
            }
            Console.Write(")B()C()\n");

            hanoi(n, A, B, C, k);
            Console.ReadLine();
        }
        public static void hanoi(int n, int[] A, int[] B, int[] C, int k)
        {
            if (n == 1)
            {
                int temp = A[n - 1];
                A[n - 1] = C[n - 1];
                C[n - 1] = temp;

                ABC(k, A, B, C);
            }
            else
            {
                hanoi(n - 1, A, C, B, k);

                int temp = A[n - 1];
                A[n - 1] = C[n - 1];
                C[n - 1] = temp;

                ABC(k, A, B, C);

                hanoi(n - 1, B, A, C, k);
            }
        }
        public static void ABC(int k, int[] A, int[] B, int[] C)
        {
            int t = 0;
            if (A[k] == 1)
            {
                Console.Write("A(");
                for (int i = 0; i < k; i++)
                {
                    if (A[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(A[i]);
                            t++;
                        }
                        else Console.Write(",{0}", A[i]);
                    }
                }
                Console.Write(")");
            }
            else if (B[k] == 1)
            {
                Console.Write("A(");
                for (int i = 0; i < k; i++)
                {
                    if (B[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(B[i]);
                            t++;
                        }
                        else Console.Write(",{0}", B[i]);
                    }
                }
                Console.Write(")");
            }
            else
            {
                Console.Write("A(");
                for (int i = 0; i < k; i++)
                {
                    if (C[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(C[i]);
                            t++;
                        }
                        else Console.Write(",{0}", C[i]);
                    }
                }
                Console.Write(")");
            }
            t = 0;
            if (A[k] == 2)
            {
                Console.Write("B(");
                for (int i = 0; i < k; i++)
                {
                    if (A[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(A[i]);
                            t++;
                        }
                        else Console.Write(",{0}", A[i]);
                    }
                }
                Console.Write(")");
            }
            else if (B[k] == 2)
            {
                Console.Write("B(");
                for (int i = 0; i < k; i++)
                {
                    if (B[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(B[i]);
                            t++;
                        }
                        else Console.Write(",{0}", B[i]);
                    }
                }
                Console.Write(")");
            }
            else
            {
                Console.Write("B(");
                for (int i = 0; i < k; i++)
                {
                    if (C[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(C[i]);
                            t++;
                        }
                        else Console.Write(",{0}", C[i]);
                    }
                }
                Console.Write(")");
            }
            t = 0;
            if (A[k] == 3)
            {
                Console.Write("C(");
                for (int i = 0; i < k; i++)
                {
                    if (A[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(A[i]);
                            t++;
                        }
                        else Console.Write(",{0}", A[i]);
                    }
                }
                Console.Write(")\n");
            }
            else if (B[k] == 3)
            {
                Console.Write("C(");
                for (int i = 0; i < k; i++)
                {
                    if (B[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(B[i]);
                            t++;
                        }
                        else Console.Write(",{0}", B[i]);
                    }
                }
                Console.Write(")\n");
            }
            else
            {
                Console.Write("C(");
                for (int i = 0; i < k; i++)
                {
                    if (C[i] != 0)
                    {
                        if (t == 0)
                        {
                            Console.Write(C[i]);
                            t++;
                        }
                        else Console.Write(",{0}", C[i]);
                    }
                }
                Console.Write(")\n");
            }
        }
    }
}
