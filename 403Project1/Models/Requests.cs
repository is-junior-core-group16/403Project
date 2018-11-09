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
        public string Software { get; set; }

    }
}