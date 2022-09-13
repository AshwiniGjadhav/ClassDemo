using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Date
    {
        int day, year;
        string month;

        public void AssignValue()
        {
            day=13;
            year=2022;
            month = "sept";
        }

        public string display()
        {
            return $" Date is :{day}/{month}/{year}";
        }
    }
}
