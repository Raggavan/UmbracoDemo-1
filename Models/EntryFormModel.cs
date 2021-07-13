using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoInternal.Models
{
    public class EntryFormModel
    {
        [Required]
        public string userName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailID { get; set; }

        [Required]
        public string PolicyNo { get; set; }

        [Required]
        public string DOB { get; set; }
    }
}