using ConnectDB;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tasking5
{
    public partial class Task5 : Form
    {
        MySqlConnection conn;
        ConnectDataBase Connect = new ConnectDataBase("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();
        public void GetTable()
        {
            DT.Clear();
            string sqlview = "SELECT * FROM `t_Uchebka_Fahrislamov`";
            conn.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, conn);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            conn.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;




            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;



            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        public Task5()
        {
            InitializeComponent();
        }

        private void Task5_Load(object sender, EventArgs e)
        {
            conn = Connect.Connection();
            GetTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string fio = FIO.Text;
                string datetime = DateTime.Text;

                string sql = "INSERT INTO `t_Uchebka_Fahrislamov`(fioStud, datetimeStud) VALUES (@f, @dt)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@f", MySqlDbType.VarChar).Value = fio;
                cmd.Parameters.Add("@dt", MySqlDbType.VarChar).Value = datetime;

                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Пользователь добавлен");
                else
                    MessageBox.Show("Ошибка добавления");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTable();
        }
    }
}
