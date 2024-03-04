using CODEFIRST_DHinojosa.DAO;
using System;
using System.Collections.Generic;
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

namespace CODEFIRST_DHinojosa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string FILEPRODUCTLINES = "PRODUCTLINES.csv";
        const string FILEPRODUCTS = "PRODUCTS.csv";
        private ProductsDBContext context = new ProductsDBContext();
        IDAOManager manager;

        public MainWindow()
        {
            InitializeComponent();
            manager = DAOFactory.CreateDAOManager(context);
            manager.ImportProducts(FILEPRODUCTS);
        }
    }
}
