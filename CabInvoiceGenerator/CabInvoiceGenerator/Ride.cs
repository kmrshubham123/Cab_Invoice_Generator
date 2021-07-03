using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Ride Class To Set Data for Particular Ride
    /// </summary>
    public class Ride
    {
        public double distance;
        public int time;
        /// <summary>
        /// Parameter constructor for setting Data 
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
        }
}   }
