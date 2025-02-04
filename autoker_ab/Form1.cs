﻿using autoker_ab.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoker_ab
{
    public partial class frmfo : Form
    {
        void betoltes()
        {
            dgadatok.Rows.Clear();
            string lekerdezes = "select * from autoker";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgadatok.Rows.Add(ab.Dr["autoid"], ab.Dr["rendszam"], ab.Dr["tipus"], ab.Dr["szin"], ab.Dr["tulajszam"], ab.Dr["ar"]);
            }
            ab.lezaras();
            lekerdezes = "select round(avg(ar),0) as atlag from autoker";
            ab = new Adatbazis(lekerdezes);
            ab.Dr.Read();
            lberedmeny.Text = "Átlagár: "+ab.Dr["atlag"]+" Ft";
        }
        public frmfo()
        {
            InitializeComponent();
        }

        private void btload_Click(object sender, EventArgs e)
        {
            betoltes();
        }

        private void btfelv_Click(object sender, EventArgs e)
        {

        }
    }
}
