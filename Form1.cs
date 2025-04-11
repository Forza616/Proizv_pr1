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
    public partial class Form1 : Form
    {
        int countlogin = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=ych_pr;Username=root;Password=root;";
            

                string login = txtLogin.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Логин и пароль не могут быть пустыми.");
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT status FROM users WHERE user_name = @login AND password = @password";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@login", login);
                            command.Parameters.AddWithValue("@password", password); // В реальном проекте не храните пароли в открытом виде!
                            object result = command.ExecuteScalar();

                            
                            if(result!=null)
                            {
                                string status = result.ToString();
                                if (status == "администратор")
                                {
                                    MessageBox.Show("Добро пожаловать Администратор!");
                                    Adm_menu Admform = new Adm_menu();
                                    Admform.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Добро пожаловать Сотрудник!");
                                    AppMenu Menuform = new AppMenu();
                                    Menuform.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                countlogin--;
                            if(countlogin >0)
                                label3.Text = $"Количество попыток до блокировки: {countlogin}";
                            else
                                {
                                    label3.Text = "Ваша учётная запись была заблокирована";
                                }
                            }  
                        }                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                    }
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
   
