using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1_.NET.Models
{
    public class Director
    {
       
        public int DirectorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}