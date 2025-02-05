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
    public partial class frmujfelvitel : Form
    {
        public frmujfelvitel()
        {
            InitializeComponent();
        }

        private void btelvet_Click(object sender, EventArgs e)
        {
            DialogResult uzenet = MessageBox.Show("Biztosan elszeretnéd vetni?", "Üzenet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(uzenet == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txrendszam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtulajszam_TextChanged(object sender, EventArgs e)
        {
            if(txtulajszam.Text.Length > 0)
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
            if(txrendszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a rendszámot!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txrendszam.Focus();
            }
            else if(txtipus.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a típust!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtipus.Focus();
            }
            else if(txszin.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a színét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txszin.Focus();
            }
            else if(txtulajszam.Text.Length == 0)
            {
                MessageBox.Show("Adja meg a tulajdonosok számát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtulajszam.Focus();
            }
            else if(txar.Text.Length == 0)
            {
                MessageBox.Show("Adja meg az árat!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txar.Focus();
            }
            else
            {
                string lekerdezes = "insert into autoker(rendszam,tipus,szin,tulajszam,ar) values ('" + txrendszam.Text + "','" + txtipus.Text + "','" + txszin.Text + "','" + txtulajszam.Text + "','" + txar.Text + "')";
                Adatbazis ab = new Adatbazis(lekerdezes);
                ab.Dr.Read();
                txrendszam.Clear();
                txtipus.Clear();
                txszin.Clear();
                txtulajszam.Clear();
                txar.Clear();
                MessageBox.Show("Sikeres adatmentés!","GRATULA!!!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
