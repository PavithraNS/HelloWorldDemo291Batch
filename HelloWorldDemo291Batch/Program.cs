﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo291Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello All Welcome to fellowship");
            //object creation of any class
            Calculator calculator = new Calculator();
            calculator.AdditionOfTwoNumbers();
            calculator.DifferenceOfTwoNumbers();
            Console.ReadLine();
        }
    }
}
