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
    internal class Orders
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int OrderNumber { get; set; }
        [Column(TypeName = "date")]
        public Date OrderDate { get; set; }
        [Column(TypeName = "date")]
        public Date RequiredDate { get; set; }
        [Column(TypeName = "date")]
        public Date ShippedDate { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Status { get; set; }
        [Column(TypeName = "text")]
        public string Comments { get; set; }

    }
}
