using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Test_2.string_programs
{
    class Class1
    {
        static void Main(string[] args)
        {
            string s = "abcdefghijklmn";
            char[] ch = s.ToCharArray();
            string ss = " ";
            for (int i = 0; i < s.Length; i++)
            {
               //ch[i]="0";
            }//
            Console.WriteLine(ss);
            Console.ReadLine();
        }
    }
    class subarray
    {
        static void Main(string[] args)
        {
            //Accept Size
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Accept data
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones;

            //Find Largest subarray length have equal zero and one 

            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }
    class PrimeArrayy
    {
        static void Main(string[] args)
        {
            int i, j, p, s = 0;
            int[] arr = new int[] { 2,3,4,5,6};


            //for (i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}


            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    s = s + arr[i];
                }


            }
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
    class PrimeArray_1
    {
        static void Prime()
        {

        }
        static void Main(string[] args)
        {
            int s = 0;
            bool p;
            
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int j = 2;
                p = true;
                while (j < a[i])
                {
                    if (a[i] % j == 0)
                    {
                        p = false;
                        break;
                    }
                    j++;
                }
                if (p==true)
                    s = s + a[i];
                
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    class Pactice_exception
    {
        static string s;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(s.ToUpper());
                //Console.WriteLine(d);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
