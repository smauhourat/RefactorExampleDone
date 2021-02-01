using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorExample
{
    public class Customer
    {
        private string _name;
        private List<Rental> _rentals = new List<Rental>();
        public Customer(string name)
        {
            _name = name;
        }
        public void AddRental(Rental arg)
        {
            _rentals.Add(arg);
        }
        public string GetName()
        {
            return _name;
        }

        private double GetTotalCharge()
        {
            double output = 0;
            foreach (var rent in _rentals)
            {
                output += rent.GetCharge();
            }
            return output;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int output = 1;
            foreach (var rent in _rentals)
            {
                // add frequent renter points
                // add bonus for a two day new release rental
                output += rent.GetFrequentRenterPoints();
            }
            return output;
        }

        public string Statement()
        {            
            List<Rental> rentals = _rentals;
            string result = "Rental Record for " + GetName() + "\n";

            foreach (var rent in rentals)
            {
                //show figures for this rental
                result += "\t" + rent.GetMovie().GetTitle() + "\t" + rent.GetCharge().ToString() + "\n";
            }

            //add footer lines
            result += "Amount owed is " + GetTotalCharge().ToString() + "\n";
            result += "You earned " + GetTotalFrequentRenterPoints().ToString() + " frequent renter points";
            return result;
        }

        public string HtmlStatement()
        {
            List<Rental> rentals = _rentals;
            string result = "<h1>Rental Record for <em>" + GetName() + "</em></h1><p>" + "\n";

            foreach (var rent in rentals)
            {
                //show figures for this rental
                result += "\t" + rent.GetMovie().GetTitle() + "\t" + rent.GetCharge().ToString() + "<br>\n";
            }

            //add footer lines            
            result += "<p>You owed <em>" + GetTotalCharge().ToString() + "</em><p>\n";
            result += "On this rental you earned <EM>" + GetTotalFrequentRenterPoints().ToString() + "</EM> frequent renter points<P>";
            return result;
        }
    }
}
