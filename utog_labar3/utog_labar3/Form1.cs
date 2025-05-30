using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utog_labar3.Lavreshin;
using utog_labar3.Pokalo;
using utog_labar3.Sodikov;

namespace utog_labar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lav_Click(object sender, EventArgs e)
        {
            lavr newForm = new lavr();
            newForm.Show();
        }

        private void btn_pok_Click(object sender, EventArgs e)
        {
            pok newForm = new pok();
            newForm.Show();
        }

        private void btn_sod_Click(object sender, EventArgs e)
        {
            sod newForm = new sod();
            newForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
