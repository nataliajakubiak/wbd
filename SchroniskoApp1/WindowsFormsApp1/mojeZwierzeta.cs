using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
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

        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private DataSet wybor_danych;

        string user_name_login;
       
        public mojeZwierzeta(string nazwa_przekazana)
        {
            user_name_login = nazwa_przekazana;
            InitializeComponent();
            init();
        }


        private void init() {

            try
            {
                nowe_polaczenie.Connection();

                string sql;
                sql = "SELECT * FROM ZWIERZETA where nr_boksu in (select nr_boksu from pracownicy where nr_pracownika= '1')";

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();

                data_adapter = new OracleDataAdapter(control_manager_dialog);
                wybor_danych = new DataSet();
                data_adapter.Fill(wybor_danych);
                dataGridView1.DataSource = wybor_danych.Tables[0];

                dr.Read();
                                        
                       
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



        private void powrotClick(object sender, EventArgs e)
        {
            this.Hide();
            Menu_opiekun ss = new Menu_opiekun(user_name_login);
            ss.Show();
        }

        private void wyswietlProfilZwierzeciaClick(object sender, EventArgs e)
        {
            if (nrZwierzecia_textBox.Text.Length == 0)
            {
                String message_error_login = "Proszę podać numer zwierzęcia.";
                MessageBox.Show(message_error_login);
            }
            else
            {
                this.Hide();

                try
                {
                    nowe_polaczenie.Connection();
                    string kot;
                    kot = "select count(nr_zwierzecia) from koty where nr_zwierzecia ='" + nrZwierzecia_textBox.Text + "'";




                    control_manager_dialog = new OracleCommand(kot, nowe_polaczenie.nowe_polaczenie);
                    control_manager_dialog.CommandType = CommandType.Text;

                    OracleDataReader dr = control_manager_dialog.ExecuteReader();
                    dr.Read();

                    OracleDecimal ileKotow = dr.GetOracleDecimal(0);


                    if (ileKotow.ToString().Equals("1"))
                    {
                        profilKot ss = new profilKot(nrZwierzecia_textBox.Text, user_name_login);
                        ss.Show();
                    }
                    else
                    {
                        profilPies ss = new profilPies(nrZwierzecia_textBox.Text, user_name_login);
                        ss.Show();
                    }

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
