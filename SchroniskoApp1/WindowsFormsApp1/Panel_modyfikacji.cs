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
    public partial class Panel_modyfikacji : Form
    {
        SQLCONNECT nowe_polaczenie = new SQLCONNECT();
        private OracleCommand control_manager_dialog;
        private OracleDataAdapter data_adapter;
        private OracleCommandBuilder command_builder;
        private DataSet wybor_danych;
        private DataView wyswietlenie_danych;

        public Panel_modyfikacji()
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

        private void Form2_Load(object sender, EventArgs e)
        {

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
            this.Hide();
            Menu_admin ss = new Menu_admin();
            ss.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
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

        

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                command_builder = new OracleCommandBuilder(data_adapter);
                data_adapter.Update(wybor_danych.Tables[0]);
                MessageBox.Show("Zmiany zostały pomyślnie zapisane", "Modyfikacja danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
               // data_adapter.RowUpdated();
                //wybor_danych = new DataSet();

              //  data_adapter.Fill(wybor_danych);

               // dataGridView_review.DataSource = wybor_danych.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_review_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
