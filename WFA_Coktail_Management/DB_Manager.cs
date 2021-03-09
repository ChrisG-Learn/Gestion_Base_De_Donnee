using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WFA_Coktail_Management
{
    class DB_Manager : Config
    {
        public void create_Cocktail(string name, string difficulty, int quotation, int category)
        {
            using (SqlConnection connection = getConnection())
            {
                string sql= "createCocktail" ;
                SqlCommand sqlCommand = new SqlCommand(sql, connection);

                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                sqlCommand.Parameters.Add("@Level", SqlDbType.VarChar, 50);
                sqlCommand.Parameters.Add("@Quotation", SqlDbType.Int);
                sqlCommand.Parameters.Add("@Category", SqlDbType.Int);

                sqlCommand.Parameters["@Name"].Value = name;
                sqlCommand.Parameters["@Level"].Value = difficulty;
                sqlCommand.Parameters["@Quotation"].Value = quotation;
                sqlCommand.Parameters["@Category"].Value = category;
            }
        }
    }
}
