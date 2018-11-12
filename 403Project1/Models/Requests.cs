using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class Requests
    {
        [Key]
        public int RequestID { get; set; }

        
        [Required(ErrorMessage ="Please enter your name")]
        [Display(Name ="Full Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter your manager's name")]
        [Display(Name = "Manager's Name")]
        public string managerName { get; set; }

        [Required(ErrorMessage = "Please enter the software you'd like to request")]
        [Display(Name = "Software Requested")]
        public string SoftwareName { get; set; }
        //Sorry the syntax is inconsistent..

        [Required(ErrorMessage ="Please enter the software Type")]
        [Display(Name = "Software Type")]
        public string softwareType { get; set; }

    }
}