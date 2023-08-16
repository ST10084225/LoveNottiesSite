using System.ComponentModel.DataAnnotations;

namespace LoveNottiesV2.Models
{
    public class SuccessStory
    {
        [Key]
        [DataType(DataType.Text)]
        public string SuccessStoryID { get; set; }

        [DataType(DataType.Text)]
        public string SuccessStoryTitle { get; set; }

        [DataType(DataType.ImageUrl)]
        public string SuccessStoryImage { get; set; }

        [DataType(DataType.Text)]
        public string SuccessStoryDescription { get; set; }
    }
}
