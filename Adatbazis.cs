using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace szegedGUI
{
    internal class Adatbazis
    {
        const string szerver = "server=linsql.verebely.dc;database=diak57;uid=diak57;password=HXPEFG";
        MySqlConnection kapcsolat;
        MySqlCommand parancs;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Adatbazis(string sql)
        {
            kapcsolat = new MySqlConnection(szerver);
            kapcsolat.Open();
            parancs = new MySqlCommand(sql, kapcsolat);
            dr = parancs.ExecuteReader();
        }
        public void lezaras()
        {
            kapcsolat.Close();
        }
        ~Adatbazis(){
            kapcsolat.Close();
        }
    }
}
