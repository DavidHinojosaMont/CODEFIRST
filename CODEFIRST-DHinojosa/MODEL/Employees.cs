using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.MODEL
{
    internal class Employees
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int EmployeeNumber { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        public string Extension { get; set; }
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string Email { get; set; }
        [ForeignKey("Offices")]
        [Column(TypeName = "varchar(10)")]
        [StringLength(10)]
        public string OfficeCode { get; set; }
        public Offices Offices { get; set; }
        [ForeignKey("Employees")]
        [Column(TypeName = "int(11)")]
        public int? ReportsTo { get; set; }
        public Employees employeeNumber { get; set; }
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string JobTitle { get; set; }
    }
}
