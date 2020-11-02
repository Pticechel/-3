using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная__3
{
    class Program
    {
        static void first()
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, Z = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            int i = 1, step = 1;

            double znam = 1, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    step = i * 2;
                    znam *= (step - 1) * step;
                    if (i % 2 == 0)
                        chisl = -Math.Pow(Y, step);
                    else
                        chisl = Math.Pow(X, step);
                    Z += (step - 1) * (step + 1) * chisl / znam;
                }
            }
            if (t == 1)
            {
                i = 1;
                while(i<=N)
                {
                    step = i * 2;
                    znam *= (step - 1) * step;
                    if (i % 2 == 0)
                        chisl = -Math.Pow(Y, step);
               else
                        chisl = Math.Pow(X, step);
                    Z += (step - 1) * (step + 1) * chisl / znam;
                    i++;
                }
            }
            if (t == 2)
            {
                i = 1;
                do
                {
                    step = i * 2;
                    znam *= (step - 1) * step;
                    if (i % 2 == 0)
                        chisl = -Math.Pow(Y, step);
                    else
                        chisl = Math.Pow(X, step);
                    Z += (step - 1) * (step + 1) * chisl / znam;
                    i++;
                } while (i <= N);
            }
            Console.WriteLine(String.Format("{0:0.0000000}", Z));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
        ///                                                                     Выполнил Абдуразаков Ислам Вариант 2
        static void Main(string[] args)
        {
            first();
            Second();
        }
        static void Second()
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output2.txt");
            var new_in = new StreamReader(@"input2.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, Z = 0;

            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToDouble(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            int i = 0, step = 1, znam1 = 0, znam2 = 2, znam3 = 4;
            double znam = 1, chisl;

            if (t == 0)
            {
                for(i=0; i<=N;i++)
                {
                    
                    znam1 = znam1 + 1;
                    znam2 = znam2 + 1;
                    znam3 = znam3 + 1;
                    znam = znam1 * znam2 * znam3;
                    if (i % 2 == 0)
                        chisl = -Math.Pow(Y, step);
                    else
                        chisl = Math.Pow(X, step);
                    Z += chisl / znam;
                        step = i + 1;

                    Console.WriteLine(String.Format("{0:0.0000000}", Z));
                    Console.SetOut(save_out); new_out.Close();
                    Console.SetIn(save_in); new_in.Close();
                }
            }


        }
    }
        
 }

