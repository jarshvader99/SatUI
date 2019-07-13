using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Data.EF//.Metadata
{
    public class StudentMetadata
    {
        //public int StudentID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(40, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string LastName { get; set; }

        [Display(Name = "Phone: ")]
        [DisplayFormat(NullDisplayText = "NA")]
        [StringLength(15, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string PhoneNbr { get; set; }

        [Display(Name = "Email ")]
        [StringLength(100, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string Email { get; set; }

        [Display(Name = "Address: ")]
        [StringLength(60, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string StreetAddress { get; set; }

        [Display(Name = "City: ")]
        [StringLength(60, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string City { get; set; }

        [Display(Name = "State: ")]
        [StringLength(2, ErrorMessage = "You have entered too many characters. Please try again.")]
        [DisplayFormat(NullDisplayText = "NA")]
        public string State { get; set; }

        [Display(Name = "Zip Code: ")]
        [DisplayFormat(NullDisplayText = "NA")]
        [StringLength(14, ErrorMessage = "You have entered too many characters. Please try again.")]
        [RegularExpression(@"[0-9]{5}|[a-zA-Z0-9]{10}", ErrorMessage = "Please enter a valid zip code")]
        public string ZipCode { get; set; }

        [Display(Name = "Country: ")]
        [StringLength(74, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string Country { get; set; }

        [Display(Name = "Photo URL: ")]
        [DisplayFormat(NullDisplayText = "NA")]
        [StringLength(25, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string PhotoUrl { get; set; }


       // public int StatusID { get; set; } F-K
    }
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
       
        [Display(Name = "Address")]
        public string AddressInfo
        {
            get
            {
                return $"{StreetAddress} {City}, {State} {ZipCode}, {Country} ";
            }
        }

        [Display(Name = "Full Name")]
        public string NameJoin
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }
}
