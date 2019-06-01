namespace ExaPooCS16a
{
    partial class Form_princ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        tract inter_tract;        // tracteur d'interface
        atlg inter_atlg;     // attelage d'interface
        coop cooper;                      // coopérative d'interface unique à prendre ne charge


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
            this.groupBox_coop = new System.Windows.Forms.GroupBox();
            this.button_val = new System.Windows.Forms.Button();
            this.label_nbouvr = new System.Windows.Forms.Label();
            this.textBox_nbouvr = new System.Windows.Forms.TextBox();
            this.label_idcoop = new System.Windows.Forms.Label();
            this.textBox_idcoop = new System.Windows.Forms.TextBox();
            this.groupBox_mat = new System.Windows.Forms.GroupBox();
            this.button_aj = new System.Windows.Forms.Button();
            this.checkBox_freins = new System.Windows.Forms.CheckBox();
            this.textBox_poly = new System.Windows.Forms.TextBox();
            this.label_nbpoly = new System.Windows.Forms.Label();
            this.textBox_pmax = new System.Windows.Forms.TextBox();
            this.label_pmax = new System.Windows.Forms.Label();
            this.label_catmat = new System.Windows.Forms.Label();
            this.comboBox_catmat = new System.Windows.Forms.ComboBox();
            this.button_recap = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.groupBox_coop.SuspendLayout();
            this.groupBox_mat.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_coop
            // 
            this.groupBox_coop.Controls.Add(this.button_val);
            this.groupBox_coop.Controls.Add(this.label_nbouvr);
            this.groupBox_coop.Controls.Add(this.textBox_nbouvr);
            this.groupBox_coop.Controls.Add(this.label_idcoop);
            this.groupBox_coop.Controls.Add(this.textBox_idcoop);
            this.groupBox_coop.Location = new System.Drawing.Point(24, 12);
            this.groupBox_coop.Name = "groupBox_coop";
            this.groupBox_coop.Size = new System.Drawing.Size(248, 102);
            this.groupBox_coop.TabIndex = 0;
            this.groupBox_coop.TabStop = false;
            this.groupBox_coop.Text = "Coopérative";
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
            // label_nbouvr
            // 
            this.label_nbouvr.AutoSize = true;
            this.label_nbouvr.Location = new System.Drawing.Point(6, 48);
            this.label_nbouvr.Name = "label_nbouvr";
            this.label_nbouvr.Size = new System.Drawing.Size(92, 13);
            this.label_nbouvr.TabIndex = 1;
            this.label_nbouvr.Text = "Nombre d\'ouvriers";
            // 
            // textBox_nbouvr
            // 
            this.textBox_nbouvr.Location = new System.Drawing.Point(111, 45);
            this.textBox_nbouvr.Name = "textBox_nbouvr";
            this.textBox_nbouvr.Size = new System.Drawing.Size(119, 20);
            this.textBox_nbouvr.TabIndex = 10;
            // 
            // label_idcoop
            // 
            this.label_idcoop.AutoSize = true;
            this.label_idcoop.Location = new System.Drawing.Point(6, 22);
            this.label_idcoop.Name = "label_idcoop";
            this.label_idcoop.Size = new System.Drawing.Size(53, 13);
            this.label_idcoop.TabIndex = 1;
            this.label_idcoop.Text = "Identifiant";
            // 
            // textBox_idcoop
            // 
            this.textBox_idcoop.Location = new System.Drawing.Point(80, 19);
            this.textBox_idcoop.Name = "textBox_idcoop";
            this.textBox_idcoop.Size = new System.Drawing.Size(150, 20);
            this.textBox_idcoop.TabIndex = 1;
            // 
            // groupBox_mat
            // 
            this.groupBox_mat.Controls.Add(this.button_aj);
            this.groupBox_mat.Controls.Add(this.checkBox_freins);
            this.groupBox_mat.Controls.Add(this.textBox_poly);
            this.groupBox_mat.Controls.Add(this.label_nbpoly);
            this.groupBox_mat.Controls.Add(this.textBox_pmax);
            this.groupBox_mat.Controls.Add(this.label_pmax);
            this.groupBox_mat.Controls.Add(this.label_catmat);
            this.groupBox_mat.Controls.Add(this.comboBox_catmat);
            this.groupBox_mat.Enabled = false;
            this.groupBox_mat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_mat.Location = new System.Drawing.Point(24, 120);
            this.groupBox_mat.Name = "groupBox_mat";
            this.groupBox_mat.Size = new System.Drawing.Size(248, 140);
            this.groupBox_mat.TabIndex = 0;
            this.groupBox_mat.TabStop = false;
            this.groupBox_mat.Text = "Matériel";
            // 
            // button_aj
            // 
            this.button_aj.Location = new System.Drawing.Point(153, 106);
            this.button_aj.Name = "button_aj";
            this.button_aj.Size = new System.Drawing.Size(75, 23);
            this.button_aj.TabIndex = 80;
            this.button_aj.Text = "Ajouter";
            this.button_aj.UseVisualStyleBackColor = true;
            this.button_aj.Click += new System.EventHandler(this.button_aj_Click);
            // 
            // checkBox_freins
            // 
            this.checkBox_freins.AutoSize = true;
            this.checkBox_freins.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_freins.Location = new System.Drawing.Point(9, 102);
            this.checkBox_freins.Name = "checkBox_freins";
            this.checkBox_freins.Size = new System.Drawing.Size(61, 17);
            this.checkBox_freins.TabIndex = 70;
            this.checkBox_freins.Text = "Freinée";
            this.checkBox_freins.UseVisualStyleBackColor = true;
            this.checkBox_freins.Visible = false;
            // 
            // textBox_poly
            // 
            this.textBox_poly.Location = new System.Drawing.Point(160, 74);
            this.textBox_poly.Name = "textBox_poly";
            this.textBox_poly.Size = new System.Drawing.Size(68, 20);
            this.textBox_poly.TabIndex = 60;
            this.textBox_poly.Visible = false;
            // 
            // label_nbpoly
            // 
            this.label_nbpoly.AutoSize = true;
            this.label_nbpoly.Location = new System.Drawing.Point(6, 77);
            this.label_nbpoly.Name = "label_nbpoly";
            this.label_nbpoly.Size = new System.Drawing.Size(59, 13);
            this.label_nbpoly.TabIndex = 2;
            this.label_nbpoly.Text = "Nombre de";
            this.label_nbpoly.Visible = false;
            // 
            // textBox_pmax
            // 
            this.textBox_pmax.Location = new System.Drawing.Point(78, 21);
            this.textBox_pmax.Name = "textBox_pmax";
            this.textBox_pmax.Size = new System.Drawing.Size(68, 20);
            this.textBox_pmax.TabIndex = 40;
            // 
            // label_pmax
            // 
            this.label_pmax.AutoSize = true;
            this.label_pmax.Location = new System.Drawing.Point(6, 24);
            this.label_pmax.Name = "label_pmax";
            this.label_pmax.Size = new System.Drawing.Size(55, 13);
            this.label_pmax.TabIndex = 2;
            this.label_pmax.Text = "Poids max";
            // 
            // label_catmat
            // 
            this.label_catmat.AutoSize = true;
            this.label_catmat.Location = new System.Drawing.Point(6, 50);
            this.label_catmat.Name = "label_catmat";
            this.label_catmat.Size = new System.Drawing.Size(52, 13);
            this.label_catmat.TabIndex = 1;
            this.label_catmat.Text = "Catégorie";
            // 
            // comboBox_catmat
            // 
            this.comboBox_catmat.FormattingEnabled = true;
            this.comboBox_catmat.Items.AddRange(new object[] {
            "Tracteur",
            "Attelage"});
            this.comboBox_catmat.Location = new System.Drawing.Point(78, 47);
            this.comboBox_catmat.Name = "comboBox_catmat";
            this.comboBox_catmat.Size = new System.Drawing.Size(150, 21);
            this.comboBox_catmat.TabIndex = 50;
            this.comboBox_catmat.SelectedIndexChanged += new System.EventHandler(this.comboBox_catmat_SelectedIndexChanged);
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
            this.Controls.Add(this.groupBox_mat);
            this.Controls.Add(this.groupBox_coop);
            this.Name = "Form_princ";
            this.Text = "Coopérative Agricole";
            this.groupBox_coop.ResumeLayout(false);
            this.groupBox_coop.PerformLayout();
            this.groupBox_mat.ResumeLayout(false);
            this.groupBox_mat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_coop;
        private System.Windows.Forms.GroupBox groupBox_mat;
        private System.Windows.Forms.Button button_val;
        private System.Windows.Forms.Label label_nbouvr;
        private System.Windows.Forms.TextBox textBox_nbouvr;
        private System.Windows.Forms.Label label_idcoop;
        private System.Windows.Forms.TextBox textBox_idcoop;
        private System.Windows.Forms.Button button_recap;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Label label_catmat;
        private System.Windows.Forms.ComboBox comboBox_catmat;
        private System.Windows.Forms.TextBox textBox_poly;
        private System.Windows.Forms.Label label_nbpoly;
        private System.Windows.Forms.TextBox textBox_pmax;
        private System.Windows.Forms.Label label_pmax;
        private System.Windows.Forms.Button button_aj;
        private System.Windows.Forms.CheckBox checkBox_freins;
    }
}

