using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoveNottiesV2.Models
{
    public class OurPeople
    {
        [Key]
        [DataType(DataType.Text)]
        public string OurPersonID { get; set; }

        [DataType(DataType.Text)]
        public string OurPersonFirstName { get; set; }

        [DataType(DataType.Text)]
        public string  OurPersonLastName { get; set; }

        [DataType(DataType.Text)]
        public string OurPersonTitle { get; set; }

        [DataType(DataType.Text)]
        public string OurPersonImageID { get; set; }

        [DataType(DataType.Text)]
        public string OurPersonDescription { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile OurPersonImageFile { get; set; }

        [NotMapped]
        public byte[] OurPersonImageBytes { get; set; }
    }
}
