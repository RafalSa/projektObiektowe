﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroExplorer
{
    public partial class FormH : Form
    {
        public FormH()
        {
            InitializeComponent();
        }

        private void Hiszpania_Click(object sender, EventArgs e)
        {
            Hiszpania F10 = new Hiszpania();
            F10.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Holandia_Click(object sender, EventArgs e)
        {
            Holandia F11 = new Holandia();
            F11.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Close();


            bool form1Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form1)
                {
                    form1Open = true;
                    f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    break;
                }
            }

            if (!form1Open)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
