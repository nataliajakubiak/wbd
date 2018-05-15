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


namespace WindowsFormsApp1
{
    public partial class panel_logowania : Form
    {
        public panel_logowania()
        {
            InitializeComponent();
        }
        private OracleConnection nowe_polaczenie = new OracleConnection();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adaper;
        private OracleCommandBuilder command_builder;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_panel_logowania_Click(object sender, EventArgs e)
        {

        }

        private void button_zaloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_admin ss = new Menu_admin();
            ss.Show();
        }
        private void button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
