using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _403Project1.Models
{
    public class Software : Requests
    {

        [Key]
        public int ChangeID { get; set; }

        private bool blackListed;

        public bool BlackListed
        {
            get { return blackListed; }
            set {

                blackListed = value;
                whiteListed = !value;
            }
        }


        private bool whiteListed;

        public bool WhiteListed
        {
            get { return whiteListed; }
            set {
                whiteListed = value;
                blackListed = !value;
            }
        }

        public Software(string name, string type)
        {

        }
    }
}