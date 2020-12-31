using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP1_.NET.Models
{
    public class Movie
    {
       

        public int  ID { get; set; }

        [Required(ErrorMessage ="Matensechi " )]
        [StringLength(30,MinimumLength = 3)]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
       
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }

        public int DirectorID { get; set; }
        public virtual Director Director { get; set; }
        public virtual ICollection<Participate> Participates { get; set; }

    }
}
       
        /*  public string getTitre()
 {
     return titre;
 }

 public void setTitre(string titre)
 {
     this.titre = titre;
 }

public virtuel collection<Movie> Movies
public virtuel Director Director {get; set;}
}*/
    