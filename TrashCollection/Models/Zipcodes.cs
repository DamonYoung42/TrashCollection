using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollection.Models
{
    public class Zipcodes
    {
        [Key]
        public int ZipID {get; set;}
        public string Zipcode { get; set; }


    }
}