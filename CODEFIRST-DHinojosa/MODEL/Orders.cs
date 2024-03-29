﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CODEFIRST_DHinojosa.MODEL
{
    public class Orders
    {
        public Orders() {

            OrderDetails = new HashSet<OrderDetails>();
        }
        [Key]
        [Column(TypeName = "int(11)")]
        public int OrderNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime RequiredDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ShippedDate { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Status { get; set; }
        [Column(TypeName = "text")]
        public string Comments { get; set; }
        [ForeignKey("Customers")]
        [Column(TypeName = "int(11)")]
        public int CustomerNumber { get; set; }
        public Customers Customers { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
