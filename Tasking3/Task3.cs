using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Tasking3;

namespace IS_2_20_FahrislamovDV_U
{
    public partial class Task3 : Form
    {
        MySqlConnection Connection;
        ConnectDB Connect = new ConnectDB("server=chuc.caseum.ru;port=33333;username=st_2_20_24;password=54843478;database=is_2_20_st24_KURS");
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        BindingSource BindingS = new BindingSource();
        DataTable DT = new DataTable();
        public void GetCPU()
        {
            DT.Clear();
            string sqlview = "SELECT Items.ID AS `Код`, Items.Title AS `Название`, Type.title AS `Тип товара`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.Type_id = 2";
            Connection.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, Connection);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            Connection.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;



            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;


            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        
        public Task3()
        {
            InitializeComponent();
        }
        
        private void Task3_Load(object sender, EventArgs e)
        {
            Connection = Connect.Connection();
            GetCPU();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            Connection.Open();
            string info1 = "";
            string info2 = "";
            string info3 = "";
            string info4 = "";
            string info5 = "";
            string info6 = "";
            string sql = $"SELECT Items.ID AS `код`, Manufacture.title AS `Производитель`, Items.Title AS `Название`, Type.title AS `Тип товара`,Items.In_storage AS `На хранении`, Items.Price AS `Цена` FROM Items JOIN Type ON Items.Type_id = Type.id JOIN Manufacture ON Items.Manufacture_id = Manufacture.id WHERE Items.ID = "+ id;
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                info1 = reader[0].ToString();
                info2 = reader[1].ToString();
                info3 = reader[2].ToString();
                info4 = reader[3].ToString();
                info5 = reader[4].ToString();
                info6 = reader[5].ToString();
            }
            reader.Close();
            MessageBox.Show("Код: " +info1 +"\n"+ "Производитель: " +  info2 + "\n" + "Модель процессора: " + info3 + "\n" + "Тип товара: " + info4 + "\n" + "На хранении: " + info5 + "\n" + "Цена: " + info6 + "\n", "Информация о записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
            
        }
    }
}
