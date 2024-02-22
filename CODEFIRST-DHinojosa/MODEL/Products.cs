using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    internal class Products
    {
        [Key]
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string ProductCode { get; set; }
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string ProductName { get; set; }
        [ForeignKey("ProductLines")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ProductLine { get; set; }
        public ProductLines ProductLines { get; set; }
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        public string ProductScale { get; set; }
        [Column(TypeName = "text")]
        public string productDescription { get; set; }
        [Column(TypeName = "smallint(6)")]
        public int QuantityInStock { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double BuyPrice { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public double MSRP { get; set; }

    }
}
