using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayerLibrary;
namespace BooksDAL
{
    public class AuthorDAL
    {

        public bool InsertAuthorToDB(AuthorsBAL author)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=PLATOW42L0560;Initial Catalog=pubs;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("sp_Insert_Author", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Author_id", author.AuthorID);

                cn.Open();
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
           

            return status;

        }
    }
}
