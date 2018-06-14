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
    public partial class profilKot : Form
    { 
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();

        public string NrZwierza;
    
        public profilKot(string NrZwierza)
        {
            this.NrZwierza = NrZwierza;
            InitializeComponent();
            Init();
        }



        private void Init() {

            nowe_polaczenie.Connection();

            string sql= "select  imie, plec, data_urodzenia, data_przyjecia, nr_boksu, czy_sterylizacja, waga," +
                " karta_zdrowia, czy_chip, nr_chipu, CZY_RODOWOD, umaszczenie, charakter, siersc from zwierzeta where " +
                "nr_zwierzecia = '" +this.NrZwierza +"'";

            var control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog.CommandType = CommandType.Text;
            OracleDataReader dr = control_manager_dialog.ExecuteReader();
            dr.Read();

            string Imie, Plec,  Sterylizacja, KartaZdrowia, Chip, NrChipu, Rodowod, Umaszczenie;
            string Charakter, Siersc;

            DateTime DataUrodzenia, DataPrzyjecia;
            Decimal NrBoksu, Waga;

           

            Imie = (string)dr["IMIE"];
            Plec = (string)dr["plec"];
            NrBoksu = (decimal)dr["nr_boksu"];
            Sterylizacja = (string)dr["czy_sterylizacja"];
            Waga = (decimal)dr["waga"];
            KartaZdrowia = dr["karta_zdrowia"] is System.DBNull ? "" : (string)dr["karta_zdrowia"];
            Chip = (string)dr["czy_chip"];
            NrChipu = dr["nr_chipu"] is System.DBNull ? "" : (string)dr["nr_chipu"];
            Rodowod = (string)dr["CZY_RODOWOD"];
            Umaszczenie = (string)dr["umaszczenie"];
            Charakter = (string)dr["charakter"];
            Siersc = (string)dr["siersc"];
            DataUrodzenia = (DateTime)dr["data_urodzenia"];
            DataPrzyjecia = (DateTime)dr["data_przyjecia"];

             

            this.imie_textBox.Text = Imie;
            this.plec_textBox.Text = Plec;
            this.waga_textBox.Text = Convert.ToString(Waga);
            this.nrBoksu_textBox.Text = Convert.ToString(NrBoksu);
            this.sterylizacja_textBox.Text = Sterylizacja;
            this.karta_textBox.Text = KartaZdrowia;
            this.chip_textBox.Text = Chip;
            this.nrChipu_textBox.Text = NrChipu;
            this.rodowod_textBox.Text = Rodowod;
            this.umaszczenie_textBox.Text = Umaszczenie;
            this.charakter_textBox.Text = Charakter;
            this.siersc_textBox.Text = Siersc;
            this.dataUr_textBox.Text = DataUrodzenia.ToShortTimeString();
            this.dataPrzyj_textBox.Text = DataPrzyjecia.ToShortTimeString();



            string sql1 = "select nazwa from rasy_kot where nr_rasy_kota = " +
               "(select nr_rasy_kota from koty where nr_zwierzecia = ' " + this.NrZwierza + "')";


            var control_manager_dialog1 = new OracleCommand(sql1, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog1.CommandType = CommandType.Text;
            OracleDataReader dr1 = control_manager_dialog1.ExecuteReader();
            dr1.Read();

            string Rasa;
            Rasa = (string)dr1["nazwa"];

            this.rasa_textBox.Text = Rasa;


            string sql2 = "select czy_drapie from koty where nr_zwierzecia =' " + this.NrZwierza + "'";

            var control_manager_dialog2 = new OracleCommand(sql2, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog2.CommandType = CommandType.Text;
            OracleDataReader dr2 = control_manager_dialog2.ExecuteReader();
            dr2.Read();

            string Drapanie;

            Drapanie = (string)dr2["czy_drapie"];
            this.drapanie_textBox.Text = Drapanie;




        }

        private void powrotClick(object sender, EventArgs e)
        {
            this.Hide();
            mojeZwierzeta ss = new mojeZwierzeta();
            ss.Show();
        }
    }
}
