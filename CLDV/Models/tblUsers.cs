using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Data.SqlClient;

namespace CLDV.Models
{
    public class tblUsers : Controller
    {
        public static string con_string = "Server=tcp:cldv10263164-sql-server.database.windows.net,1433;Initial Catalog=CLDV-Database;Persist Security Info=False;User ID=st10263164;Password=Dieg011748;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);

        public IActionResult Index()
        {
            return View();
        }

        public int insertUser()
        {
            string sql = "INSERT INTO tblUsers (username, userSurname, user, userEmail)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Name", .Name);
            cmd.Parameters.AddWithValue("@Surname", .Surname);
            cmd.Parameters.AddWithValue("@Email", .Email);
            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
        

    }
}
