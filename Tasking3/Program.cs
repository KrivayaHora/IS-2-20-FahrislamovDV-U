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
    public class ConnectDB
    {
        string strConnect;
        MySqlConnection Conn;

        public MySqlConnection Connection()
        {
            Conn = new MySqlConnection(strConnect);
            return Conn;
        }
        public string ReturnConn()
        {
            return strConnect;
        }
        public ConnectDB(string connect)
        {
            strConnect = connect;
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
