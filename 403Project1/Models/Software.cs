using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class Software
    {

        [Key]
        public int ChangeID { get; set; }

        [Required]
        public string Change { get; set; }
    }
}