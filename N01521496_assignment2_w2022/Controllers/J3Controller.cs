using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N01521496_assignment2_w2022.Controllers
{
    public class J3Controller : Controller
    {
        // GET: J3
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// SumacLength will take 2 inputs: 2 integers such that a>=b;
        /// this will return length of sumac sequence.
        /// </summary>
        /// <param name="a">1st integer</param>
        /// <param name="b">2nd integer</param>
        /// <returns>The Sumac Sequence length for given numbers is xyz</returns>
        /// 
        /// Example
        /// <param name="a">120</param>
        /// <param name="b">71</param>
        /// <returns>The Sumac Sequence length for given numbers is 5</returns>

        [HttpPost]
        public ActionResult SumacLength(int a, int b)
        {
            int num1 = a;
            int num2 = b;
            int num3;

            // intiallize counter to count lenght of sequence
            // here we are already using 2 numbers so count starts from 2 
            int counter = 2;

            // using while loop as we will going to check multiple conditions
            // 1st a>b and 2nd both number should be greater than or equal 0
            while (num1 > num2 && num1 >0 && num2 > 0)
            {
                num3 = num1 - num2; // difference between 2 number
                num1 = num2;
                num2 = num3;
                counter++;
            }

            ViewData["SLength"] = counter;
            return View();
        }
    }
}