using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Data.EF//.Metadata
{
    public class StudentStatusMetadata
    {
        //public int StudentStatusID { get; set; }

        [Display(Name = "Status Name")]
        [StringLength(40, ErrorMessage = "You have entered too many characters. Please try again.")]
        public string StatusName { get; set; }

        [Display(Name = "Status Description")]
        [StringLength(4000, ErrorMessage = "Please limit descriptions to 4000 characters or less.")]
        [DisplayFormat(NullDisplayText = "NA")]
        [UIHint("MultilineText")]

        public string StatusDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus
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
