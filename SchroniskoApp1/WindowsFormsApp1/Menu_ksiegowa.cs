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
    public partial class Menu_ksiegowa : Form
    {
        private string text_login_string;

        public Menu_ksiegowa()
        {
            InitializeComponent();
        }

        public Menu_ksiegowa(string text_login_string)
        {
            this.text_login_string = text_login_string;
        }

        private void Menu_ksiegowa_Load(object sender, EventArgs e)
        {

        }
    }
}
