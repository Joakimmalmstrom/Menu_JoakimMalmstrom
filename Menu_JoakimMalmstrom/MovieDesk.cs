using System;
using System.Collections.Generic;

namespace Menu_JoakimMalmstrom
{
    // Adds visitors
    // Calculates prices
    internal class MovieDesk
    {
        // List with MovieVisitors
        List<MovieVisitor> visitorList;

        // Variables with different prices
        int standardPrice = 120;
        int teenPrice = 80;
        int pensionPrice = 90;

        public MovieDesk()
        {
            visitorList = new List<MovieVisitor>();
        }

        // Did not end up using this
        // Returns the MovieVisitors from the list
        //internal MovieVisitor[] GetMovieVisitors()
        //{
        //    return visitorList.ToArray();
        //}

        // Adding MovieVisitor function
        internal void AddVisitor(int age)
        {
            visitorList.Add(new MovieVisitor(age));
        }

        // Calculates the total price
        internal int CalculatePrice()
        {
            // Creates temp variable for result
            int result = 0;

            // Loops through the visitor's list
            // Checking their price class and adding cost if met criteria
            // returns the total cost
            for (int i = 0; i < visitorList.Count; i++)
            {
                if (visitorList[i].priceClass == MoviePriceClass.teen)
                {
                    result += teenPrice;
                }
                else if (visitorList[i].priceClass == MoviePriceClass.pension)
                {
                    result += pensionPrice;
                }
                else
                {
                    result += standardPrice;
                }
            }
            return result;
        }
    }
}