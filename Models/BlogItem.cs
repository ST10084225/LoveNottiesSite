using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace LoveNottiesV2.Models
{
    public class BlogItem
    {
        [Key]
        [DataType(DataType.Text)]
        public string BlogID { get; set; }

        [DataType(DataType.Text)]
        public string BlogTitle { get; set; }

        [DataType(DataType.Text)]
        public string BlogImageID { get; set; }

        [DataType(DataType.Text)]
        public string BlogDescription { get; set; }

        [DataType(DataType.Text)]
        public string BlogViews { get; set; }

        [DataType(DataType.Text)]
        public  string BlogTag { get; set; }

        [DataType(DataType.Date)]
        public string BlogDate { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile BlogImageFile { get; set; }

        [NotMapped]
        public byte[] BlogImageBytes { get; set;}
    }
}
