using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class Menu_admin : Form
    {
        string zmienna_nazwa_przekaz;

        public Menu_admin()
        {
            InitializeComponent();
            
        }

        public Menu_admin(string zmienna_form1)
        {
            InitializeComponent();
            zmienna_nazwa_przekaz = zmienna_form1;
        }

        private void button_review_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_przegladania ss = new Panel_przegladania();
            ss.Show();
        }

        private void button_delete_record_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_usuwania ss = new Panel_usuwania();
            ss.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_logowania ss = new Panel_logowania();
            ss.Show();
        }

        private void button_modify_record_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_modyfikacji ss = new Panel_modyfikacji();
            ss.Show();
        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_hasla ss = new Panel_hasla(zmienna_nazwa_przekaz);
            ss.Show();
        }

        private void button_new_record_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_dodawania ss = new Panel_dodawania();
            ss.Show();
        }
    }
}
