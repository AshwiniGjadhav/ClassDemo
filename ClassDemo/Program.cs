using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();

            date.AssignValue();

            Console.WriteLine(date.display());
        }
    }
}
