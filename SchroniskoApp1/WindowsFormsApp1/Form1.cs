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
 

    public partial class Panel_logowania : Form
    {
        public Panel_logowania()
        {
            InitializeComponent();
            text_haslo.PasswordChar = '*';
        }
       // private OracleConnection nowe_polaczenie = new OracleConnection();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private OracleCommandBuilder command_builder;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;
        

        private void Form1_Load(object sender, EventArgs e)
           
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_zaloguj_Click(object sender, EventArgs e)
        {

            try
            {
               
                SQLCONNECT nowe_polaczenie = new SQLCONNECT();
                nowe_polaczenie.Connection();


                String text_login_string = text_login.Text;
                String text_password_string = text_haslo.Text;
               
                String sql = "select count(*) from uzytkownicy where user_name = '"+ text_login_string +"' AND user_password = '" + text_password_string +"'";

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();
                dr.Read();
                OracleDecimal oracledecimal1 = dr.GetOracleDecimal(0);

                if ( oracledecimal1.ToString().Equals("1"))
                {
                    
                    this.Hide();
                    Menu_admin ss = new Menu_admin(text_login_string);
                    ss.Show();
           

                }
                else
                {
                    String message_error_login = "Logowanie nie powiodło się.\nUpewnij się, że wpisane dane są prawidłowe.";
                    MessageBox.Show(message_error_login);

                }

                /*data_adapter = new OracleDataAdapter(control_manager_dialog);
                command_builder = new OracleCommandBuilder(data_adapter);
                wybor_danych = new DataSet();


                
                data_adapter.Fill(wybor_danych);


                MessageBox.Show("Zawartosc wczytanej bazy:\n-liczba atrybutow:\t"
                 + wybor_danych.Tables[0].Columns + "\n-liczba rekordow:\t"
                 + wybor_danych.Tables[0].Rows, "Informacja");*/

                /*this.Text = "Zawartosc wczytanej bazy, liczba atrybutow: "
            + wybor_danych.Tables[0].Columns.Count + ", liczba rekordow: "
                + wybor_danych.Tables[0].Rows.Count;*/
     

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
            private void button_wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

