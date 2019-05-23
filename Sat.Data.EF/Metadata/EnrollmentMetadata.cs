using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Data.EF//.Metadata
{
    public class EnrollmentMetadata
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int ScheduledClassID { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "NA", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
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
