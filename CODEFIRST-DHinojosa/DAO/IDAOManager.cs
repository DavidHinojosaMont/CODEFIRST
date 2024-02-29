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
        public void ImportProductLines(String filename);
        public void ImportProducts(String filename);
        public void ImportOffices(String filename);
        public void ImportEmployees(String filename);
        public void ImportCustomers(String filename);
        public void ImportPayments(String filename);
        public void ImportOrders(String filename);
        public void ImportOrderDetails(String filename);
    }
}
