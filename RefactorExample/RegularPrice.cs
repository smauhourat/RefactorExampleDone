using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public class RegularPrice : Price
    {
        public RegularPrice(Movie movie) : base(movie)
        {

        }

        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }

        public override double GetCharge(int daysRented)
        {
            double output = 2;

            if (daysRented > 2)
                output = (daysRented - 2) * 1.5;

            return output;
        }
    }
}
