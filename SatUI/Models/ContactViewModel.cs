using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SatUI.Models
{
    public class ContactViewModel
    {
        //fields

        //properties
        [StringLength(100, ErrorMessage = "* Less than 100 characters")]
        [Required(ErrorMessage = "* Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* Required")]
        [EmailAddress(ErrorMessage = "Please use a valid email")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "* Less than 50 characters")]
        [Required(ErrorMessage = "* A subject is required")]
        public string Subject { get; set; }

        [StringLength(251, ErrorMessage = "* You've exceeding the character count.")]
        [Required(ErrorMessage = "* Required")]

        public string Message { get; set; }
        //ctors

        //methods
    }
}