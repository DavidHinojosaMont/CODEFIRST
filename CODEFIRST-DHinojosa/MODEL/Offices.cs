﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    public class Offices
    {
        public Offices()
        {
            Employees = new HashSet<Employees>();
        }
        [Key]
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        public string OfficeCode { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string City { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string AddressLine1 { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string AddressLine2 { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string State { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string PostalCode { get; set; }
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        public string Territory { get; set; }

        public ICollection<Employees> Employees { get; set; }
    }
}
