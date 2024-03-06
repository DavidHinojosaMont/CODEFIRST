using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    internal class Payments
    {
        [ForeignKey("Customers")]
        [Column(TypeName = "int(11)")]
        public int CustomerNumber { get; set; }
        public Customers Customers { get; set; }
        [Key]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string CheckNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime PaymentDate { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double Amount { get; set; }
    }
}
