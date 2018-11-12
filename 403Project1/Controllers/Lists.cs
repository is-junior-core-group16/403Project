using _403Project1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace _403Project1.Controllers
{
    public static class Lists
    {
        [DisplayName("White List")]
        public static List<Software> WhiteList { get; set; }

        [DisplayName("Black List")]
        public static List<Software> BlackList { get; set; }

        [DisplayName("Approval Queue")]
        public static Queue<Software> AppQueue { get; set; }
    }
}