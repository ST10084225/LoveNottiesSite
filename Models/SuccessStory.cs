using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoveNottiesV2.Models
{
    public class SuccessStory
    {
        [Key]
        [DataType(DataType.Text)]
        public string SuccessStoryID { get; set; }

        [DataType(DataType.Text)]
        public string SuccessStoryTitle { get; set; }

        [DataType(DataType.Text)]
        public string SuccessStoryImageID { get; set; }

        [DataType(DataType.Text)]
        public string SuccessStoryDescription { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile SuccessStoryImageFile { get; set; }

        [NotMapped]
        public byte[] SuccessStoryImageBytes { get; set; }
    }
}
