using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace autoker_ab.src
{
    internal class Adatbazis
    {
        const string szerver = "server=linsql.verebely.dc;uid=diak57;password=HXPEFG;database=diak57";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Adatbazis(string lekerdezes)
        {
            kapcsolat = new MySqlConnection(szerver);
            kapcsolat.Open();
            parancs = new MySqlCommand(lekerdezes,kapcsolat);
            Dr = parancs.ExecuteReader();
        }

        public void lezaras()
        {
            kapcsolat.Close();
        }

        ~Adatbazis()
        {
            kapcsolat.Close();
        }
    }
}
