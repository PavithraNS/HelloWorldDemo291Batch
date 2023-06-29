using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo291Batch
{
    public class Calculator
    {
        //access modifierreturnType MathodName(parameters)
        public void AdditionOfTwoNumbers()
        {
            Console.WriteLine("Please enter 1st number");
            int firstNumb = Convert.ToInt32(Console.ReadLine()); //"10" 10
            Console.WriteLine("Please enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum:"+(firstNumb+secondNumber));
        }
    }
}
