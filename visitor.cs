using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ych_pr
{
    public partial class visitor: Form
    {
        private string connectionString = "server=localhost;database=ych_pr;user=root;password=root;";
        private DataGridView dataGridView;
        public visitor()
        {
            InitializeComponent();
            LoadData("");
        }
        private void LoadData(string filter)
        {
            string query = "SELECT * FROM visitor";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    grid_visit.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
