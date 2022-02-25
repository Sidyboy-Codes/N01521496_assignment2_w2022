using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace N01521496_assignment2_w2022.Controllers
{
    public class J1Controller : Controller
    {
        // GET: J1
        // this will be landing page for J1
        // having a form to get user meal
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// This action will calculate total calories of meal orderd by the user.
        /// form in index file will redirect to this action and TotalCal view will be returned
        /// </summary>
        /// <param name="burger">id for selected burger</param>
        /// <param name="sideorder">id for selected sideorder</param>
        /// <param name="drinks">id for selected drinks</param>
        /// <param name="dessert">id for selected dessert</param>
        /// <returns>Total Calories of your Meal is xyz</returns>
        /// 
        /// Example
        /// <param name="burger">4</param>
        /// <param name="sideorder">4</param>
        /// <param name="drinks">3</param>
        /// <param name="dessert">4</param>
        /// <returns>Total Calories of your Meal is 118</returns>

        [HttpPost]
        public ActionResult TotalCal(int burger,int sideorder, int drinks, int dessert)
        {
            // creating arrays of food item's calorie according to food type
            // so that we can select food item from array which user wants using indexing
            int[] burgerCals = { 461, 431, 420, 0 };
            int[] sideorderCals = { 100, 57, 70, 0 };
            int[] drinksCals = { 130, 160, 118, 0 };
            int[] dessertCals = { 167, 266, 75, 0 };

            // so to get exact calories of user selected item we will do x-1 bcz index starts from 0
            int userBurger = burgerCals[burger - 1]; // -1 bcz index starts from 0
            int userSideOrder = sideorderCals[sideorder - 1];
            int userDrink = drinksCals[drinks - 1];
            int userDessert = dessertCals[dessert - 1];

            // adding all calories from meal
            int total = userBurger+userSideOrder+userDrink+userDessert;

            // we will use this ViewData to get value in our html view
            ViewData["TotalCals"] = total;
            return View();
        }

    }

}