using CODEFIRST_DHinojosa.DAO;
using CODEFIRST_DHinojosa.MODEL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static CODEFIRST_DHinojosa.DAO.DAOManager;
using static System.Net.Mime.MediaTypeNames;

namespace CODEFIRST_DHinojosa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string FILEPRODUCTLINES = "PRODUCTLINES.csv";
        const string FILEPRODUCTS = "PRODUCTS.csv";
        const string FILEOFFICES = "OFFICES.csv";
        const string FILEMPLOYEES = "EMPLOYEES.csv";
        const string FILECUSTOMERS = "CUSTOMERS.csv";
        const string FILEPAYMENTS = "PAYMENTS.csv";
        const string FILEORDERS = "ORDERS.csv";
        const string FILEORDERDETAILS = "ORDERDETAILS.csv";
        private ProductsDBContext context = new ProductsDBContext();
        IDAOManager manager;

        public MainWindow()
        {
            InitializeComponent();
            manager = DAOFactory.CreateDAOManager(context);
            manager.ImportProductLines(FILEPRODUCTLINES);
            manager.ImportProducts(FILEPRODUCTS);
            manager.ImportOffices(FILEOFFICES);
            manager.ImportEmployees(FILEMPLOYEES);
            manager.ImportCustomers(FILECUSTOMERS);
            manager.ImportPayments(FILEPAYMENTS);
            manager.ImportOrders(FILEORDERS);
            manager.ImportOrderDetails(FILEORDERDETAILS);

            dgrProductLines.ItemsSource = manager.GetProductLines();
            dgrProducts.ItemsSource = manager.GetProducts();
            dgrOffices.ItemsSource = manager.GetOffices();
            dgrEmployees.ItemsSource = manager.GetEmployees();
            dgrCustomers.ItemsSource = manager.GetCustomers();
            dgrPayments.ItemsSource = manager.GetPayments();
            dgrOrders.ItemsSource = manager.GetOrders();
            dgrOrderDetails.ItemsSource = manager.GetOrderDetails();

            dgrGetEmployeesOffices.ItemsSource = (IEnumerable)manager.GetEmployeesOffices();
        }

        #region Refresh

        private void btnRefreshPL_Click(object sender, RoutedEventArgs e)
        {
            dgrProductLines.ItemsSource = manager.GetProductLines();
        }

        private void btnRefreshProducts_Click(object sender, RoutedEventArgs e)
        {
            dgrProducts.ItemsSource = manager.GetProducts();
        }

        private void btnRefreshOffices_Click(object sender, RoutedEventArgs e)
        {
            dgrOffices.ItemsSource = manager.GetOffices();
        }

        private void btnRefreshEmployees_Click(object sender, RoutedEventArgs e)
        {
            dgrEmployees.ItemsSource = manager.GetEmployees();
        }

        private void btnRefreshCustomers_Click(object sender, RoutedEventArgs e)
        {
            dgrCustomers.ItemsSource = manager.GetCustomers();
        }

        private void btnRefreshPayments_Click(object sender, RoutedEventArgs e)
        {
            dgrPayments.ItemsSource = manager.GetPayments();
        }

        private void btnRefreshOrders_Click(object sender, RoutedEventArgs e)
        {
            dgrOrders.ItemsSource = manager.GetOrders();
        }

        private void btnRefreshOD_Click(object sender, RoutedEventArgs e)
        {
            dgrOrderDetails.ItemsSource = manager.GetOrderDetails();
        }

        #endregion
        private void btnFilterOffices_Click(object sender, RoutedEventArgs e)
        {
            if(tbOfficeNameFilter.Text != null)
                dgrFilterOffices.ItemsSource = manager.FilterOfficeCity(tbOfficeNameFilter.Text);
        }

        private void btnFilterEmployees_Click(object sender, RoutedEventArgs e)
        {
            if(tbEmployeesNameFilter.Text != null)
                dgrFilterEmployees.ItemsSource = manager.FilterEmployeeName(tbEmployeesNameFilter.Text);
        }

        private void btnFilterCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (tbCustomerNameFilter.Text != null) 
                dgrFilterCustomer.ItemsSource = manager.FilterCustomerName(tbCustomerNameFilter.Text);
        }

        private void btnTravess_Click(object sender, RoutedEventArgs e)
        {
            manager.TraverseStatusOrders();
            StreamReader streamReader = new StreamReader("StatusOrders.txt");
            string text = streamReader.ReadToEnd(); 
            tbTravess.Text = text;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customers customers = new Customers();

            customers.CustomerNumber = Convert.ToInt32(tbCustomerNumber.Text);
            customers.CustomerName = tbCustomerName.Text;
            customers.ContactLastName = tbContactLastName.Text;
            customers.ContactFirstName = tbContactFirstName.Text;
            customers.Phone = tbPhone.Text; 
            customers.AddressLine1 = tbAddressLine1.Text;
            customers.AddressLine2 = tbAddressLine2.Text;
            customers.City = tbCity.Text;
            customers.State = tbState.Text;
            customers.PostalCode = tbPostalCode.Text;
            customers.Country = tbCountry.Text;
            customers.SalesRepEmployeeNumber = Convert.ToInt32(tbSalesRepEmployeeNumber.Text);
            customers.CreditLimit = Convert.ToDouble(tbCreditLimit.Text);

            manager.InsertCustomer(customers);
        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            manager.DeleteCustomer(Convert.ToUInt16(tbCustomerNumber.Text));
        }

        private void btnAddPayment_Click(object sender, RoutedEventArgs e)
        {
            Payments newPayment = new Payments();
            newPayment.CustomerNumber = Convert.ToInt32(tbPaymentCustomerNumber.Text);
            newPayment.CheckNumber = tbPaymentCheckNumber.Text;
            newPayment.PaymentDate = Convert.ToDateTime(dtpPaymentDate.Text);
            newPayment.Amount = Convert.ToDouble(tbAmount.Text);
            manager.InsertPayments(newPayment);
        }

        private void btnDeletePayment_Click(object sender, RoutedEventArgs e)
        {
            manager.DeletePayments(tbPaymentCheckNumber.Text);
        }

        private void btnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();

            orders.OrderNumber = Convert.ToInt32(tbOrderNumber.Text);
            orders.OrderDate = Convert.ToDateTime(dtpOrderDate.Text);
            orders.RequiredDate = Convert.ToDateTime(dtpRequiredDate.Text);
            orders.ShippedDate = Convert.ToDateTime(dtpShippedDate.Text);
            orders.Status = tbStatus.Text;
            orders.Comments = tbComments.Text;
            orders.CustomerNumber = Convert.ToInt32(tbOrderCustomerN.Text);

            manager.InsertOrder(orders);
        }

        private void btnDeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            manager.DeleteOrder(Convert.ToUInt16(tbOrderNumber.Text));
        }

        private void cmbPL_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductLine pl = ProductLine.ClassicCar;

            switch (cmbPL.SelectedIndex)
            {
                case 0:
                    pl = ProductLine.ClassicCar;
                    break;
                case 1:
                    pl = ProductLine.Motorcycles;
                    break;
                case 2:
                    pl = ProductLine.Planes;
                    break;
                case 3:
                    pl = ProductLine.Ships;
                    break;
                case 4:
                    pl = ProductLine.Trains;
                    break;
                case 5:
                    pl = ProductLine.TrucksAndBuses;
                    break;
                case 6:
                    pl = ProductLine.VintageCars;
                    break;
            }


            dgrPLE.ItemsSource = (IEnumerable)manager.GetProductsProdutLines(pl);
        }
    }
}
