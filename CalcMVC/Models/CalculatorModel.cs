using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcMVC.Models
{
    public class CalculatorModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public string result { get; set; }
        public string input { get; set; }
        public string info { get; set; } = "Write your calculations";
    }
}