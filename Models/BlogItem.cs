using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoveNottiesV2.Models
{
    public class BlogItem
    {
        [Key]
        [DataType(DataType.Text)]
        public string BlogID { get; set; }

        [DataType(DataType.Text)]
        public string BlogTitle { get; set; }

        [DataType(DataType.ImageUrl)]
        public string BlogImage { get; set; }

        [DataType(DataType.Text)]
        public string BlogDescription { get; set; }

        [DataType(DataType.Text)]
        public string BlogViews { get; set; }

        [DataType(DataType.Text)]
        public  string BlogTag { get; set; }
    }
}
