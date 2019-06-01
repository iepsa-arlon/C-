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
            this.inter_instrair = new instrair();
            this.inter_instrcordes = new instrcordes();
            this.com = new comus();
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_val_Click(object sender, EventArgs e)
        {
            this.com.set_idcom(this.textBox_idmag.Text);
            this.com.set_nbempl(Convert.ToUInt16(this.textBox_nbempl.Text));
            this.groupBox_instr.Enabled = true;
            this.groupBox_mag.Enabled = false;
        }

        private void button_aj_Click(object sender, EventArgs e)
        {
            if (this.comboBox_catinstr.SelectedIndex == 0)
            {
                this.inter_instrair.set_idinstr(this.textBox_idinstr.Text);
                this.inter_instrair.set_prix(Convert.ToUInt16(this.textBox_prix.Text));
                this.inter_instrair.set_car(Convert.ToUInt16(this.textBox_poly.Text), this.checkBox_soufflet.Checked);
                this.com.add_instr(inter_instrair);
            }
            else
            {
                this.inter_instrcordes.set_idinstr(this.textBox_idinstr.Text);
                this.inter_instrcordes.set_prix(Convert.ToUInt16(this.textBox_prix.Text));
                this.inter_instrcordes.set_car(Convert.ToUInt16(this.textBox_poly.Text));
                this.com.add_instr(inter_instrcordes);
            }

            this.textBox_poly.Clear();
            this.textBox_idinstr.Clear();
            this.textBox_prix.Clear();
            this.comboBox_catinstr.SelectedIndex = -1;
            this.checkBox_soufflet.Checked = false;
            this.label_nbpoly.Visible = false;
            this.textBox_poly.Visible = false;
            this.checkBox_soufflet.Visible = false;
        }

        private void comboBox_catinstr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_catinstr.SelectedIndex == 0)
            {
                this.label_nbpoly.Text = "Nombre de touches";
                this.checkBox_soufflet.Visible = true;
            }
            else 
            {
                this.label_nbpoly.Text = "Nombre de cordes";
                this.checkBox_soufflet.Visible = false;
            }
            
            this.label_nbpoly.Visible = true;
            this.textBox_poly.Visible = true;
        }

        private void button_recap_Click(object sender, EventArgs e)
        {
            Form_recap F2 = new Form_recap(com);
//            comus test = com;         // test du constructeur par copie de la classe comus
            F2.ShowDialog();
        }

       
       
    }
}
