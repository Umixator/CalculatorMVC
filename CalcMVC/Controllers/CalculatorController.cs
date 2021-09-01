using CalcMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalcMVC.Controllers
{
    public class CalculatorController : Controller
    {
        static readonly char[] operList = { '+', '-', '*', '/' };

        public ActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel c)
        {
            TakeArgs(c);
            return View(c);
        }

        static string Calculation(double A, double B, char oper, CalculatorModel c)
            {
            switch (oper)
            {
                case '+':
                    return Convert.ToString(A + B);
                case '-':
                    return Convert.ToString(A - B);
                case '*':
                    return Convert.ToString(A * B);
                case '/':

                    if (B != 0)
                    {
                        return Convert.ToString(A / B);
            }

                    else
            {
                        c.info = "Can't divide by 0";
                        return "";
                    }

                default: return "";
            }
            }

        static string TakeArgs(CalculatorModel c) //method for assigning values to arguments
        {
            if (!char.IsDigit(c.input[0]))
            {
                return c.input;
            }

            else
            {
                double[] argList = c.input
                    .Split(operList, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(n => Convert.ToDouble(n)).ToArray();    // parsing user input in 2 arguments
                char oper = operList.FirstOrDefault(c.input.Contains);
                c.result = Calculation(argList[0], argList[1], oper, c);
                c.input = Convert.ToString(c.result);
                return Convert.ToString(c.result);
            }
        }
    }
}