using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_2_20_FahrislamovDV_U
{
    public partial class Task2 : Form
    {
        public class ConnectDB
        {

            string strconn;

            public string ReturnConn()
            {
                return strconn;
            }
            public ConnectDB(string a)
            {
                strconn = a;
            }
        }
        ConnectDB connect = new ConnectDB("server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;");
        MySqlConnection my;
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            my = new MySqlConnection(connect.ReturnConn());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                my.Open();
                MessageBox.Show("Подключено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением, причина ошибки:" + ex.Message);
            }
            finally
            {
                my.Close();
            }
        }
    }
}
