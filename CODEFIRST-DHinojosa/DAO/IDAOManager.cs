using CODEFIRST_DHinojosa.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CODEFIRST_DHinojosa.DAO.DAOManager;

namespace CODEFIRST_DHinojosa.DAO
{
    internal interface IDAOManager
    {
        // Imports
        public bool ImportProductLines(String filename); //DONE
        public bool ImportProducts(String filename); //DONE
        public bool ImportOffices(String filename); //DONE
        public bool ImportEmployees(String filename); //DONE
        public bool ImportCustomers(String filename); //DONE
        public bool ImportPayments(String filename); //DONE
        public bool ImportOrders(String filename); //DONE
        public bool ImportOrderDetails(String filename); //DONE

        // ---------------------
        // Querys

        public List<ProductLines> GetProductLines(); //DONE
        public List<Products> GetProducts(); //DONE
        public List<Offices> GetOffices(); //DONE
        public List<Employees> GetEmployees(); //DONE
        public List<Customers> GetCustomers(); //DONE
        public List<Payments> GetPayments(); //DONE
        public List<Orders> GetOrders(); //DONE
        public List<OrderDetails> GetOrderDetails(); //DONE

        // ------------------
        // Filter

        public List<Customers> FilterCustomerName(string name); // DONE
        public List<Employees> FilterEmployeeName(string name); //DONE
        public List<Offices> FilterOfficeCity(string name); //DONE


        // ------------------
        // Others

        public object GetEmployeesOffices(); //DONE
        public object GetProductsProdutLines(ProductLine productLineEnum); //DONE

        // ------------------
        // CRUD

        public void InsertCustomer(Customers customer);
        public void DeleteCustomer(ushort number);
        public void InsertPayments(Payments payment);
        public void DeletePayments(string checkNumber);
        public void InsertOrder(Orders order);
        public void DeleteOrder(ushort orderNumber);

        // ------------------
        // Traverse

        public void TraverseStatusOrders(); //DONE
    }
}
