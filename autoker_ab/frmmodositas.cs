using autoker_ab.src;
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
    public partial class frmmodositas : Form
    {
        string autoazonosito;
        void betoltes()
        {
            dgadatok.Rows.Clear();
            string keresett = "";
            if (txkeres.Text.Length > 0)
            {
                keresett = " where tipus like '" + txkeres.Text + "%'";
            }
            string lekerdezes = "select * from autoker" + keresett;
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                dgadatok.Rows.Add(ab.Dr["autoid"], ab.Dr["rendszam"], ab.Dr["tipus"], ab.Dr["szin"], ab.Dr["tulajszam"], ab.Dr["ar"]);
            }
            ab.lezaras();
        }
        public frmmodositas()
        {
            InitializeComponent();
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = MessageBox.Show("Biztosan elveti?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void frmmodositas_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txkeres_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            autoazonosito = sor.Cells["autoid"].Value.ToString();
            lbautoid.Text = autoazonosito;

            txrendszam.Text = sor.Cells["rendszam"].Value.ToString();
            txszin.Text = sor.Cells["szin"].Value.ToString();
            txtipus.Text = sor.Cells["tipus"].Value.ToString();
            txtulajszam.Text = sor.Cells["tulajszam"].Value.ToString();
            txar.Text = sor.Cells["ar"].Value.ToString();
        }

        private void txtulajszam_TextChanged_1(object sender, EventArgs e)
        {
            if (txtulajszam.Text.Length > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txtulajszam.Text);
                }
                catch
                {
                    MessageBox.Show("Ide csak számot tudsz megadni csoró!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtulajszam.Clear();
                    txtulajszam.Focus();
                }
            }
        }

        private void txar_TextChanged(object sender, EventArgs e)
        {
            if (txar.Text.Length > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txar.Text);
                }
                catch
                {
                    MessageBox.Show("Ide csak számot tudsz megadni csoró!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txar.Clear();
                    txar.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            if (txrendszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a rendszámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txrendszam.Focus();
            }
            else if (txtipus.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a típust!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtipus.Focus();
            }
            else if (txszin.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a színét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txszin.Focus();
            }
            else if (txtulajszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a tulajdonosok számát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtulajszam.Focus();
            }
            else if (txar.Text.Length == 0)
            {
                MessageBox.Show("Adja meg az árat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txar.Focus();
            }
            else
            {
                string lekerdezes = "update autoker set rendszam='"+txrendszam.Text+"',tipus='"+txtipus.Text+"',szin='"+txszin.Text+"',tulajszam='"+txtulajszam.Text+"',ar='"+txar.Text+"' where autoid='"+autoazonosito+"'";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                betoltes();
                MessageBox.Show("Sikeres módosítás!", "PACSI!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
