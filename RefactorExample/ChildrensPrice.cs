using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public class ChildrensPrice : Price
    {
        public ChildrensPrice(Movie movie):base(movie)
        {

        }

        public override double GetCharge(int daysRented)
        {
            double output = 1.5;

            if (daysRented > 3)
                output = (daysRented - 3) * 1.5;

            return output;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            return 1;
        }
    }
}
