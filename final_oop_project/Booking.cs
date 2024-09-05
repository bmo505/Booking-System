using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class Booking
    {
        int numberOfSeats;
        Tour tour;
        Customer customer;
        public Booking()
        { }
        public Booking(int numberOfSeats, Tour tour, Customer customer)
        {
            this.numberOfSeats = numberOfSeats;
            this.tour = tour;
            this.customer = customer;
        }

        public int NumberOfSeats
        {
            set { numberOfSeats = value; }
            get { return numberOfSeats; }
        }
        public Tour Tour
        {
            set { tour = value; }
            get { return tour; }
        }
        public Customer Customer
        {
            set { customer = value; }
            get { return customer; }
        }

    }
}
