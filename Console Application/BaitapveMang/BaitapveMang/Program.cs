using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapveMang
{
    class Program
    {

        static void SelectSort(int[] A, int n)
        {

            int temp;
            for (int i = 0; i < n; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] > A[min])
                    {
                        min = j;
                    }

                }
                temp = A[min];
                A[min] = A[i];
                A[i] = temp;


            }

        }

        static void FindMax2(int[] a, int n)
        {

           int max = a[0];
           int max2 = a[1];
            for (int i = 2; i < n; i++)
            {
                if (max2 > max)
                {
                    //swap 
                    max = max + max2;
                    max2 = max - max2;
                    max = max - max2;
                }
                if (a[i] > max)
                {
                    max2 = max;
                    max = a[i];
                }
                else if (a[i] < max && a[i] > max2)
                    max2 = a[i];
            }
            Console.Write("{0} {1}", max, max2);
        }
        static void TronMang()
        {
            int n1 = 0, n2=0;
            Console.Write("Nhap Vao so luong phan tu mang x: ");
            n1 = int.Parse(Console.ReadLine());
            int[] x = new int[n1];
            
            for (int i = 0; i < n1; i++)
            {
                Console.Write("X[{0}]: ", i);
               x[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap Vao so luong phan tu mang y: ");
            n2 = int.Parse(Console.ReadLine());
            int[] y = new int[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Y[{0}]: ", i);
                y[i] = int.Parse(Console.ReadLine());
            }
            int[] z = new int[100];

        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Nhap Vao so luong phan tu: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            FindMax2(a, n);
           
         
            Console.ReadKey();

        }
    }
}
