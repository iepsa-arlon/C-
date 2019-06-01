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
    public partial class Form_princ : Form
    {
        public Form_princ()
        {
            InitializeComponent();
            this.inter_tract = new tract();
            this.inter_atlg = new atlg();
            this.cooper = new coop();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_val_Click(object sender, EventArgs e)
        {
            this.cooper.set_idcoop(this.textBox_idcoop.Text);
            this.cooper.set_nbouv(Convert.ToUInt16(this.textBox_nbouvr.Text));
            this.groupBox_mat.Enabled = true;
            this.groupBox_coop.Enabled = false;
        }

        private void button_aj_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.comboBox_catmat.SelectedIndex == 0)        // tracteur
                {
                    this.inter_tract.set_poidsmax(Convert.ToUInt16(this.textBox_pmax.Text));
                    this.inter_tract.set_var(Convert.ToUInt16(this.textBox_pmax.Text));
                    this.cooper.add_mat(inter_tract);
                }
                else       // attelage
                {
                    this.inter_atlg.set_poidsmax(Convert.ToUInt16(this.textBox_pmax.Text));
                    this.inter_atlg.set_var(Convert.ToUInt16(this.textBox_poly.Text));
                    this.inter_atlg.set_var(this.checkBox_freins.Checked);
                    this.cooper.add_mat(inter_atlg);
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Mémoire saturée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cooper.get_mat(this.cooper.tabmat_size() - 1).calcfc();    // calcul du facteur de cout
            this.textBox_poly.Clear();
            this.textBox_idcoop.Clear();
            this.textBox_pmax.Clear();
            this.comboBox_catmat.SelectedIndex = -1;
            this.checkBox_freins.Checked = false;
            this.label_nbpoly.Visible = false;
            this.textBox_poly.Visible = false;
            this.checkBox_freins.Visible = false;
        }


        private void button_recap_Click(object sender, EventArgs e)
        {
            Form_recap F2 = new Form_recap(cooper);
//            cooperus test = cooper;         // test du constructeur par copie de la classe cooperus
            F2.ShowDialog();
        }

        private void comboBox_catmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_catmat.SelectedIndex == 1)
            {
                this.label_nbpoly.Text = "Nombre d'essieux";
                this.checkBox_freins.Visible = true;
            }
            else
            {
                this.label_nbpoly.Text = "Puissance";
                this.checkBox_freins.Visible = false;
            }

            this.label_nbpoly.Visible = true;
            this.textBox_poly.Visible = true;

        }

        

       
       
    }
}
