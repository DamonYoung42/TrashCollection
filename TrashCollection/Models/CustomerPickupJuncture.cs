using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollection.Models
{
    public class CustomerPickupJuncture
    {
        [Key]
        public int CustomerPickupJunctureID {get; set;}

        [ForeignKey("Customers")]
        public int CustomerID { get; set; }

        public Customers Customer { get; set; }

        [ForeignKey("Pickup")]
        public int PickupID { get; set; }
        public Pickups Pickup { get; set; }


    }
}