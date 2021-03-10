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
                connection.Open();

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void create_Category(string categoryName)
        {

        }

        public SqlDataReader list_Cocktail_Category(string choice="Cocktail")
        {
            using (SqlConnection sqlConnection = getConnection())
            {
                SqlDataReader sqlDatareader;
                string sql;
                if (choice == "Cocktail")
                    sql = "SELECT cocktail_Id, cocktail_name, difficulty_level, quotation, category_Id FROM tbl_cocktail ORDER BY cocktail_name"; 
                else
                    sql = "SELECT category_Id, category FROM tbl_category ORDER BY category"; 
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                sqlDatareader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlDatareader;
            }
        }

        public SqlDataReader get_Information(int ID, string choice= "Cocktail")
        {
            using (SqlConnection sqlConnection = getConnection())
            {
                string sql;
                if (choice == "Cocktail")
                    sql = "SELECT cocktail_name, difficulty_level, quotation, category_Id, cocktail_Id FROM  tbl_cocktail WHERE cocktail_ID = " + ID;
                else
                    sql = "SELECT category_Id, category FROM tbl_category WHERE category_Id = " + ID;
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return sqlDataReader;
            }
        }


    }
}
