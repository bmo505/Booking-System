using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class Destination : TravelEntity
    {
        int seats;
        public Destination()
        { }
        public Destination(string name, string description, int seats)
            : base(name, description)
        {
            this.seats = seats;
        }
        public int Seats
        {
            set { seats = value; }
            get { return seats; }
        }

    }
}
