using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RR.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool GardaVetted { get; set; }
        public bool Cox { get; set; }
        public bool WeatherCaller { get; set; }

        public override string ToString()
        {
            return this.MemberID+" "+this.Name;
        }
    }
}