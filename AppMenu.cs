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
    public partial class AppMenu: Form
    {
        public AppMenu()
        {
            InitializeComponent();
        }

        private void общаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info_sotrydniki mainForm = new Info_sotrydniki();
            mainForm.Show();
            this.Hide();
        }

        private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info_animal mainForm = new info_animal();
            mainForm.Show();
            this.Hide();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info_postav mainForm = new info_postav();
            mainForm.Show();
            this.Hide();
        }

        private void кормаДляЖивотныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info_korm mainForm = new info_korm();
            mainForm.Show();
            this.Hide();
        }

        private void AppMenu_Load(object sender, EventArgs e)
        {

        }

        private void посетителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visitor mainForm = new visitor();
            mainForm.Show();
            this.Hide();
        }
    }
}
