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
    public partial class Panel_hasla : Form
    {
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        string user_name_login;

        public Panel_hasla()
        {
            InitializeComponent();

        }
        public Panel_hasla(string nazwa_przekazana)
        {
            InitializeComponent();
            user_name_login = nazwa_przekazana;

        }

        private void button_goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_admin ss = new Menu_admin();
            ss.Show();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                SQLCONNECT nowe_polaczenie = new SQLCONNECT();
                nowe_polaczenie.Connection();
                if (textBox_haslo1.Text.Equals(textBox_haslo2.Text))
                {
                    string user_name_sztuczny = "natka";
                    string sql = "update uzytkownicy set user_password='" + textBox_haslo1.Text + "' where user_name='" + user_name_login + "'";

                    control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                    control_manager_dialog.CommandType = CommandType.Text;

                    OracleDataReader dr = control_manager_dialog.ExecuteReader();
                    MessageBox.Show("Hasła zostało pomyślnie zmienione", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hasła nie są identyczne", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                nowe_polaczenie.nowe_polaczenie.Dispose();
            }

        }
    }
    }

