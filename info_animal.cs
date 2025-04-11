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
    public partial class info_animal : Form
    {
        private string connectionString = "server=localhost;database=ych_pr;user=root;password=root;";
        private DataGridView dataGridView;
        public info_animal()
        {
            InitializeComponent();
            LoadData("Вся информация");
        }


        private void LoadData(string filter)
        {
            string query = "SELECT * FROM animals"; // Запрос по умолчанию

            if (filter == "Земноводное")
            {
                query = "SELECT * FROM animals WHERE type IN ('Земноводное')";
            }
            else if (filter == "Млекопитающее")
            {
                query = "SELECT * FROM animals WHERE type IN ('Млекопитающее')";
            }
            else if (filter == "Птица")
            {
                query = "SELECT * FROM animals WHERE type IN ('Птица')";
            }


            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid_animal.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData(comboBox2.SelectedItem.ToString());
        }

        private void but_anim_Click(object sender, EventArgs e)
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show(); // Показываем предыдущую форму
            this.Close();
        }

        private void info_animal_Load(object sender, EventArgs e)
        {

        }
    }
}
