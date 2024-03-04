using CODEFIRST_DHinojosa.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.DAO
{
    internal interface IDAOManager
    {
        public bool ImportProductLines(String filename);
        public bool ImportProducts(String filename);
        public bool ImportOffices(String filename);
        public bool ImportEmployees(String filename);
        public bool ImportCustomers(String filename);
        public bool ImportPayments(String filename);
        public bool ImportOrders(String filename);
        public bool ImportOrderDetails(String filename);
    }
}
