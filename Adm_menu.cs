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
    public partial class Adm_menu: Form
    {
        private string connectionString = "server=localhost;database=ych_pr;user=root;password=root;";
        public Adm_menu()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void grid_adm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM users", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                grid_adm.DataSource = dt;
            }
        }

        private void grid_adm_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(grid_adm.Rows[e.RowIndex].Cells["idusers"].Value);
                string columnName = grid_adm.Columns[e.ColumnIndex].Name;
                string newValue = grid_adm.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"UPDATE users SET {columnName}=@value WHERE idusers=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@value", newValue);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (grid_adm.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(grid_adm.SelectedRows[0].Cells["idusers"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteEmployeesQuery = "DELETE FROM employees WHERE users_idusers=@id";
                    MySqlCommand deleteEmployeesCmd = new MySqlCommand(deleteEmployeesQuery, conn);
                    deleteEmployeesCmd.Parameters.AddWithValue("@id", id);
                    deleteEmployeesCmd.ExecuteNonQuery();
                    string query = "DELETE FROM users WHERE idusers=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();   
                }
                LoadUsers();
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            // Пройдем по каждой строке в DataGridView и добавим данные в базу
            foreach (DataGridViewRow row in grid_adm.Rows)
            {
                // Пропускаем пустую строку для ввода
                if (row.IsNewRow) continue;

                // Получаем значения из ячеек
                string username = row.Cells["user_name"].Value?.ToString();
                string password = row.Cells["password"].Value?.ToString();
                string status = row.Cells["status"].Value?.ToString();

                // Проверка, существует ли уже пользователь с таким email (или username, если это уникальный идентификатор)
                bool userExists = false;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE password = @password OR user_name = @username";
                    MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@password", password);
                    cmdCheck.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        userExists = true; // Пользователь с таким email или username уже существует
                    }
                }

                // Если пользователя нет в базе, добавляем
                if (!userExists)
                {
                    int userId = 0;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        // Вставка нового пользователя
                        string queryInsertUser = "INSERT INTO users (user_name, password, status) VALUES (@username, @password, @status)";
                        MySqlCommand cmdInsertUser = new MySqlCommand(queryInsertUser, conn);
                        cmdInsertUser.Parameters.AddWithValue("@username", username);
                        cmdInsertUser.Parameters.AddWithValue("@password", password);
                        cmdInsertUser.Parameters.AddWithValue("@status", status);
                        cmdInsertUser.ExecuteNonQuery();

                        // Получаем ID вставленного пользователя
                        userId = (int)cmdInsertUser.LastInsertedId;
                    }

                    // Перезагружаем данные, чтобы отобразить добавленных пользователей
                    LoadUsers();
                }
            }
        }

        private void Adm_menu_Load(object sender, EventArgs e)
        {

        }

        private void adm_to_app_Click(object sender, EventArgs e)
        {
            AppMenu Menuform = new AppMenu();
            Menuform.Show();
            this.Hide();
        }
    }
}
