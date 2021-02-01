using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public class Movie
    {
        public const int CHILDRENS = 2;
        public const int REGULAR = 0;
        public const int NEW_RELEASE = 1;

        private string _title;
        private Price _price;

        public Movie(string title, int priceCode)
        {
            _title = title;
            SetPriceCode(priceCode);
        }
        public int GetPriceCode()
        {
            return _price.GetPriceCode();
        }
        public void SetPriceCode(int arg)
        {
            switch (arg)
            {
                case Movie.REGULAR:
                    _price = new RegularPrice(this);
                    break;
                case Movie.NEW_RELEASE:
                    _price = new NewReleasePrice(this);
                    break;
                case Movie.CHILDRENS:
                    _price = new ChildrensPrice(this);
                    break;
                default:
                    throw new IllegalArgumentException("Incorrect Price Code");
            }
        }
        public string GetTitle()
        {
            return _title;
        }

        public void SetPrice(Price price)
        {
            _price = price;
        }

        public Price GetPrice()
        {
            return _price;
        }

        public double GetCharge(int daysRented)
        {
            return _price.GetCharge(daysRented);
        }

        public int GetFrequentRenterPoints(int daysRented)
        {
            return _price.GetFrequentRenterPoints(daysRented);
        }
    }
}
