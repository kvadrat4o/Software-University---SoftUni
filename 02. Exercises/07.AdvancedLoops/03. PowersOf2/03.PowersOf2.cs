﻿/*
 * Created by SharpDevelop.
 * User: DVasilev
 * Date: 20/03/2017
 * Time: 09:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace PowersOf2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num * 2);
                num *= 2;
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}