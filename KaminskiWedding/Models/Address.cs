using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KaminskiWedding.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string GuestName { get; set; }
        public string CurrentAddress { get; set; }

        [ForeignKey("RSVP")]
        public int RSVPID { get; set; }
        public virtual RSVP RSVP { get; set; }
    }
}