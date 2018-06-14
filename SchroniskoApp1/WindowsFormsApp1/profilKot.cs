﻿using Oracle.ManagedDataAccess.Client;
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
        string user_name_login;

      
        public profilKot(string NrZwierza, string nazwa_przekazana)
        {
            this.NrZwierza = NrZwierza;
            user_name_login = nazwa_przekazana;
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
            this.dataUr_textBox.Text = DataUrodzenia.ToShortDateString();
            this.dataPrzyj_textBox.Text = DataPrzyjecia.ToShortDateString();



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


            string sql3= "select data_szczepienia from szczepienia where nr_szczepionki = '1' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog3 = new OracleCommand(sql3, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog3.CommandType = CommandType.Text;
            OracleDataReader dr3 = control_manager_dialog3.ExecuteReader();
            dr3.Read();
            DateTime Wscieklizna, Borelioza, Leptospiroza, Panleukopenia;

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



            string sql5 = "select data_szczepienia from szczepienia where nr_szczepionki = '5' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog5 = new OracleCommand(sql5, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog5.CommandType = CommandType.Text;
            OracleDataReader dr5 = control_manager_dialog5.ExecuteReader();
            dr5.Read();


            if (dr5.HasRows)
            {
                Leptospiroza = (DateTime)dr5["data_szczepienia"];
                this.leptospiroza_textBox.Text = Leptospiroza.ToShortDateString();

            }
            else
            {
                Leptospiroza = DateTime.MinValue;
                this.leptospiroza_textBox.Text = Leptospiroza.ToShortDateString();

            }


            string sql6 = "select data_szczepienia from szczepienia where nr_szczepionki = '6' and nr_zwierzecia = ' " + this.NrZwierza + "'";
            var control_manager_dialog6 = new OracleCommand(sql6, nowe_polaczenie.nowe_polaczenie);
            control_manager_dialog6.CommandType = CommandType.Text;
            OracleDataReader dr6 = control_manager_dialog6.ExecuteReader();
            dr6.Read();

            if (dr6.HasRows)
            {
                Panleukopenia = (DateTime)dr6["data_szczepienia"];
                this.panleukopenia_textBox.Text = Panleukopenia.ToShortDateString();
            }
            else
            {
                Panleukopenia = DateTime.MinValue;
                this.panleukopenia_textBox.Text = Panleukopenia.ToShortDateString();

            }



        }

        private void powrotClick(object sender, EventArgs e)
        {
            this.Hide();
            mojeZwierzeta ss = new mojeZwierzeta(user_name_login);
            ss.Show();
        }

        

        private void odswiezClick(object sender, EventArgs e)
        {
            Init();
        }

        private void modyfikujClick(object sender, EventArgs e)
        {
         nrBoksu_textBox.ReadOnly=false;
         plec_textBox.ReadOnly=false;
         rasa_textBox.ReadOnly=false;
         dataUr_textBox.ReadOnly=false;
         dataPrzyj_textBox.ReadOnly=false;
         imie_textBox.ReadOnly=false;
         karta_textBox.ReadOnly=false;
         siersc_textBox.ReadOnly=false;
         umaszczenie_textBox.ReadOnly=false;
         charakter_textBox.ReadOnly=false;
         nrChipu_textBox.ReadOnly=false;
         rodowod_textBox.ReadOnly=false;
         chip_textBox.ReadOnly=false;
         drapanie_textBox.ReadOnly=false;
         waga_textBox.ReadOnly=false;
         sterylizacja_textBox.ReadOnly=false;
         wscieklizna_text.ReadOnly = false; ;
         borelioza_text.ReadOnly=false;
         panleukopenia_textBox.ReadOnly=false;
         leptospiroza_textBox.ReadOnly=false;
         zmienButton.Enabled = true;
         odswiezButton.Enabled = true;
        }


        private void zmienClick(object sender, EventArgs e)
        {

            var nrBoksu = nrBoksu_textBox.Text;
            var plec = plec_textBox.Text;
            var rasa = rasa_textBox.Text;
            var dataUr = dataUr_textBox.Text;
            var dataPrzyj = dataPrzyj_textBox.Text;
            var imie = imie_textBox.Text;
            var karta = karta_textBox.Text;
            var siersc = siersc_textBox.Text;
            var umaszczenie = umaszczenie_textBox.Text;
            var charakter = charakter_textBox.Text;
            var rodowod = rodowod_textBox.Text;           
            var nrChip = nrChipu_textBox.Text;
            var chip = chip_textBox.Text;            
            var sterylizacja = sterylizacja_textBox.Text;
            var drapanie = drapanie_textBox.Text;
            var waga = waga_textBox.Text;            
            var wscieklizna = wscieklizna_text.Text;
            var borelioza = borelioza_text.Text;
            var leptospiroza = leptospiroza_textBox.Text;
            var panleukopenia = panleukopenia_textBox.Text;

            List<string> query = new List<string>();


            string updateZwierzeta = $"update zwierzeta set " +
                $"imie = '{imie}', " +
                $"data_urodzenia = TO_DATE('{dataUr}', 'YYYY-MM-DD'), " +
                $"plec = '{plec}'," +
                $"data_przyjecia =TO_DATE('{dataPrzyj}', 'YYYY-MM-DD'), " +
                $"nr_boksu = TO_NUMBER('{nrBoksu}')," +
                $"czy_sterylizacja = '{sterylizacja}'," +
                $"waga = TO_NUMBER('{waga}')," +
                $"karta_zdrowia ='{karta}'," +
                $"czy_chip ='{chip}'," +
                $"nr_chipu='{nrChip}'," +
                $"czy_rodowod ='{rodowod}'," +
                $"umaszczenie ='{umaszczenie}'," +
                $"charakter ='{charakter}'," +
                $"siersc ='{siersc}' " +
                $"where nr_zwierzecia='{this.NrZwierza}'";


            query.Add(updateZwierzeta);


            string updateRasyKota = $"update RASY_KOT set nazwa = '{rasa}'"
                + $" where nr_rasy_kota = (select nr_rasy_kota from koty where nr_zwierzecia='{this.NrZwierza}' )";
            query.Add(updateRasyKota);

            string updateKoty = $"update KOTY set czy_drapie = '{drapanie}' " +
                 $"where nr_zwierzecia ='{this.NrZwierza}'";
            query.Add(updateKoty);

            string updateSzczepienia1 = $"update SZCZEPIENIA set data_szczepienia=TO_DATE('{borelioza}') " +
                $"where nr_szczepionki='1' and nr_zwierzecia='{this.NrZwierza}'";
            query.Add(updateSzczepienia1);

            string updateSzczepienia2 = $"update SZCZEPIENIA set data_szczepienia=TO_DATE('{wscieklizna}') " +
                $"where nr_szczepionki='2' and nr_zwierzecia='{this.NrZwierza}'";
            query.Add(updateSzczepienia2);


            string updateSzczepienia3 = $"update SZCZEPIENIA set data_szczepienia=TO_DATE('{leptospiroza}') " +
                $"where nr_szczepionki='5' and nr_zwierzecia='{this.NrZwierza}'";
            query.Add(updateSzczepienia3);

            string updateSzczepienia4 = $"update SZCZEPIENIA set data_szczepienia=TO_DATE('{panleukopenia}') " +
                $"where nr_szczepionki='6' and nr_zwierzecia='{this.NrZwierza}'";
            query.Add(updateSzczepienia4);


            query.ForEach(queryParam =>
            {
                    var oracleCommand = new OracleCommand(queryParam, nowe_polaczenie.nowe_polaczenie);
                    oracleCommand.CommandType = CommandType.Text;
                    oracleCommand.ExecuteNonQuery();

            });


        }



    }
}
