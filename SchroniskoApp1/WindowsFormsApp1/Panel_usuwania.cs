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
    public partial class Panel_usuwania : Form
    {
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private OracleCommandBuilder command_builder;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;
        string zmienna_pomocna;


        public Panel_usuwania()
        {
            InitializeComponent();

            try
            {

                nowe_polaczenie.Connection();

                string sql = "select table_name from user_tables where table_name NOT IN( 'BONUS', 'DEPT', 'PLAN_TABLE', 'EMP', 'SALGRADE')";

                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();
                dr.Read();
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

        private void label_review_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_show_SelectedIndexChanged(object sender, EventArgs e)
        {
            moja_funkcja();
          

        }

        private void button_goback_Click(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(" wpisany numer: " + textBox_id.Text + " zmienna: " + zmienna_pomocna + "nazwa tabeli: " + comboBox_show.Text);
            try
            {
               
                int value;
                string sql;
                if (int.TryParse(textBox_id.Text, out value))
                {
                     sql = "delete from " + comboBox_show.Text + " where " + comboBox_select.Text + " = " + textBox_id.Text;
                }
                else
                {
                     sql = "delete from " + comboBox_show.Text + " where " + comboBox_select.Text + " = '" + textBox_id.Text +"'";
                }
                control_manager_dialog = new OracleCommand(sql, nowe_polaczenie.nowe_polaczenie);
                control_manager_dialog.CommandType = CommandType.Text;

                OracleDataReader dr = control_manager_dialog.ExecuteReader();

                data_adapter = new OracleDataAdapter(control_manager_dialog);
                MessageBox.Show("Zmiany zostały pomyślnie zapisane", "Usuwanie danych", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            moja_funkcja();
        }

        public void moja_funkcja()
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

                dataGridView1.DataSource = wybor_danych.Tables[0];

                
                comboBox_select.Items.Clear();
                comboBox_select.ResetText();
                for (int i = 0; i < wybor_danych.Tables[0].Columns.Count; i++)
                {
                    comboBox_select.Items.Add(wybor_danych.Tables[0].Columns[i].ToString());
                }

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_admin ss = new Menu_admin();
            ss.Show();
        }

        
    }
}
