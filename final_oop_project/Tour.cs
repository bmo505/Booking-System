using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class Tour
    {
        int duration;
        List<Destination> destination = new List<Destination>();
        float price;
        List<Booking> booking = new List<Booking>();
        public Tour()
        { }
        public Tour(int duration, List<Destination> destination, float price, List<Booking> booking)
        {
            this.duration = duration;
            this.destination = destination;
            this.price = price;
            this.booking = booking;
        }
        public int Duration
        {
            set { duration = value; }
            get { return duration; }
        }
        public float Price
        {
            set { price = value; }
            get { return price; }
        }
        public List<Destination> Destinations
        {
            set { destination = value; }
            get { return destination; }
        }
        public List<Booking> Bookings
        {
            set { booking = value; }
            get { return booking; }
        }

        public string Description { get; internal set; }
        public string Name { get; internal set; }

        public void AddDestination(Destination destination)
        {
            Destinations.Add(destination);
        }
        public void RemoveDestination(Destination destination)
        {
            Destinations.Remove(destination);
        }
        public int GetAvailableSeats()
        {
            int totalseats = 0;
            foreach (Destination destination in Destinations)
            {
                totalseats += destination.Seats;
            }
            foreach (Booking booking in Bookings)
            {
                totalseats -= booking.NumberOfSeats;
            }
            return totalseats;

        }
        public void MakeBooking(Customer customer, int numberOfSeats)
        {
            if (GetAvailableSeats() >= numberOfSeats)
            {
                Booking booking = new Booking { Customer = customer, Tour = this, NumberOfSeats = numberOfSeats };
                Bookings.Add(booking);
                Console.WriteLine("Booking successful");
            }
            else
            {
                Console.WriteLine("Not enough available seats");
            }
        }
        public void CancelBooking(Booking booking)
        {
            Bookings.Remove(booking);
            Console.WriteLine("Booking canceled");
        }
        public List<Booking> GetBookings()
        {
            return Bookings;
        }
        public List<Destination> GetDestiinations()
        {
            return Destinations;
        }
        public float GetPrice()
        {
            return price;
        }

    }
}
