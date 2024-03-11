using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlbumsWebApp.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Hvem har lavet det?")]
        public string Artist { get; set; }
        [Required]
        [DisplayName("Hvad hedder det?")]
        public string Title { get; set; }
        [CheckValidYear]
        [DisplayName("Hvornår er det udgivet?")]
        public int ReleaseYear { get; set; }
    }
}