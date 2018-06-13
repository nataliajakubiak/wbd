using Oracle.ManagedDataAccess.Client;
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
    public partial class mojeDane : Form
    {
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        public string NazwaUzytkownika { get; set; }

        public mojeDane(string NazwaUzytkownika)
        {
            this.NazwaUzytkownika = NazwaUzytkownika;
          
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            nowe_polaczenie.Connection();

            string sql = "SELECT * FROM PRACOWNICY WHERE nazwa_uzytkownika = '" + this.NazwaUzytkownika + "'";
            var control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog.CommandType = CommandType.Text;

            OracleDataReader dr = control_manager_dialog.ExecuteReader();

            dr.Read();

            string Imie, DrugieImie, Nazwisko, Pesel, Plec, Miasto, Ulica, NrBudynku;
            string NrLokalu, KodPocztowy, NrTelefonu, Email;
            DateTime DataUrodzenia;

            Imie = (string)dr["IMIE"];
            DrugieImie = dr["DRUGIE_IMIE"] is System.DBNull ? "" : (string)dr["DRUGIE_IMIE"] ;
            Nazwisko = (string)dr["NAZWISKO"];
            DataUrodzenia = (DateTime)dr["DATA_URODZENIA"];
            Pesel = (string)dr["PESEL"];
            Plec = (string)dr["PLEC"];
            Miasto= (string)dr["MIASTO"];
            Ulica= (string)dr["ULICA"];
            NrBudynku= (string)dr["NR_BUDYBKU"];
            NrLokalu= (string)dr["NR_MIESZKANIA"];
           // KodPocztowy= (string)dr["PLEC"];
            NrTelefonu= (string)dr["TELEFON"];
            Email= (string)dr["EMAIL"];



            this.imie_textBox.Text = Imie;
            this.drugieImie_textBox.Text = DrugieImie;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void powrotClick(object sender, EventArgs e)
        {
            this.Hide();
            Menu_opiekun ss = new Menu_opiekun();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
