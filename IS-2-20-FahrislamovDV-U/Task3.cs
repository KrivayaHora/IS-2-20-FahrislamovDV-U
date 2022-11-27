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

namespace IS_2_20_FahrislamovDV_U
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        private void Task3_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        }
    }
}
