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
    public partial class Panel_przegladania : Form
    {
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private OracleCommandBuilder command_builder;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;

        public static string KSIEGOWA = "KSIEGOWA";
        public static string OPIEKUN = "opiekun";
        public static string ANNA = "anna";

        public string NazwaUzytkownika { get; set; }
        public string TypUzytkownika { get; set; }

        public Panel_przegladania(string TypPracownika)
        {
            this.NazwaUzytkownika = TypPracownika;
            InitializeComponent();
            init();
        }

        public Panel_przegladania()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            try
            {           
                nowe_polaczenie.Connection();

                string sql;
                sql = "select nazwa from stanowiska join pracownicy on " +
                    "stanowiska.NR_STANOWISKA = pracownicy.NR_STANOWISKA " +
                    "where nazwa_uzytkownika = '" + this.NazwaUzytkownika + "'";

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    TypUzytkownika = (string)dr["NAZWA"];
                    TypUzytkownika_label.Text = TypUzytkownika;
                }

                if (this.TypUzytkownika == KSIEGOWA)
                {
                    sql = "select table_name from user_tables where table_name in ('GRAFIKI', 'WYNAGRODZENIA', 'SPONSORZY', 'PRACOWNICY', 'PRACOWNIK_WYDARZENIE', 'STANOWISKA', 'WYDARZENIA')";
                }
                else if(this.TypUzytkownika == OPIEKUN)
                {
                    sql = "select table_name from user_tables where table_name in ('GRAFIKI', 'PRACOWNICY', 'PRACOWNIK_WYDARZENIE', 'STANOWISKA', 'WYDARZENIA', 'ADOPCJE', 'BOKSY', 'KOTY', 'PSY', 'RASY_KOT', 'RASY_PIES', 'ROZMIARY_PSA', 'SZCZEPIENIA', 'SZCZEPIONKI', 'ZWIERZETA')";
                }
                else
                {
                    sql = "select table_name from user_tables where table_name NOT IN( 'BONUS', 'DEPT', 'PLAN_TABLE', 'EMP', 'SALGRADE')";
                }

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                dr = control_manager_dialog.ExecuteReader();            
                
                while (dr.Read())
                {
                    comboBox_show.Items.Add((string)dr["table_name"]);
                }

                dr.Dispose();
                control_manager_dialog.Dispose();

            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("Error attempting to insert duplicate data.");

                        break;
                    case 12560:
                        MessageBox.Show("The database is unvaliable.");

                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message.ToString());

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                //nowe_polaczenie.Dispose();
            }
        }

        private void button_goback_Click(object sender, EventArgs e)
        {
            if (TypUzytkownika == OPIEKUN)
            {
                this.Hide();
                Menu_opiekun ss = new Menu_opiekun(this.NazwaUzytkownika);
                ss.Show();
            }
            else
            {
                this.Hide();
                Menu_admin ss = new Menu_admin();
                ss.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                string sql = "select * from " + comboBox_show.Text;
                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();

                data_adapter = new OracleDataAdapter(control_manager_dialog);
                wybor_danych = new DataSet();

                data_adapter.Fill(wybor_danych);

                dataGridView_review.DataSource = wybor_danych.Tables[0];


                comboBox_sort.Items.Clear();
                comboBox_sort.ResetText();
                for (int i = 0; i < wybor_danych.Tables[0].Columns.Count; i++)
                {
                    comboBox_sort.Items.Add(wybor_danych.Tables[0].Columns[i].ToString());
                }

                //comboBox_order.Items.Add("rosnąco");
                //comboBox_order.Items.Add("malejąco");
                var choices = new Dictionary<string, string>();
                choices["ASC"] = "rosnąco";
                choices["DESC"] = "malejąco";            
                comboBox_order.DataSource = new BindingSource(choices, null);
                comboBox_order.DisplayMember = "Value";
                comboBox_order.ValueMember = "Key";

                dr.Dispose();
                control_manager_dialog.Dispose();
                data_adapter.Dispose();
                wybor_danych.Dispose();
            }
            catch (OracleException ex)
            {
                switch (ex.Number)
                {
                    case 1:
                        MessageBox.Show("Error attempting to insert duplicate data.");

                        break;
                    case 12560:
                        MessageBox.Show("The database is unvaliable.");

                        break;
                    default:
                        MessageBox.Show("Database error: " + ex.Message.ToString());

                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {

                //nowe_polaczenie.Dispose();
            }

        }

        private void comboBox_order_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            var order_control = ((KeyValuePair<string, string>)comboBox_order.SelectedItem).Key;
            if(comboBox_sort.Text.Equals(""))
            {
                MessageBox.Show("Wybierz atrybut sortowania");
            }
            else
            {
                try
                {
                    string sql = "select * from " + comboBox_show.Text + " ORDER BY " + comboBox_sort.Text + " " + order_control;
                    //MessageBox.Show(sql);
                    control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                    control_manager_dialog.CommandType = CommandType.Text;

                    OracleDataReader dr = control_manager_dialog.ExecuteReader();

                    data_adapter = new OracleDataAdapter(control_manager_dialog);
                    wybor_danych = new DataSet();

                    data_adapter.Fill(wybor_danych);

                    dataGridView_review.DataSource = wybor_danych.Tables[0];


                    dr.Dispose();
                    control_manager_dialog.Dispose();
                    data_adapter.Dispose();
                    wybor_danych.Dispose();
                }
                catch (OracleException ex)
                {
                    switch (ex.Number)
                    {
                        case 1:
                            MessageBox.Show("Error attempting to insert duplicate data.");

                            break;
                        case 12560:
                            MessageBox.Show("The database is unvaliable.");

                            break;
                        default:
                            MessageBox.Show("Database error: " + ex.Message.ToString());

                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {

                    //nowe_polaczenie.Dispose();
                }
            }
        }
    }
}
