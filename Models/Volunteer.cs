using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LoveNottiesV2.Models
{
    public class Volunteer
    {
            [Key]
            [DataType(DataType.Text)]
            public string VolunteerID { get; set; }

            [Key, Column(Order = 1)]
            [DataType(DataType.Text)]
            public string VolunteerName { get; set; }

            [Key, Column(Order = 1)]
            [DataType(DataType.PhoneNumber)]
            public string VolunteerCell { get; set; }

            [Key, Column(Order = 1)]
            [DataType(DataType.EmailAddress)]
            public string VolunteerEmail { get; set; } 
    }
}
