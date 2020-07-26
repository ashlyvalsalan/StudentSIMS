using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int StudentAddressId { get; set; }
        [Column(Order = 2)]
        public Student Student { get; set; }
        [ForeignKey("Student"), Required]
        public int StudentId { get; set; }
        public int StreetNumber { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public long PostCode { get; set; }
        public string Country { get; set; }
    }
}
