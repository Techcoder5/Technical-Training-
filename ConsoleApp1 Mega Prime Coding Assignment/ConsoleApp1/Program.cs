﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        public static bool checkPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                int val = Convert.ToInt32(Math.Sqrt(num));
                bool flag = false;
                for (int i = 2; i <= val; i++)
                {
                    if (num % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        /*public static  void passbyvalue(int a1)
        {
            a1 = a1 + 10;
            Console.WriteLine("Value is : " + a1);
        }
        public static void passbyref(ref int b)
        {
            b = b + 10;
            Console.WriteLine(b);
        }
        public static void passbyout(out int d)
        {
            d = 10;
            Console.WriteLine(d);
        }*/
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int a = 78;//boxing concept
            //object ob = a;
            //a = 9;
            //Console.WriteLine(a);
            //Console.WriteLine(ob);
            /*int val = 89;
            passbyvalue(val);//if we simply write here as passnyvalue function then it would give error as the function declared above is instance and hence either we should declare that method as static or create the obejct of the class here//
            Console.WriteLine(val);
            int c1 = 20;
            Program.passbyref(ref c1);
            Console.WriteLine(c1);
            int e;
            passbyout(out e);
            Console.WriteLine(e);*/

            //int[] a = new int[5] { 1,2,3,4,5};
            //foreach(int i in a)
            /*{
                Console.WriteLine(i);
            }*/
            //Multi Dimension Array//
            /*int[,] numbers1 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] names = new string[2, 2] { { "Rosy", "Amy" }, { "Peter", "Albert" } };*/
            //without using new opeartor
            //int[,] a1 = { { 1, 2 }, { 3, 4 } };
            //int[,] numbers = new int[3, 2];
            //numbers[0, 0] = 1;
            //numbers[1, 0] = 2;
            //numbers[2, 0] = 3;
            //numbers[0, 1] = 4;
            //numbers[1, 1] = 5;
            //numbers[2, 1] = 6;
            //Accessing array elements of multi dimension array//
            //Console.WriteLine(numbers[0, 0]);
            //Console.WriteLine(numbers[0, 1]);
            //Console.WriteLine(numbers[1, 0]);
            //Console.WriteLine(numbers[1, 1]);
            //Console.WriteLine(numbers[2, 0]);
            //Console.WriteLine(numbers[2, 2]);//gives index out of range//
            //Jagged aray concept//
            //int[][] intJaggedArray = new int[3][];
            /*int num = Convert.ToInt32(Console.ReadLine());
             * 
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is ODD");
            }*/
            int num = Convert.ToInt32(Console.ReadLine());
            if (checkPrime(num) == false)
            {
                Console.WriteLine("Not a MegaPrimeNumber");
            }
            else
            {
                bool chk=false;
                while (num > 0)
                {
                    chk = false;
                    int digit = num % 10;
                    if (checkPrime(digit) == true)
                    {
                        chk = true;
                        num = num / 10;
                    }
                    else
                    {
                        Console.WriteLine("Not a MegaPrimeNumber");
                        break;
                    }
                }
                if (chk)
                {
                    Console.WriteLine("MegaPrimeNumber");
                }
            }
            
            Console.ReadLine();
        }
    }
}