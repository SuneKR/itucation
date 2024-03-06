using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApplication.Models
{
    public class Photo
    {
        private DateTime createdDate;

        public int PhotoID { get; set; }
        [Required] public string Title { get; set; }
        [DisplayName("Picture")] public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }
        [DataType(DataType.MultilineText)] public string Description { get; set; }
        [DataType(DataType.DateTime)][DisplayName("Created Date")][DisplayFormat(DataFormatString = "{0:MM/dd/yy}")] public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        public string UserName { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}