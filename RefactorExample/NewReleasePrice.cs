using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public class NewReleasePrice : Price
    {
        public NewReleasePrice(Movie movie) : base(movie)
        {

        }

        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3; ;
        }

        public new int GetFrequentRenterPoints(int daysRented) 
        {
            if (daysRented > 1)
                return 2;
            return 1; 
        }
    }
}
