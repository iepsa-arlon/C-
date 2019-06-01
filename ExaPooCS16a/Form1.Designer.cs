namespace ExaPooCS16a
{
    partial class Form_princ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        instrair inter_instrair;        // instrument d'interface
        instrcordes inter_instrcordes;  // idem
        comus com;                      // commerce unique à prendre ne charge


        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_mag = new System.Windows.Forms.GroupBox();
            this.button_val = new System.Windows.Forms.Button();
            this.label_nbempl = new System.Windows.Forms.Label();
            this.textBox_nbempl = new System.Windows.Forms.TextBox();
            this.label_idmag = new System.Windows.Forms.Label();
            this.textBox_idmag = new System.Windows.Forms.TextBox();
            this.groupBox_instr = new System.Windows.Forms.GroupBox();
            this.button_aj = new System.Windows.Forms.Button();
            this.checkBox_soufflet = new System.Windows.Forms.CheckBox();
            this.textBox_poly = new System.Windows.Forms.TextBox();
            this.label_nbpoly = new System.Windows.Forms.Label();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.label_prix = new System.Windows.Forms.Label();
            this.textBox_idinstr = new System.Windows.Forms.TextBox();
            this.label_idinstr = new System.Windows.Forms.Label();
            this.label_catinstr = new System.Windows.Forms.Label();
            this.comboBox_catinstr = new System.Windows.Forms.ComboBox();
            this.button_recap = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.groupBox_mag.SuspendLayout();
            this.groupBox_instr.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_mag
            // 
            this.groupBox_mag.Controls.Add(this.button_val);
            this.groupBox_mag.Controls.Add(this.label_nbempl);
            this.groupBox_mag.Controls.Add(this.textBox_nbempl);
            this.groupBox_mag.Controls.Add(this.label_idmag);
            this.groupBox_mag.Controls.Add(this.textBox_idmag);
            this.groupBox_mag.Location = new System.Drawing.Point(24, 12);
            this.groupBox_mag.Name = "groupBox_mag";
            this.groupBox_mag.Size = new System.Drawing.Size(248, 102);
            this.groupBox_mag.TabIndex = 0;
            this.groupBox_mag.TabStop = false;
            this.groupBox_mag.Text = "Magasin";
            // 
            // button_val
            // 
            this.button_val.Location = new System.Drawing.Point(155, 73);
            this.button_val.Name = "button_val";
            this.button_val.Size = new System.Drawing.Size(75, 23);
            this.button_val.TabIndex = 20;
            this.button_val.Text = "Valider";
            this.button_val.UseVisualStyleBackColor = true;
            this.button_val.Click += new System.EventHandler(this.button_val_Click);
            // 
            // label_nbempl
            // 
            this.label_nbempl.AutoSize = true;
            this.label_nbempl.Location = new System.Drawing.Point(6, 48);
            this.label_nbempl.Name = "label_nbempl";
            this.label_nbempl.Size = new System.Drawing.Size(99, 13);
            this.label_nbempl.TabIndex = 1;
            this.label_nbempl.Text = "Nombre d\'employés";
            // 
            // textBox_nbempl
            // 
            this.textBox_nbempl.Location = new System.Drawing.Point(111, 45);
            this.textBox_nbempl.Name = "textBox_nbempl";
            this.textBox_nbempl.Size = new System.Drawing.Size(119, 20);
            this.textBox_nbempl.TabIndex = 10;
            // 
            // label_idmag
            // 
            this.label_idmag.AutoSize = true;
            this.label_idmag.Location = new System.Drawing.Point(6, 22);
            this.label_idmag.Name = "label_idmag";
            this.label_idmag.Size = new System.Drawing.Size(53, 13);
            this.label_idmag.TabIndex = 1;
            this.label_idmag.Text = "Identifiant";
            // 
            // textBox_idmag
            // 
            this.textBox_idmag.Location = new System.Drawing.Point(80, 19);
            this.textBox_idmag.Name = "textBox_idmag";
            this.textBox_idmag.Size = new System.Drawing.Size(150, 20);
            this.textBox_idmag.TabIndex = 1;
            // 
            // groupBox_instr
            // 
            this.groupBox_instr.Controls.Add(this.button_aj);
            this.groupBox_instr.Controls.Add(this.checkBox_soufflet);
            this.groupBox_instr.Controls.Add(this.textBox_poly);
            this.groupBox_instr.Controls.Add(this.label_nbpoly);
            this.groupBox_instr.Controls.Add(this.textBox_prix);
            this.groupBox_instr.Controls.Add(this.label_prix);
            this.groupBox_instr.Controls.Add(this.textBox_idinstr);
            this.groupBox_instr.Controls.Add(this.label_idinstr);
            this.groupBox_instr.Controls.Add(this.label_catinstr);
            this.groupBox_instr.Controls.Add(this.comboBox_catinstr);
            this.groupBox_instr.Enabled = false;
            this.groupBox_instr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_instr.Location = new System.Drawing.Point(24, 127);
            this.groupBox_instr.Name = "groupBox_instr";
            this.groupBox_instr.Size = new System.Drawing.Size(248, 159);
            this.groupBox_instr.TabIndex = 0;
            this.groupBox_instr.TabStop = false;
            this.groupBox_instr.Text = "Instrument";
            // 
            // button_aj
            // 
            this.button_aj.Location = new System.Drawing.Point(153, 130);
            this.button_aj.Name = "button_aj";
            this.button_aj.Size = new System.Drawing.Size(75, 23);
            this.button_aj.TabIndex = 80;
            this.button_aj.Text = "Ajouter";
            this.button_aj.UseVisualStyleBackColor = true;
            this.button_aj.Click += new System.EventHandler(this.button_aj_Click);
            // 
            // checkBox_soufflet
            // 
            this.checkBox_soufflet.AutoSize = true;
            this.checkBox_soufflet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_soufflet.Location = new System.Drawing.Point(9, 126);
            this.checkBox_soufflet.Name = "checkBox_soufflet";
            this.checkBox_soufflet.Size = new System.Drawing.Size(62, 17);
            this.checkBox_soufflet.TabIndex = 70;
            this.checkBox_soufflet.Text = "Soufflet";
            this.checkBox_soufflet.UseVisualStyleBackColor = true;
            this.checkBox_soufflet.Visible = false;
            // 
            // textBox_poly
            // 
            this.textBox_poly.Location = new System.Drawing.Point(160, 98);
            this.textBox_poly.Name = "textBox_poly";
            this.textBox_poly.Size = new System.Drawing.Size(68, 20);
            this.textBox_poly.TabIndex = 60;
            this.textBox_poly.Visible = false;
            // 
            // label_nbpoly
            // 
            this.label_nbpoly.AutoSize = true;
            this.label_nbpoly.Location = new System.Drawing.Point(6, 101);
            this.label_nbpoly.Name = "label_nbpoly";
            this.label_nbpoly.Size = new System.Drawing.Size(59, 13);
            this.label_nbpoly.TabIndex = 2;
            this.label_nbpoly.Text = "Nombre de";
            this.label_nbpoly.Visible = false;
            // 
            // textBox_prix
            // 
            this.textBox_prix.Location = new System.Drawing.Point(78, 45);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(68, 20);
            this.textBox_prix.TabIndex = 40;
            // 
            // label_prix
            // 
            this.label_prix.AutoSize = true;
            this.label_prix.Location = new System.Drawing.Point(6, 48);
            this.label_prix.Name = "label_prix";
            this.label_prix.Size = new System.Drawing.Size(24, 13);
            this.label_prix.TabIndex = 2;
            this.label_prix.Text = "Prix";
            // 
            // textBox_idinstr
            // 
            this.textBox_idinstr.Location = new System.Drawing.Point(78, 19);
            this.textBox_idinstr.Name = "textBox_idinstr";
            this.textBox_idinstr.Size = new System.Drawing.Size(150, 20);
            this.textBox_idinstr.TabIndex = 30;
            // 
            // label_idinstr
            // 
            this.label_idinstr.AutoSize = true;
            this.label_idinstr.Location = new System.Drawing.Point(6, 22);
            this.label_idinstr.Name = "label_idinstr";
            this.label_idinstr.Size = new System.Drawing.Size(53, 13);
            this.label_idinstr.TabIndex = 2;
            this.label_idinstr.Text = "Identifiant";
            // 
            // label_catinstr
            // 
            this.label_catinstr.AutoSize = true;
            this.label_catinstr.Location = new System.Drawing.Point(6, 74);
            this.label_catinstr.Name = "label_catinstr";
            this.label_catinstr.Size = new System.Drawing.Size(52, 13);
            this.label_catinstr.TabIndex = 1;
            this.label_catinstr.Text = "Catégorie";
            // 
            // comboBox_catinstr
            // 
            this.comboBox_catinstr.FormattingEnabled = true;
            this.comboBox_catinstr.Items.AddRange(new object[] {
            "Instrument à Air",
            "Instrument à Cordes"});
            this.comboBox_catinstr.Location = new System.Drawing.Point(78, 71);
            this.comboBox_catinstr.Name = "comboBox_catinstr";
            this.comboBox_catinstr.Size = new System.Drawing.Size(150, 21);
            this.comboBox_catinstr.TabIndex = 50;
            this.comboBox_catinstr.SelectedIndexChanged += new System.EventHandler(this.comboBox_catinstr_SelectedIndexChanged);
            // 
            // button_recap
            // 
            this.button_recap.Location = new System.Drawing.Point(24, 292);
            this.button_recap.Name = "button_recap";
            this.button_recap.Size = new System.Drawing.Size(75, 23);
            this.button_recap.TabIndex = 1;
            this.button_recap.TabStop = false;
            this.button_recap.Text = "Recapitulatif";
            this.button_recap.UseVisualStyleBackColor = true;
            this.button_recap.Click += new System.EventHandler(this.button_recap_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(195, 292);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 2;
            this.button_quit.TabStop = false;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // Form_princ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 327);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_recap);
            this.Controls.Add(this.groupBox_instr);
            this.Controls.Add(this.groupBox_mag);
            this.Name = "Form_princ";
            this.Text = "Music Store";
            this.groupBox_mag.ResumeLayout(false);
            this.groupBox_mag.PerformLayout();
            this.groupBox_instr.ResumeLayout(false);
            this.groupBox_instr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_mag;
        private System.Windows.Forms.GroupBox groupBox_instr;
        private System.Windows.Forms.Button button_val;
        private System.Windows.Forms.Label label_nbempl;
        private System.Windows.Forms.TextBox textBox_nbempl;
        private System.Windows.Forms.Label label_idmag;
        private System.Windows.Forms.TextBox textBox_idmag;
        private System.Windows.Forms.Button button_recap;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.TextBox textBox_idinstr;
        private System.Windows.Forms.Label label_idinstr;
        private System.Windows.Forms.Label label_catinstr;
        private System.Windows.Forms.ComboBox comboBox_catinstr;
        private System.Windows.Forms.TextBox textBox_poly;
        private System.Windows.Forms.Label label_nbpoly;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.Label label_prix;
        private System.Windows.Forms.Button button_aj;
        private System.Windows.Forms.CheckBox checkBox_soufflet;
    }
}

