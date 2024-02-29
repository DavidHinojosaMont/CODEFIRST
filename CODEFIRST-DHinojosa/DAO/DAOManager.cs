using CODEFIRST_DHinojosa.MODEL;
using Microsoft.VisualBasic.FileIO;
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
        const string PRODUCTLINES = "PRODUCTLINES.csv";

        ProductsDBContext context = null;

        public DAOManager(ProductsDBContext context) { this.context = context; }

        public void ImportCustomers(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                Customers customers = new Customers()
                {
                    CustomerNumber = Convert.ToInt32(fields[0]),
                    CustomerName = fields[1],
                    ContactLastName = fields[2],
                    ContactFirstName = fields[3],
                    Phone = fields[4],
                    AddressLine1 = fields[5],
                    AddressLine2 = fields[6],
                    City = fields[7],
                    State = fields[8],
                    PostalCode = fields[9],
                    Country = fields[10],
                    SalesRepEmployeeNumber = Convert.ToInt32(fields[11]),
                    CreditLimit = Convert.ToDouble(fields[12])


                };

                context.Customers.Add(customers);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportEmployees(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                Employees employees = new Employees()
                {
                    EmployeeNumber = Convert.ToInt32(fields[0]),
                    LastName = fields[1],
                    FirstName = fields[2],
                    Extension = fields[3],
                    Email = fields[4],
                    OfficeCode = fields[5],
                    ReportsTo = Convert.ToInt32(fields[6]),
                    JobTitle = fields[7],
                };

                context.Employees.Add(employees);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportOffices(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                Offices offices = new Offices()
                {
                    OfficeCode = fields[0],
                    City = fields[1],
                    Phone = fields[2],
                    AddressLine1 = fields[3],
                    AddressLine2 = fields[4],
                    State = fields[5],
                    Country = fields[6],
                    PostalCode = fields[7],
                    Territory = fields[8],
                };

                context.Offices.Add(offices);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportOrderDetails(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                MODEL.OrderDetails orderDetails = new MODEL.OrderDetails()
                {
                    OrderNumber = Convert.ToInt32(fields[0]),
                    ProductCode = fields[1],
                    QuantityOrdered = Convert.ToInt32(fields[2]),
                    PriceEach = Convert.ToDouble(fields[3]),
                    OrderLineNumber = Convert.ToInt32(fields[4]),
                };

                context.OrderDetails.Add(orderDetails);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportOrders(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                Orders orders = new Orders()
                {
                    OrderNumber = Convert.ToInt32(fields[0]),
                    OrderDate = Convert.ToDateTime(fields[1]),
                    RequiredDate = Convert.ToDateTime(fields[2]),
                    ShippedDate = Convert.ToDateTime(fields[3]),
                    Status = fields[4],
                    Comments = fields[5],
                    CustomerNumber = Convert.ToInt32(fields[6]),
                };

                context.Orders.Add(orders);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportPayments(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();
                }

                Payments payments = new Payments()
                {
                    CustomerNumber = Convert.ToInt32(fields[0]),
                    CheckNumber = fields[1],
                    PaymentDate = Convert.ToDateTime(fields[2]),
                    Amount = Convert.ToDouble(fields[3])
                };

                context.Payments.Add(payments);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportProducts(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {

                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");
                    fields = parser.ReadFields();

                }
                    Products products = new Products()
                    {
                        ProductCode = fields[0],
                        ProductName = fields[1],
                        ProductLine = fields[2],
                        ProductScale = fields[3],
                        ProductVendor = fields[4],
                        productDescription = fields[5],
                        QuantityInStock = Convert.ToInt32(fields[6]),
                        BuyPrice = Convert.ToDouble(fields[7]),
                        MSRP = Convert.ToDouble(fields[8])
                    };
                

                context.Products.Add(products);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }

        public void ImportProductLines(string filename)
        {
            StreamReader streamReader = new StreamReader(filename);
            string line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            string[] fields;

            while (line != null)
            {
                using (TextFieldParser parser = new TextFieldParser(new StringReader(line)))
                {
                    parser.HasFieldsEnclosedInQuotes = true;
                    parser.SetDelimiters(",");

                    fields = parser.ReadFields();
                }
                ProductLines productLines = new ProductLines
                {
                    ProductLine = fields[0],
                    TextDescription = fields[1],
                    htmlDescription = fields[2],
                    Image = Convert.FromBase64String(fields[3])
                };
                context.ProductLines.Add(productLines);
                line = streamReader.ReadLine();
            }
            context.SaveChanges();
        }
    }
}
