using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_oop_project
{
    class TravelEntity
    {
        protected string name;
        protected string description;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Description
        {
            set { description = value; }
            get { return description; }
        }
        public TravelEntity()
        { }
        public TravelEntity(string name, string description)
        {
            this.description = description;
            this.name = name;
        }
    }
}
