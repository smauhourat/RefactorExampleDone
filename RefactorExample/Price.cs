using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public abstract class Price
    {
        private Movie _movie;

        public Price(Movie movie)
        {
            this._movie = movie;
        }

        public abstract int GetPriceCode();
        public abstract double GetCharge(int daysRented);
        public int GetFrequentRenterPoints(int daysRented) { return 1; }
    }
}
