using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExaCs15a
{
    public partial class Form_princ : Form
    {
        public Form_princ()
        {
            InitializeComponent();
            inter_mot = new mot(true);
            inter_nonmot = new nonmot(false);
            Array.Resize(ref tabcoop, 0);
        }

        private void textBox_idcoo_TextChanged(object sender, EventArgs e)
        {
            if (textBox_idcoo.Text.Length != 0 && comboBox_coo.SelectedIndex != -1) button_addcoo.Enabled = true;
            else button_addcoo.Enabled = false;
        }

        private void button_addcoo_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Resize(ref tabcoop, tabcoop.Length + 1);
                tabcoop[tabcoop.Length - 1] = new coop();
                tabcoop[tabcoop.Length - 1].set_idcoop(textBox_idcoo.Text);
                tabcoop[tabcoop.Length - 1].set_typcult((uint) comboBox_coo.SelectedIndex);
                groupBox_coo.Enabled = false;
                groupBox_mat.Enabled = true;
                comboBox_mat.Focus();
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Mémoire saturée: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_clot_Click(object sender, EventArgs e)
        {
            textBox_idmat.Clear();
            textBox_mixte.Clear();
            comboBox_mat.SelectedIndex = -1;
            label_mixte.Visible = false;
            textBox_mixte.Visible = false;
            groupBox_mat.Enabled = false;
            groupBox_coo.Enabled = true;
            textBox_idcoo.Clear();
            comboBox_coo.SelectedIndex = -1;
            textBox_idcoo.Focus();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_mixte_TextChanged(object sender, EventArgs e)
        {
            if (textBox_idmat.Text.Length != 0 && textBox_mixte.Text.Length != 0 && comboBox_mat.SelectedIndex != -1) button_addmat.Enabled = true;
            else button_addmat.Enabled = false;
        }

        private void affiche(uint x)
        {
            string inter_string;

             switch(tabcoop[x].get_typcult())
                {
                    case 0:
                        inter_string = "Sol";
                        break;

                    case 1: 
                        inter_string = "Air";
                        break;

                    default:
                        inter_string = "Mixte";
                        break;
                }

            textBox_recap.Tag = x;

            if (x == 0) button_prec.Enabled = false;
            else button_prec.Enabled = true;

            if (x == tabcoop.Length - 1) button_suiv.Enabled = false;
            else button_suiv.Enabled = true;

            textBox_recap.Text = tabcoop[x].get_idcoop() + " - " + inter_string + " - " + (x+1) + "/" + tabcoop.Length.ToString();
            dataGridView_recap.Rows.Clear();

            for (uint y = 0; y < tabcoop[x].tab_size(false); y++) dataGridView_recap.Rows.Add("Non Motorisé",
                                                                                                tabcoop[x].view_nonmot(y).get_idmat(), 
                                                                                                tabcoop[x].view_nonmot(y).get_datach(), " XXX");
            for (uint y = 0; y < tabcoop[x].tab_size(true); y++) dataGridView_recap.Rows.Add("Motorisé",
                                                                                                tabcoop[x].view_mot(y).get_idmat(),
                                                                                                "XXX", tabcoop[x].view_mot(y).get_nbh().ToString());
        }

        private void button_addmat_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_mat.SelectedIndex == 0)
                {
                    inter_nonmot.set_idmat(textBox_idmat.Text);
                    inter_nonmot.set_datach(textBox_mixte.Text);
                    tabcoop[tabcoop.Length - 1].add_nonmot(inter_nonmot);
                }
                else
                {
                    inter_mot.set_idmat(textBox_idmat.Text);
                    inter_mot.set_nbh(Convert.ToUInt16(textBox_mixte.Text));
                    tabcoop[tabcoop.Length - 1].add_mot(inter_mot);
                }

                affiche((uint) tabcoop.Length - 1);
                textBox_idmat.Clear();
                textBox_mixte.Clear();
                textBox_mixte.Visible = false;
                label_mixte.Visible = false;
                comboBox_mat.SelectedIndex = -1;
                comboBox_mat.Focus();
                button_prec.Enabled = true;
                button_suiv.Enabled = true;
            }

            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Mémoire saturée: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception)
            {
                MessageBox.Show("Données introduites invalides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_idmat.Focus();
                textBox_idmat.SelectAll();
            }      
        }

        private void button_prec_Click(object sender, EventArgs e)
        {
            uint indice = (uint) textBox_recap.Tag;
            affiche(--indice);
        }

        private void button_suiv_Click(object sender, EventArgs e)
        {
            uint indice = (uint)textBox_recap.Tag;
            affiche(++indice);
        }

        private void comboBox_mat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_mat.SelectedIndex)
            {
                case 0: label_mixte.Text = "Date d'achat";
                    label_mixte.Visible = true;
                    textBox_mixte.Visible = true;
                    break;

                case 1: label_mixte.Text = "Heures d'activité";
                    label_mixte.Visible = true;
                    textBox_mixte.Visible = true;
                    break;

                default: break;
            }
        }
    }
}
