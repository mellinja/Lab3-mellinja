using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{ 
        private DateTime day1 = new DateTime(2001,1,1);
        private DateTime day2 = new DateTime(2001,1,3);
		[Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(day1, day2, 1);
            Assert.IsNotNull(target);
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [Test()]
        public void TestThatFlightThrowsInvalidOperationException()
        {
            var test = new Flight(day2, day1, 1);
        }


        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Test()]
        public void TestTHatFlightThrowsArgumentOutOfRangeException()
        {
            var test = new Flight(day1, day2, -1);
        }



        [Test()]
        public void TestFlightsEqual()
        {
            Flight test1 = new Flight(day1,day2,1);
            Flight test2 = new Flight(day1, day2, 1);
            Assert.AreEqual(test1,test2);
        }



        [Test()]
        public void TestFlightsNotEqual()
        {
            Flight test1 = new Flight(day1, day2, 1);
            Flight test2 = new Flight(day1, day2, 11);
            Assert.AreNotEqual(test1, test2);
        }

	}
}
