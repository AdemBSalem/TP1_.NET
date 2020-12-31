using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1_.NET.Models
{
    public class Participate
    {
        public int ParticipateID { get; set; }
        public int MovieID { get; set; }
        public int ActorID { get; set; }
        public Role Role { get; set; }

        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }

    }
}

