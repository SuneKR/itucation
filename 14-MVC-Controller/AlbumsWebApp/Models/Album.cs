using System;
using System.Collections.Generic;
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
        public string Artist { get; set; }
        [Required]
        public string Title { get; set; }
        [CheckValidYear]
        public int ReleaseYear { get; set; }
    }
}