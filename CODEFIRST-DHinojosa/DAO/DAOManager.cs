using CODEFIRST_DHinojosa.MODEL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.DAO
{
    internal class DAOManager : IDAOManager
    {
        private ProductsDBContext context = null;
        public DAOManager(ProductsDBContext context) {
            this.context = context;
        }

        public void ImportCustomers(string filename)
        {
            throw new NotImplementedException();
        }

        public void ImportEmployees(string filename)
        {
            throw new NotImplementedException();
        }

        public void ImportOffices(string filename)
        {
            throw new NotImplementedException();
        }

        public void ImportOrderDetails(string filename)
        {
            throw new NotImplementedException();
        }

        public void ImportOrders(string filename)
        {
            throw new NotImplementedException();
        }

        public void ImportPayments(string filename)
        {
            throw new NotImplementedException();
        }

        public List<ProductLines> ImportProductLines(String filename)
        {
            List<ProductLines> productLines = new List<ProductLines>();

            return productLines;
        }

        public void ImportProducts(string filename)
        {
            throw new NotImplementedException();
        }

        void IDAOManager.ImportProductLines(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
