using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricInfo.Models
{
    public class LiveScore
    {
        public int Id { get; set; }
        public string CountryA { get; set; }
        public string CountryB { get; set; }
        public string Score { get; set; }
        public int Overs { get; set; }
    }
}