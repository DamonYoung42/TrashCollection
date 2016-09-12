using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrashCollection.Models
{
    public class Pickups
    {
        [Key]
        public int PickupID { get; set; }
        public DateTime PickupDate { get; set; }

        //this bool is "active"/"inactive"
        public bool Status { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customers Customer { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employees Employee { get; set; }


    }
}