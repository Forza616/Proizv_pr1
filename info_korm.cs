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
    public partial class info_korm : Form
    {
        private string connectionString = "server=localhost;database=ych_pr;user=root;password=root;";
        private DataGridView dataGridView;
        public info_korm()
        {
            InitializeComponent();
            LoadData("");
        }
        private void LoadData(string filter)
        {
            string query = "SELECT * FROM food";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid_korm.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void info_korm_Load(object sender, EventArgs e)
        {

        }

        private void but_korm_Click(object sender, EventArgs e)
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show();
            this.Close();
        }
    }
}
