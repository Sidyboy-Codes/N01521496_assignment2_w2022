using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N01521496_assignment2_w2022.Controllers
{
    public class J2Controller : Controller
    {
        // GET: J2
        // this will be landing page for J2 task
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// This will handle post request in which we will get sides for dice 1 and 2
        /// and will give total number of combinations in which total of sides is 10
        /// 
        /// grammar of sentence changes according to number of combination,, see example 
        /// </summary>
        /// <param name="mSide">number of sides for 1st dice</param>
        /// <param name="nSide">number of sides for 2nd dice</param>
        /// <returns>There are/is x ways/way to get the sum 10.</returns>
        /// 
        /// Examples
        /// <param name="mSide">6</param>
        /// <param name="nSide">8</param>
        /// <returns>There are 5 ways to get the sum 10.</returns>
        /// 
        /// <param name="mSide">2</param>
        /// <param name="nSide">8</param>
        /// <returns>There is 1 way to get the sum 10.</returns>

        [HttpPost]
        public ActionResult Combinations(int mSide, int nSide)
        {
            // number of sides for Dice 1
            int m = mSide;

            // number of sides for Dice 2
            int n = nSide;

            // number of combination will be stored in variable counter
            int counter = 0;

            // logic: using for loop for dice 1 and 2

            // this loop will take each side of Dice 1 one by one
            for(int i=1; i<=m; i++)
            {
                // this loop will take each side of Dice 2 one by one and will add it to side of Dice 1
                for(int j=1; j<=n; j++)
                {
                    // if addition of side m and side n is 10 we will increment counter
                    if (i + j == 10)
                    {
                        counter++;
                    }
                }

            }

            // ******* grammer for combination ********

            // if single combination: there "is" x "way".
            // if multiple combination: there "are" x "ways".

            if (counter > 1)
            {
                string are_is = "are";
                string way = "ways";
                ViewData["are_is"] = are_is;
                ViewData["way"] = way;
            }
            else
            {
                string are_is = "is";
                string way = "way";
                ViewData["are_is"] = are_is;
                ViewData["way"] = way;
            }


            ViewData["Combinations"] = counter;
            return View();
        }

    }
}