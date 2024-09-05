using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Destination destination = new Destination();
            destination.Name = "Luxor";
            destination.Description = "Explore the ancient wonders of Luxor, Egypt";
            destination.Seats = 50;

            Tour tour = new Tour();
            tour.Name = "Luxor Adventure";
            tour.Description = "Experience the magic of Luxor and its historical sites";
            tour.Duration = 5;
            tour.Price = 1500.00f;

            tour.AddDestination(destination);

            Customer customer = new Customer();
            customer.Name = "Yasser Mohammed";
            customer.Email = "yasser.mohammed@example.com";

            tour.MakeBooking(customer, 2);

            List<Booking> bookings = tour.GetBookings();

            Console.WriteLine("Bookings for tour: {0}", tour.Name);
            foreach (Booking booking in bookings)
            {
                Console.WriteLine("{0} - {1} seats - {2}", booking.Customer.Name, booking.NumberOfSeats, booking.Tour.Name);
            }

            Booking bookingToCancel = bookings[0];
            tour.CancelBooking(bookingToCancel);

            bookings = tour.GetBookings();
            Console.WriteLine("Bookings for tour: {0}", tour.Name);
            foreach (Booking booking in bookings)
            {
                Console.WriteLine("{0} - {1} seats - {2}", booking.Customer.Name, booking.NumberOfSeats, booking.Tour.Name);
            }
            Console.ReadKey();
        }
    }
}
