using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollection.Models
{
    public class Cities
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }

        [ForeignKey("State")]
        public string StateID { get; set; }
        public States State { get; set; }

        [ForeignKey("Zipcode")]
        public string ZipID { get; set; }
        public Zipcodes Zipcode { get; set; }
    }   
}