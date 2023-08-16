using System.ComponentModel.DataAnnotations;

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

        [DataType(DataType.ImageUrl)]
        public string OurPersonImage { get; set; }

        [DataType(DataType.Text)]
        public string OurPersonDescription { get; set; }

    }
}
