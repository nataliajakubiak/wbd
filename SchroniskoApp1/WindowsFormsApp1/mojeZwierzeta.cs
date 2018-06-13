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
    public partial class mojeZwierzeta : Form
    {
        public mojeZwierzeta()
        {
            InitializeComponent();
        }

        private void powrotClick(object sender, EventArgs e)
        {
            this.Hide();
            Menu_opiekun ss = new Menu_opiekun();
            ss.Show();
        }
    }
}
