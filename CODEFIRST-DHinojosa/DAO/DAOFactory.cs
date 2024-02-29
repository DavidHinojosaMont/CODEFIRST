using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST_DHinojosa.DAO
{
    internal class DAOFactory
    {
        public static IDAOManager CreateDAOManager()
        {
            return new DAOManager();
        }
    }
}
