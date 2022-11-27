using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IS_2_20_FahrislamovDV_U;
using MySql.Data.MySqlClient;

namespace Tasking3
{
    class ConnectDB
    {
        public static MySqlConnection GetConnection(MySqlConnection mySql)
        {
            return mySql;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Task3());
        }
    }
}
