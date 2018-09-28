using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artista { get; set; }

        public DateTime Data { get; set; }

        [Required]
        [StringLength(255)]
        public string Local { get; set; }

        [Required]
        public Genre genero { get; set; }
    }


}