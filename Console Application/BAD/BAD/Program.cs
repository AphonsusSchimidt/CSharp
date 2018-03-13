using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAD
{
    class Program
    {
        static void xuat(int i, int[][] tg, int n)
        {
            for (int j = 1; j <= n; j++)
                Console.WriteLine("{0} \n", tg[i][j]);

        }

        static void nhap(out int n, out int B, int[] a, int[] b)
        {
            Console.WriteLine("\nNhap do dai xau: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nNhap khoi luong gioi han: ");
            B = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) a[i] = 0;
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine("\nNhap khoi luong vat thu {0}:  ", j);
                b[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
                Console.WriteLine("\nNhap vao so cong dung cua vat thu {0} ", i);
        }

        static bool sinh(bool ok, int n, int[] a)
        {
            int i = n; while (i > 0 && a[i] != 0)
            { a[i] = 0; i--; }
            if (i > 0)
                a[i] = 1;
            else
                ok = false;
            return ok;
        }

        static int tmdk1(int[] a, int[] b, int B, int n)
        {
            int temp = 0;
            for (int i = 1; i <= n; i++)
                temp += a[i] * b[i];
            if (temp <= B) return 1;
            return 0;
        }

        static void tmdk2(int n1, int[][] tg, int n, int[] c)
        {
            int[] temp = new int[50];
            for (int i = 0; i < 50; i++)
                temp[i] = 0;
            int max = 0;
            for (int i = 0; i < n1; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    temp[i] += tg[i][j] * c[j];
                }
                if (temp[i] > max) max = temp[i];
            }
            for (int i = 0; i < n1; i++)
                if (temp[i] == max)
                    xuat(i, tg, n);
        }

        static void copy(int n, int n1, int[][] tg, int[] a)
        {
            for (int i = 1; i <= n; i++)
                tg[n1][i] = a[i];
        }

        static void next(bool ok, int[] a, int[] b, int[] c, int B, int n, int n1, int[][] tg)
        {
            ok = true;
            while (ok)
            {
                if (tmdk1(a, b, B, n) == 1)
                {
                    copy(n, n1, tg, a);
                    n1++;
                }
                ok = sinh(ok, n, a);
            }
            tmdk2(n1, tg, n, c);
        }

        static void Main(string[] args)
        {

            int[] a = new int[50];
            int[] b = new int[50];
            int[] c = new int[50];
            int[][] tg = new int[500][];
            int n, B,n1=0;
            nhap(out n, out B, a, b);
            bool ok=true;
            next(ok, a, b, c, B, n, n1, tg);
        }


    }
}
