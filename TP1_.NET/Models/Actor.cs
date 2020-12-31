using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1_.NET.Models
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
   
        public virtual ICollection<Participate> Participates { get; set; }

    }
}