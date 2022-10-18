using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace ITMovies
{
    public class Database
    {
        public static string connectionStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MoviesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection connection = new SqlConnection(connectionStr);

    }
}
