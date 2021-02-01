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

        public abstract double GetCharge(int daysRented);
        public abstract int GetFrequentRenterPoints(int daysRented);
    }
}
