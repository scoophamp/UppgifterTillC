﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var myLogger = new Logger();
            myLogger.Log("First post");
            myLogger.Log("Second post");

            foreach (var item in myLogger.Logpost)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
           
        }
    }
}
