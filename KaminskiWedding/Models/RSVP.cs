using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaminskiWedding.Models
{
    public class RSVP
    {
        public int Id { get; set; }
        public string GuestRSVP { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }
}