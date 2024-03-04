using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    internal class Customers
    {
        public Customers()
        {
            Payments = new HashSet<Payments>();
            Orders = new HashSet<Orders>();
        }
        [Key]
        [Column(TypeName ="int(11)")]
        public int CustomerNumber { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ContactLastName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ContactFirstName { get; set; }
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
        public string City { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string State { get; set; }
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string PostalCode { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Country { get; set; }
        [ForeignKey("Employees")]
        [Column(TypeName = "int(11)")]
        public int? SalesRepEmployeeNumber { get; set; }
        public Employees Employees { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double CreditLimit { get; set; }

        public ICollection<Payments> Payments { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
