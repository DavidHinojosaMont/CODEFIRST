using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    internal class OrderDetails
    {
        [Key]
        [ForeignKey("Orders")]
        [Column(TypeName = "int(11)")]
        public int OrderNumber { get; set; }
        public Orders Orders { get; set; }
        [ForeignKey("Products")]
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string ProductCode { get; set; }
        public Products Products { get; set; }
        [Column(TypeName = "int(11)")]
        public int QuantityOrdered { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double PriceEach { get; set; }
        [Column(TypeName = "smallint(6)")]
        public int OrderLineNumber { get; set; }

    }
}
