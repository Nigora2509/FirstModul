using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_dars.Models
{
    public  class Event
    {  
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; } 

        public DateTime EventDate { get; set; }

        public string Description { get; set; }

        public List<string> AttendenceMembers { get; set; } = new List<string>();

        public List<string> Tags { get; set; } = new List<string>();



    }
}
