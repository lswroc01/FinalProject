using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace GamesVille.Models
{
    public class Game
    {

        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }


        public string Platform { get; set; }
        public string ESBR_Rating { get; set; }
        public string Category { get; set; }
        public decimal Rating { get; set; }
        public string PictureURL { get; set; }

    }

    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}
