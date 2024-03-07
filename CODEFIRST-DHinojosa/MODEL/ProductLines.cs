using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    public class ProductLines
    {

        public ProductLines()
        {
            Products = new HashSet<Products>();
        }
        [Key]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ProductLine { get; set; }
        [Column(TypeName = "varchar(4000)")]
        [StringLength(4000)]
        public string TextDescription { get; set; }
        [Column(TypeName ="mediumtext")]
        public string htmlDescription { get; set; }
        [Column(TypeName = "mediumblob")]
        public byte[] Image { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
