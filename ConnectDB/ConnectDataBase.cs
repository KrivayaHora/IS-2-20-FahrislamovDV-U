using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class ConnectDataBase
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
        public ConnectDataBase(string connect)
        {
            strConnect = connect;
        }
    }
}
