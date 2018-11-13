using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class AllRequests
    {
        [DisplayName("Request ID")]
        [Key]
        public string RequestID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Software Request")]
        public string SoftwareRequest { get; set; }
        [DisplayName("Software Type")]
        public string SoftwareType{ get; set; }
        [DisplayName("List Type")]
        public string ListType { get; set; }
    }
}