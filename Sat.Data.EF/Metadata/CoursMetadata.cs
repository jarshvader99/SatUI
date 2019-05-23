using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Data.EF.Metadata
{
    public class CoursMetadata
    {
        //public int CourseID { get; set; }

        [Display(Name = "Course Name")]
        [StringLength(30, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string CourseName { get; set; }

        [Display(Name = "Course Description")]
        [StringLength(4000, ErrorMessage = "You have entered too many characters. Please try again.")]
        [DisplayFormat(NullDisplayText = "NA")]
        [UIHint("MultilineText")]

        public string CourseDescription { get; set; }

        
        [StringLength(150, ErrorMessage = "You have entered too many characters. Please try again.")]
        [DisplayFormat(NullDisplayText = "NA")]
        public string Curriculum { get; set; }

        [StringLength(4000, ErrorMessage = "You have entered too many characters. Please try again.")]
        [DisplayFormat(NullDisplayText = "NA")]
        [UIHint("MultilineText")]

        public string Notes { get; set; }


        public bool IsRequired { get; set; }
    }
    [MetadataType(typeof(CoursMetadata))]
    public partial class Cours
    {
        //we can create custom properties to represent combined / calculated fields for an object (record) in our database
        //[Display(Name = "Ship Info")]
        //public string ShipInfo
        //{
        //    get
        //    {
        //        return $"{ShipAddress} {ShipCity}, {ShipRegion}--{ShipCountry}";
        //    }
        //}

    }
}
