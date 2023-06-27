using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal
{
    internal class Database
    {
        public static string strConnection = "datasource=localhost;username=root;password=;database=testedb";
        public static MySqlConnection conexao = new MySqlConnection(strConnection);
        public static string sql = "";
    }
}
