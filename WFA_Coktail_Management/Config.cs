using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WFA_Coktail_Management
{
    class Config
    {
       protected SqlConnection GetConnection()
        {
            SqlConnection Cnn = new SqlConnection();
            Cnn.ConnectionString = "Data Source=LAPTOP-M4VGGB05;Initial Catalog=SD-CG_Travail1_DB;Integrated Security=True";
            return Cnn;
        }
    }
}
