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
    public partial class profilPies : Form
     {

        SQLCONNECT nowe_polaczenie = new SQLCONNECT();

        public string NrZwierza;

        public profilPies(string NrZwierza)
        {
            this.NrZwierza = NrZwierza;
            InitializeComponent();
            Init();

        }




        private void Init()
        {

            nowe_polaczenie.Connection();

            string sql = "select  imie, plec, data_urodzenia, data_przyjecia, nr_boksu, czy_sterylizacja, waga," +
                " karta_zdrowia, czy_chip, nr_chipu, CZY_RODOWOD, umaszczenie, charakter, siersc from zwierzeta where " +
                "nr_zwierzecia = '" + this.NrZwierza + "'";

            var control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog.CommandType = CommandType.Text;
            OracleDataReader dr = control_manager_dialog.ExecuteReader();
            dr.Read();

            string Imie, Plec, Sterylizacja, KartaZdrowia, Chip, NrChipu, Rodowod, Umaszczenie;
            string Charakter, Siersc, Tolerancja, Agresja;

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
            this.nrChip_textBox.Text = NrChipu;
            this.rodowod_textBox.Text = Rodowod;
            this.umaszczenie_textBox.Text = Umaszczenie;
            this.charakter_textBox.Text = Charakter;
            this.siersc_textBox.Text = Siersc;
            this.dataUr_textBox.Text = DataUrodzenia.ToShortDateString();
            this.dataPrzyj_textBox.Text = DataPrzyjecia.ToShortDateString();



            string sql1 = "select nazwa from RASY_PIES where nr_rasy_psa = " +
                "(select nr_rasy_psa from psy where nr_zwierzecia ='"
             + this.NrZwierza + "')";


            var control_manager_dialog1 = new OracleCommand(sql1, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog1.CommandType = CommandType.Text;
            OracleDataReader dr1 = control_manager_dialog1.ExecuteReader();
            dr1.Read();

            string Rasa;
            Rasa = (string)dr1["nazwa"];

            this.rasa_textBox.Text = Rasa;


     
            string sql2 = "select czy_chodzenie_na_smyczy, czy_agresja_ludzie, czy_tolerancja_zwierzeta from psy where nr_zwierzecia =' " + this.NrZwierza + "'";

            var control_manager_dialog2 = new OracleCommand(sql2, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog2.CommandType = CommandType.Text;
            OracleDataReader dr2 = control_manager_dialog2.ExecuteReader();
            dr2.Read();

            string Chodzenie;

            Chodzenie = (string)dr2["czy_chodzenie_na_smyczy"];
            Agresja = (string)dr2["czy_agresja_ludzie"];
            Tolerancja = (string)dr2["czy_tolerancja_zwierzeta"];
            

            this.chodzenie_textBox.Text = Chodzenie;
            this.agresja_textBox.Text = Agresja;
            this.tolerancja_textBox.Text = Tolerancja;


            
            string sql3 = "select data_szczepienia from szczepienia where nr_szczepionki = '1' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog3 = new OracleCommand(sql3, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog3.CommandType = CommandType.Text;
            OracleDataReader dr3 = control_manager_dialog3.ExecuteReader();
            dr3.Read();
            DateTime Wscieklizna, Borelioza, Nosówka, WZW;

            if (dr3.HasRows)
            {
                Wscieklizna = (DateTime)dr3["data_szczepienia"];
                this.wscieklizna_text.Text = Wscieklizna.ToShortDateString();
            }


            else
            {
                Wscieklizna = DateTime.MinValue;
                this.wscieklizna_text.Text = Wscieklizna.ToShortDateString();

            }


            string sql4 = "select data_szczepienia from szczepienia where nr_szczepionki = '2' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog4 = new OracleCommand(sql4, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog4.CommandType = CommandType.Text;
            OracleDataReader dr4 = control_manager_dialog4.ExecuteReader();
            dr4.Read();

            if (dr4.HasRows)
            {
                Borelioza = (DateTime)dr4["data_szczepienia"];
                this.borelioza_text.Text = Borelioza.ToShortDateString();
            }


            else
            {
                Borelioza = DateTime.MinValue;
                this.borelioza_text.Text = Borelioza.ToShortDateString();

            }



            string sql5 = "select data_szczepienia from szczepienia where nr_szczepionki = '3' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog5 = new OracleCommand(sql5, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog5.CommandType = CommandType.Text;
            OracleDataReader dr5 = control_manager_dialog5.ExecuteReader();
            dr5.Read();


            if (dr5.HasRows)
            {
                Nosówka = (DateTime)dr5["data_szczepienia"];
                this.nosowka_textBox.Text = Nosówka.ToShortDateString();

            }
            else
            {
                Nosówka = DateTime.MinValue;
                this.nosowka_textBox.Text = Nosówka.ToShortDateString();

            }


            string sql6 = "select data_szczepienia from szczepienia where nr_szczepionki = '4' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog6 = new OracleCommand(sql6, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog6.CommandType = CommandType.Text;
            OracleDataReader dr6 = control_manager_dialog6.ExecuteReader();
            dr6.Read();

            if (dr6.HasRows)
            {
                WZW = (DateTime)dr6["data_szczepienia"];
                this.wzw_textBox.Text = WZW.ToShortDateString();
            }
            else
            {
                WZW = DateTime.MinValue;
                this.wzw_textBox.Text = WZW.ToShortDateString();

            }



            string sql7= "select nazwa from rozmiary_psa where nr_rozmiaru =(select nr_rozmiaru from " +
                "psy where  nr_zwierzecia ='"+ this.NrZwierza + "')";

            
            var control_manager_dialog7 = new OracleCommand(sql7, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog7.CommandType = CommandType.Text;
            OracleDataReader dr7 = control_manager_dialog7.ExecuteReader();
            dr7.Read();

            string Rozmiar;
            Rozmiar = (string)dr7["nazwa"];

            this.rozmiar_textBox.Text = Rozmiar;


        }







        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void powotClick(object sender, EventArgs e)
        {
            this.Hide();
            mojeZwierzeta ss = new mojeZwierzeta();
            ss.Show();
        }

        private void modyfikujClick(object sender, EventArgs e)
        {

        }
    }
}
