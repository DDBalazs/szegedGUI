using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szegedGUI
{
    public partial class Form1 : Form
    {
        void betoltes()
        {
            dgadatok.Rows.Clear();
            
            string search = "";
            if (txserach.Text.Length > 0)
            {
                search = " and megallo.nev like '" +txserach.Text+ " %' ";
            }


            string lekerdezes = "select jaratok.jaratszam, megallo.nev, jaratok.jarat_leiras, jaratok.jarat_tipus from jaratok, utvonal, megallo where jaratok.id = utvonal.jarat_id and utvonal.megallo_id = megallo.id"+search;
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                string tipus = "";
                string szam = ab.Dr["jarat_tipus"].ToString();

                if(szam == "1")
                {
                    tipus = "vonat";
                }
                else if(szam == "2")
                {
                    tipus = "villamos";
                }
                else if(szam == "3")
                {
                    tipus = "troli";
                }
                dgadatok.Rows.Add(ab.Dr["jaratszam"], ab.Dr["nev"], ab.Dr["jarat_leiras"], tipus);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
            lbmegallok.Visible = false;
        }

        private void txserach_TextChanged(object sender, EventArgs e)
        {
            betoltes();
        }

        private void dgadatok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbmegallok.Visible = true;
            DataGridViewRow sor = dgadatok.Rows[e.RowIndex];
            string megalloleker = sor.Cells["nev"].Value.ToString();
            string lekerdezes = "select jaratszam from jaratok, megallo where jaratok.id = utvonal.jarat_id and utvonal.megallo_id = megallo.id '"+megalloleker+"'";
            Adatbazis ab = new Adatbazis(lekerdezes);
            while (ab.Dr.Read())
            {
                lbmegallok.Text = "A megálló járatai: '" + ab.Dr["jaratszam"] +"'";
            }
                
        }
    }
}
