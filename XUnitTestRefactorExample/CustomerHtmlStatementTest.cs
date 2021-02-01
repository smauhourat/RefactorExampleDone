using RefactorExample;
using System;
using Xunit;

namespace XUnitTestRefactorExample
{
    public class CustomerHtmlStatementTest
    {
        [Fact]
        public void Test1()
        {
            var customer = new Customer("Santiago");
            var movie1 = new Movie("Movie1", Movie.CHILDRENS);
            var movie2 = new Movie("Movie2", Movie.NEW_RELEASE);
            var rental1 = new Rental(movie1, 2);
            var rental2 = new Rental(movie2, 5);

            customer.AddRental(rental1);
            customer.AddRental(rental2);

            var result = customer.HtmlStatement();

            string expectedResult = "<h1>Rental Record for <em>Santiago</em></h1><p>\n";
            expectedResult += "\tMovie1\t1,5<br>\n";
            expectedResult += "\tMovie2\t15<br>\n";
            expectedResult += "<p>You owed <em>16,5</em><p>\n";
            expectedResult += "On this rental you earned <EM>4</EM> frequent renter points<P>";


            Assert.Equal(result, expectedResult);
        }
    }
}
