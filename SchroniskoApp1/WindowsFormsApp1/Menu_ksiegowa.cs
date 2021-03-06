﻿using System;
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
    public partial class Menu_ksiegowa : Form
    {
        private string text_login_string;

        public Menu_ksiegowa()
        {
            InitializeComponent();
        }

        public Menu_ksiegowa(string text_login_string)
        {
            this.text_login_string = text_login_string;
        }


        private void przegladaj_click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_przegladania ss = new Panel_przegladania("KSIEGOWA");
            ss.Show();
        }

        private void nowyRekord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_dodawania ss = new Panel_dodawania("KSIEGOWA");
            ss.Show();
        }
    }
}
