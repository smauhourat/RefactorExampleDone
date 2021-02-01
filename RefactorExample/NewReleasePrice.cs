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

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentRenterPoints(int daysRented) 
        {
            return daysRented > 1 ? 2 : 1;
        }
    }
}
