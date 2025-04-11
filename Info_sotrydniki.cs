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

namespace ych_pr
{
    public partial class Info_sotrydniki : Form
    {

        private string connectionString = "server=localhost;database=ych_pr;user=root;password=root;";
        private DataGridView dataGridView;
        public Info_sotrydniki()
        {
            InitializeComponent();
            LoadData("Вся информация");
        }


        private void LoadData(string filter)
        {
            string query = "SELECT * FROM employees"; // Запрос по умолчанию

            if (filter == "Взаимодействующие с животными")
            {
                query = "SELECT * FROM employees WHERE position IN ('Ветеринар', 'Дрессировщик')";
            }
            else if (filter == "Не взаимодействующие с животными")
            {
                query = "SELECT * FROM employees WHERE position IN ('Уборщица', 'Гид')";
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Grid_sotr.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(comboBox1.SelectedItem.ToString());
        }

        private void Info_sotrydniki_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show(); // Показываем предыдущую форму
            this.Close();
        }
    }
}