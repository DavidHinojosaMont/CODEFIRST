using CODEFIRST_DHinojosa.MODEL;
using Microsoft.EntityFrameworkCore;
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
        ProductsDBContext context = null;

        public DAOManager(ProductsDBContext context) { this.context = context; }

        public bool ImportCustomers(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        Customers customers = new Customers();

                        customers.CustomerNumber = Convert.ToInt32(fields[0]);
                        customers.CustomerName = fields[1];
                        customers.ContactLastName = fields[2];
                        customers.ContactFirstName = fields[3];
                        customers.Phone = fields[4];
                        customers.AddressLine1 = fields[5];
                        customers.AddressLine2 = fields[6];
                        customers.City = fields[7];
                        customers.State = fields[8];
                        customers.PostalCode = fields[9];
                        customers.Country = fields[10];
                        if (fields[11] == "NULL") customers.SalesRepEmployeeNumber = null;
                        else customers.SalesRepEmployeeNumber = Convert.ToInt32(fields[11]);
                        customers.CreditLimit = Convert.ToDouble(fields[12]);

                        context.Customers.Add(customers);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("Error en importar products: " + ex.Message); }

            return done;
        }

        public bool ImportEmployees(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser? parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[]? fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        Employees employees = new Employees();

                        employees.EmployeeNumber = Convert.ToInt32(fields[0]);
                        employees.FirstName = fields[1];
                        employees.LastName = fields[2];
                        employees.Extension = fields[3];
                        employees.Email = fields[4];
                        employees.OfficeCode = fields[5];
                        if (fields[6] == "NULL") employees.ReportsTo = null;
                        else employees.ReportsTo = Convert.ToInt32(fields[6]);
                        employees.JobTitle = fields[7];

                        context.Employees.Add(employees);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }

        public bool ImportOffices(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

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
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }


        public bool ImportOrderDetails(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        OrderDetails orderDetails = new OrderDetails()
                        {
                            OrderNumber = Convert.ToInt32(fields[0]),
                            ProductCode = fields[1],
                            QuantityOrdered = Convert.ToInt32(fields[2]),
                            PriceEach = Convert.ToDouble(fields[3]),
                            OrderLineNumber = Convert.ToInt32(fields[4]),
                        };

                        context.OrderDetails.Add(orderDetails);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }

        public bool ImportOrders(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        Orders orders = new Orders();

                        orders.OrderNumber = Convert.ToInt32(fields[0]);
                        orders.OrderDate = Convert.ToDateTime(fields[1]);
                        orders.RequiredDate = Convert.ToDateTime(fields[2]);
                        if (fields[3] == "NULL") orders.ShippedDate = null;
                        else orders.ShippedDate = Convert.ToDateTime(fields[3]);
                        orders.Status = fields[4];
                        orders.Comments = fields[5];
                        orders.CustomerNumber = Convert.ToInt32(fields[6]);

                        context.Orders.Add(orders);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }

        public bool ImportPayments(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        Payments payments = new Payments()
                        {
                            CustomerNumber = Convert.ToInt32(fields[0]),
                            CheckNumber = fields[1],
                            PaymentDate = Convert.ToDateTime(fields[2]),
                            Amount = Convert.ToDouble(fields[3])
                        };

                        context.Payments.Add(payments);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }

        public bool ImportProducts(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

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
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }

        public bool ImportProductLines(string filename)
        {
            bool done = false;
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filename))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;

                    string[] fields = parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        fields = parser.ReadFields();

                        ProductLines productLines = new ProductLines
                        {
                            ProductLine = fields[0],
                            TextDescription = fields[1],
                            htmlDescription = fields[2],
                            Image = Convert.FromBase64String(fields[3])
                        };

                        context.ProductLines.Add(productLines);
                        context.SaveChanges();
                    }
                    done = true;
                }
            }
            catch (Exception ex) { Console.WriteLine("ERROR: " + ex.Message); }

            return done;
        }
    }
}
