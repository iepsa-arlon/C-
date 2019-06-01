using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExaPooCS16a
{
    public partial class Form_recap : Form
    {
        public Form_recap(coop lien)
        {
            InitializeComponent();
            this.textBox_idcoop_nbouv.Text = lien.get_idcoop() + " - Ouvriers : " + lien.get_nbouv();
            for (int x = 0; x < lien.tabmat_size(); x++)
            {
                if (lien.get_mat(x).get_tract()) // récupération des instruments à cordes
                {
                    string typem = "Tract";
                    this.dataGridView_recap.Rows.Add(typem,
                                                        lien.get_mat(x).get_factcout().ToString(),
                                                            lien.get_mat(x).get_poidsmax().ToString(),
                                                                lien.get_mat(x).get_var(),"",false);
                }
                else
                {
                    string typem = "Atel";
                    bool test = lien.get_mat(x).get_var(true);
                    //if (lien.get_instr(x).get_car(false) != 0) soufflet = "OUI";
                    //else soufflet = "NON";
                    this.dataGridView_recap.Rows.Add(typem,     // récupération des instruments à air
                                                        lien.get_mat(x).get_factcout().ToString(),
                                                           lien.get_mat(x).get_poidsmax().ToString(),"",
                                                               lien.get_mat(x).get_var(),
                                                                    lien.get_mat(x).get_var(true));
                }
            }
        }
    }
}
