using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventOrganizerAPI.Model
{
    public class Orders
    {

        //Message id
        public int Id { get; set; }

        //Mesage text
        public string Name { get; set; }

        //Message sender
        public string Details { get; set; }

        //Message time
        public DateTime Dtime { get; set; }
    }
}
