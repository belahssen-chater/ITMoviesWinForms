using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ITMovies
{
    public class Utilities
    {
        public static string SALT = "$2a$11$jHAsYq4eTmgVkVDPqAeKbe";
        public static string hashPwd(string pwd)
        {
            return BCrypt.Net.BCrypt.HashPassword(pwd, SALT);
        }

    }
}
