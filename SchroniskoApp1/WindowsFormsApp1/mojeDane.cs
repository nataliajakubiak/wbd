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

            string sqlPoczta = "SELECT MIEJSCOWOSC, KOD_POCZTOWY FROM POCZTY where nr_poczty = (select nr_poczty from pracownicy where nazwa_uzytkownika='" 
                + this.NazwaUzytkownika + "')";

            var control_manager_dialog1 = new OracleCommand(sqlPoczta, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog1.CommandType = CommandType.Text;

            OracleDataReader dr1 = control_manager_dialog1.ExecuteReader();
            dr1.Read();


            
            string Imie, DrugieImie, Nazwisko, Pesel, Plec, Miasto, Ulica, NrBudynku;
            string NrLokalu, KodPocztowy, NrTelefonu, Email, NrKonta;
            DateTime DataUrodzenia;

            Imie = (string)dr["IMIE"];
            DrugieImie = dr["DRUGIE_IMIE"] is System.DBNull ? "" : (string)dr["DRUGIE_IMIE"] ;
            Nazwisko = (string)dr["NAZWISKO"];
            DataUrodzenia = (DateTime)dr["DATA_URODZENIA"];
            Pesel = (string)dr["PESEL"];
            Plec = (string)dr["PLEC"];
            Miasto= (string)dr1["MIEJSCOWOSC"];
            Ulica= (string)dr["ULICA"];
            NrBudynku= (string)dr["NR_BUDYNKU"];
            NrLokalu= (string)dr["NR_MIESZKANIA"];
            KodPocztowy= (string)dr1["KOD_POCZTOWY"];
            NrTelefonu= (string)dr["TELEFON"];
            Email= (string)dr["EMAIL"];
            NrKonta = (string)dr["NR_KONTA_BANKOWEGO"];



            this.imie_textBox.Text = Imie;
            this.drugieImie_textBox.Text = DrugieImie;
            this.nazwisko_textBox.Text = Nazwisko;
            this.dataUr_textBox.Text = DataUrodzenia.ToShortDateString();
            this.pesel_textBox.Text = Pesel;
            this.nrBud_textBox.Text = NrBudynku;
            this.nrTel_textBox.Text = NrTelefonu;
            this.email_textBox.Text = Email;
            this.ulica_textBox.Text = Ulica;
            this.nrKonta_textBox.Text = NrKonta;
            this.plec_textBox.Text = Plec;
            this.nrLok_textBox.Text = NrLokalu;
            this.miasto_textBox.Text = Miasto;
            this.kodPocztowy_textBox.Text = KodPocztowy;
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
            Menu_opiekun ss = new Menu_opiekun(this.NazwaUzytkownika);
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void modyfikujClick(object sender, EventArgs e)
        {
         pesel_textBox.ReadOnly=false;
         dataUr_textBox.ReadOnly=false;
         nazwisko_textBox.ReadOnly=false;
         drugieImie_textBox.ReadOnly=false;
         imie_textBox.ReadOnly=false;
         ulica_textBox.ReadOnly=false;
         nrLok_textBox.ReadOnly=false;
         nrBud_textBox.ReadOnly=false;
         kodPocztowy_textBox.ReadOnly=false;
         miasto_textBox.ReadOnly=false;
         nrTel_textBox.ReadOnly=false;
         email_textBox.ReadOnly=false;
         nrKonta_textBox.ReadOnly=false;
         plec_textBox.ReadOnly=false;
         zapiszButton.Enabled=true;
         odswiezButton.Enabled=true;

        }

        private void zapiszClick(object sender, EventArgs e)
        {

            var pesel = pesel_textBox.Text;
            var dataUr = dataUr_textBox.Text;
            var nazwisko = nazwisko_textBox.Text;
            var drugieImie = drugieImie_textBox.Text;
            var imie= imie_textBox.Text;
            var ulica = ulica_textBox.Text;
            var nrLok =nrLok_textBox.Text;
            var nrBud = nrBud_textBox.Text;
            var kodPocztowy = kodPocztowy_textBox.Text;
            var miasto = miasto_textBox.Text;
            var nrTel =nrTel_textBox.Text;
            var email = email_textBox.Text;
            var nrKonta = nrKonta_textBox.Text;
            var plec =plec_textBox.Text;
            zapiszButton.Enabled = true;
            odswiezButton.Enabled = true;

            List<string> query = new List<string>();

            string updatePracownicy = $"update PRACOWNICY set " +
                 $"imie = '{imie}', " +
                 $"data_urodzenia = TO_DATE('{dataUr}', 'YYYY-MM-DD'), " +
                 $"plec = '{plec}'," +
                 $"nazwisko = '{nazwisko}'," +
                 $"drugie_imie ='{drugieImie}'," +
                 $"pesel ='{pesel}'," +
                 $"ulica = '{ulica}'," +
                 $"nr_budynku ='{nrBud}'," +
                 $"nr_mieszkania ='{nrLok}'," +
                 $"nr_konta_bankowego='{nrKonta}'," +
                 $"telefon ='{nrTel}'," +
                 $"email = '{email}'" +
                 $"where nr_pracownika='1'";

                            
                       
           query.Add(updatePracownicy);


            string updatePoczty = $"update POCZTY set " +
                $"kod_pocztowy = '{kodPocztowy}'," +
                $"miejscowosc = '{miasto}'" +
                $"where nr_poczty='3'";

            query.Add(updatePoczty);

            query.ForEach(queryParam =>
            {
                var oracleCommand = new OracleCommand(queryParam, nowe_polaczenie.nowe_polaczenie);
                oracleCommand.CommandType = CommandType.Text;
                oracleCommand.ExecuteNonQuery();
            });

        }

        private void odswiezClick(object sender, EventArgs e)
        {
            Init();
        }
    }
}
