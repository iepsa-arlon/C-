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
        public Form_recap(comus lien)
        {
            //string soufflet;

            InitializeComponent();
            this.textBox_idscom.Text = lien.get_idcom() + " - Personnel : " + lien.get_nbempl();
            for (int x = 0; x < lien.tabinst_size(); x++)
            {
                if (!lien.get_instr(x).get_air()) // récupération des instruments à cordes
                { 
                    this.dataGridView_cordes.Rows.Add(lien.get_instr(x).get_idinstr(),
                                                        lien.get_instr(x).get_prix().ToString(),
                                                            lien.get_instr(x).get_car());
                }
                else
                {
                    /*if (lien.get_instr(x).get_car(false) != 0) soufflet = "OUI";
                    else soufflet = "NON";*/
                    this.dataGridView_air.Rows.Add(lien.get_instr(x).get_idinstr(),     // récupération des instruments à air
                                                            lien.get_instr(x).get_prix().ToString(),
                                                               lien.get_instr(x).get_car(true).ToString(),
                                                                    lien.get_instr(x).get_car(false));
                }
            }
        }
    }
}
