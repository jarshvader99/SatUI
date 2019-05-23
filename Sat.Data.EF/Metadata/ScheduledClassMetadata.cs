using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Data.EF//.Metadata
{
    public class ScheduledClassMetadata
    {
        //public int ScheduledClassID { get; set; }
        public int CourseID { get; set; }

        [Display(Name = "Instructor Name")]
        [StringLength(40, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string InstructorName { get; set; }

        [DisplayFormat(NullDisplayText = "NA")]
        public string Location { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime EndDate { get; set; }

        [DisplayFormat(NullDisplayText = "NA")]
        public Nullable<byte> EnrollmentMax { get; set; }
    }

    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass
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
