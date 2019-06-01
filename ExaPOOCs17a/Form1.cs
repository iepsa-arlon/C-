using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaPOOCs17a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Array.Resize(ref tabcit, 0);
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Array.Clear(tabcit, 0, tabcit.Length);
            Application.Exit();
        }

        private void comboBox_typcit_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_ValTypCit.Enabled = true;    
        }

        private void button_ValTypCit_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Resize(ref tabcit, tabcit.Length + 1);
                switch (comboBox_typcit.SelectedIndex)
                {
                    case 0:
                        tabcit[tabcit.Length - 1] = new cub();
                        label_dim1.Text = "Côté";
                        label_dim1.Visible = true;
                        textBox_dim1.Visible = true;
                        label_dim2.Visible = false;
                        textBox_dim2.Visible = false;
                        label_dim3.Visible = false;
                        textBox_dim3.Visible = false;
                        break;

                    case 1:
                        tabcit[tabcit.Length - 1] = new cyl();
                        label_dim1.Text = "Longueur";
                        label_dim1.Visible = true;
                        textBox_dim1.Visible = true;
                        label_dim2.Text = "Diamètre";
                        label_dim2.Visible = true;
                        textBox_dim2.Visible = true;
                        label_dim3.Visible = false;
                        textBox_dim3.Visible = false;
                        break;

                    case 2:
                        tabcit[tabcit.Length - 1] = new para();
                        label_dim1.Text = "Longueur";
                        label_dim1.Visible = true;
                        textBox_dim1.Visible = true;
                        label_dim2.Text = "Hauteur";
                        label_dim2.Visible = true;
                        textBox_dim2.Visible = true;
                        label_dim3.Text = "Largeur";
                        label_dim3.Visible = true;
                        textBox_dim3.Visible = true;
                        break;
                }

                groupBox_intro.Enabled = true;
                button_ValTypCit.Enabled = false;
                comboBox_typcit.Enabled = false;
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Mémoire saturée - Libérer des ressources puis réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_dim1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_typcarb.SelectedIndex != -1 && 
                    ((tabcit[tabcit.Length - 1].get_typcit() == 1 && textBox_dim1.Text.Length != 0) ||
                       (tabcit[tabcit.Length - 1].get_typcit() == 2 && textBox_dim1.Text.Length != 0 && textBox_dim2.Text.Length != 0) ||
                            (tabcit[tabcit.Length - 1].get_typcit() == 3 && textBox_dim1.Text.Length != 0 && textBox_dim2.Text.Length != 0 && textBox_dim3.Text.Length != 0))) button_val.Enabled = true;
            
            else button_val.Enabled = false;
        }

        private void button_val_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_typcarb.SelectedIndex == 0) tabcit[tabcit.Length - 1].set_typcarb(true);
                else tabcit[tabcit.Length - 1].set_typcarb(false);
                switch (tabcit[tabcit.Length - 1].get_typcit())
                {
                    case 1:
                        tabcit[tabcit.Length - 1].introdim(Convert.ToUInt16(textBox_dim1.Text));
                        break;

                    case 2:
                        tabcit[tabcit.Length - 1].introdim(Convert.ToUInt16(textBox_dim1.Text), Convert.ToUInt16(textBox_dim2.Text));
                        break;

                    case 3:
                        tabcit[tabcit.Length - 1].introdim(Convert.ToUInt16(textBox_dim1.Text), Convert.ToUInt16(textBox_dim2.Text), Convert.ToUInt16(textBox_dim3.Text));
                        break;
                }

                tabcit[tabcit.Length - 1].calc_vol();
                
                string carbu;
                if (tabcit[tabcit.Length - 1].get_typcarb() == true) carbu = "Essence";
                else carbu = "Diesel";

                switch (tabcit[tabcit.Length - 1].get_typcit())
                {
                    case 1:
                        dataGridView_recap.Rows.Add("Cubique", 
                            tabcit[tabcit.Length - 1].get_vol().ToString(), 
                                carbu,
                                    tabcit[tabcit.Length - 1].recudim(1));
                        break;

                    case 2:
                        dataGridView_recap.Rows.Add("Cylindrique", 
                            tabcit[tabcit.Length - 1].get_vol().ToString(), 
                                carbu,
                                    tabcit[tabcit.Length - 1].recudim(1),
                                       tabcit[tabcit.Length - 1].recudim(2));                        
                        break;

                    case 3:
                        dataGridView_recap.Rows.Add("Cylindrique",
                            tabcit[tabcit.Length - 1].get_vol().ToString(),
                                carbu,
                                    tabcit[tabcit.Length - 1].recudim(1),
                                       tabcit[tabcit.Length - 1].recudim(2),
                                           tabcit[tabcit.Length - 1].recudim(3));
                        break;
                }

                groupBox_intro.Enabled = false;
                button_ValTypCit.Enabled = true;
                comboBox_typcit.Enabled = true;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Valeur numériques invalides - Vérifier les dimensions","Erreur encodage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_dim1.Focus();
            }
        }
    }
}
