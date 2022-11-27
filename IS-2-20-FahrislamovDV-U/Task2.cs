using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IS_2_20_FahrislamovDV_U
{
    public partial class Task2 : Form
    {
        public class DBConnect
        {
            public static MySqlConnection GetConnection(MySqlConnection mySql)
            {
                try
                {
                    MessageBox.Show("Подключение возвращено");
                    return mySql;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Подключение не найдено"+ex.Message);
                    return null;
                }
               
            }
        }
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            string connect = $"server=chuc.caseum.ru;port=33333;user=uchebka;database=uchebka;password=uchebka;";
            MySqlConnection Connection = new MySqlConnection(connect);
            try
            {
                DBConnect.GetConnection(Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошло исключение"+ ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
