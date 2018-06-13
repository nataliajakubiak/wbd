using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu_opiekun : Form
    {
        public Menu_opiekun()
        {
            InitializeComponent();
        }

        private void przegladajClick(object sender, EventArgs e)
        {
            this.Hide();
            Panel_przegladania ss = new Panel_przegladania("OPIEKUN");
            ss.Show();
        }

        private void mojeDaneClick(object sender, EventArgs e)
        {
            this.Hide();
            mojeDane ss = new mojeDane();
            ss.Show();
        }

        private void mojeZwierzetaClick(object sender, EventArgs e)
        {
            this.Hide();
            mojeZwierzeta ss = new mojeZwierzeta();
            ss.Show();
        }

        private void ModyfikujRekordyClick(object sender, EventArgs e)
        {

        }

        private void ZmienHasloClick(object sender, EventArgs e)
        {
            
        }

        private void zakonczClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void wylogujClick(object sender, EventArgs e)
        {
            this.Hide();
            Panel_logowania ss = new Panel_logowania();
            ss.Show();
        }
    }
}
