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
        //[Display(Name = "Full Name")]
        //public string NameJoin
        //{
        //    get
        //    {
        //        return $"{} {ShipCity}";
        //    }
        //}

    }
}
