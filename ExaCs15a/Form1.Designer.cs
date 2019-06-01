namespace ExaCs15a
{
    partial class Form_princ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        /// 
        private coop[] tabcoop;
        private mot inter_mot;
        private nonmot inter_nonmot;

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
            this.groupBox_coo = new System.Windows.Forms.GroupBox();
            this.button_addcoo = new System.Windows.Forms.Button();
            this.comboBox_coo = new System.Windows.Forms.ComboBox();
            this.textBox_idcoo = new System.Windows.Forms.TextBox();
            this.label_typcul = new System.Windows.Forms.Label();
            this.label_idcoo = new System.Windows.Forms.Label();
            this.groupBox_mat = new System.Windows.Forms.GroupBox();
            this.button_clot = new System.Windows.Forms.Button();
            this.button_addmat = new System.Windows.Forms.Button();
            this.comboBox_mat = new System.Windows.Forms.ComboBox();
            this.label_typmat = new System.Windows.Forms.Label();
            this.textBox_idmat = new System.Windows.Forms.TextBox();
            this.label_idmat = new System.Windows.Forms.Label();
            this.textBox_recap = new System.Windows.Forms.TextBox();
            this.label_recap = new System.Windows.Forms.Label();
            this.button_prec = new System.Windows.Forms.Button();
            this.button_suiv = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.dataGridView_recap = new System.Windows.Forms.DataGridView();
            this.label_mixte = new System.Windows.Forms.Label();
            this.textBox_mixte = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_coo.SuspendLayout();
            this.groupBox_mat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_coo
            // 
            this.groupBox_coo.Controls.Add(this.button_addcoo);
            this.groupBox_coo.Controls.Add(this.comboBox_coo);
            this.groupBox_coo.Controls.Add(this.textBox_idcoo);
            this.groupBox_coo.Controls.Add(this.label_typcul);
            this.groupBox_coo.Controls.Add(this.label_idcoo);
            this.groupBox_coo.Location = new System.Drawing.Point(11, 13);
            this.groupBox_coo.Name = "groupBox_coo";
            this.groupBox_coo.Size = new System.Drawing.Size(214, 99);
            this.groupBox_coo.TabIndex = 0;
            this.groupBox_coo.TabStop = false;
            this.groupBox_coo.Text = "Coopérative";
            // 
            // button_addcoo
            // 
            this.button_addcoo.Enabled = false;
            this.button_addcoo.Location = new System.Drawing.Point(20, 70);
            this.button_addcoo.Name = "button_addcoo";
            this.button_addcoo.Size = new System.Drawing.Size(75, 23);
            this.button_addcoo.TabIndex = 30;
            this.button_addcoo.Text = "Ajouter";
            this.button_addcoo.UseVisualStyleBackColor = true;
            this.button_addcoo.Click += new System.EventHandler(this.button_addcoo_Click);
            // 
            // comboBox_coo
            // 
            this.comboBox_coo.FormattingEnabled = true;
            this.comboBox_coo.Items.AddRange(new object[] {
            "Sol",
            "Air",
            "Mixte"});
            this.comboBox_coo.Location = new System.Drawing.Point(100, 42);
            this.comboBox_coo.Name = "comboBox_coo";
            this.comboBox_coo.Size = new System.Drawing.Size(108, 21);
            this.comboBox_coo.TabIndex = 20;
            this.comboBox_coo.SelectedIndexChanged += new System.EventHandler(this.textBox_idcoo_TextChanged);
            // 
            // textBox_idcoo
            // 
            this.textBox_idcoo.Location = new System.Drawing.Point(72, 19);
            this.textBox_idcoo.Name = "textBox_idcoo";
            this.textBox_idcoo.Size = new System.Drawing.Size(136, 20);
            this.textBox_idcoo.TabIndex = 10;
            this.textBox_idcoo.TextChanged += new System.EventHandler(this.textBox_idcoo_TextChanged);
            // 
            // label_typcul
            // 
            this.label_typcul.AutoSize = true;
            this.label_typcul.Location = new System.Drawing.Point(17, 45);
            this.label_typcul.Name = "label_typcul";
            this.label_typcul.Size = new System.Drawing.Size(86, 13);
            this.label_typcul.TabIndex = 0;
            this.label_typcul.Text = "Type de cultures";
            // 
            // label_idcoo
            // 
            this.label_idcoo.AutoSize = true;
            this.label_idcoo.Location = new System.Drawing.Point(17, 23);
            this.label_idcoo.Name = "label_idcoo";
            this.label_idcoo.Size = new System.Drawing.Size(53, 13);
            this.label_idcoo.TabIndex = 0;
            this.label_idcoo.Text = "Identifiant";
            // 
            // groupBox_mat
            // 
            this.groupBox_mat.Controls.Add(this.button_clot);
            this.groupBox_mat.Controls.Add(this.button_addmat);
            this.groupBox_mat.Controls.Add(this.comboBox_mat);
            this.groupBox_mat.Controls.Add(this.label_typmat);
            this.groupBox_mat.Controls.Add(this.textBox_mixte);
            this.groupBox_mat.Controls.Add(this.label_mixte);
            this.groupBox_mat.Controls.Add(this.textBox_idmat);
            this.groupBox_mat.Controls.Add(this.label_idmat);
            this.groupBox_mat.Enabled = false;
            this.groupBox_mat.Location = new System.Drawing.Point(231, 12);
            this.groupBox_mat.Name = "groupBox_mat";
            this.groupBox_mat.Size = new System.Drawing.Size(231, 129);
            this.groupBox_mat.TabIndex = 1;
            this.groupBox_mat.TabStop = false;
            this.groupBox_mat.Text = "Matériel";
            // 
            // button_clot
            // 
            this.button_clot.Location = new System.Drawing.Point(150, 96);
            this.button_clot.Name = "button_clot";
            this.button_clot.Size = new System.Drawing.Size(75, 23);
            this.button_clot.TabIndex = 70;
            this.button_clot.Text = "Cloturer";
            this.button_clot.UseVisualStyleBackColor = true;
            this.button_clot.Click += new System.EventHandler(this.button_clot_Click);
            // 
            // button_addmat
            // 
            this.button_addmat.Enabled = false;
            this.button_addmat.Location = new System.Drawing.Point(6, 96);
            this.button_addmat.Name = "button_addmat";
            this.button_addmat.Size = new System.Drawing.Size(75, 23);
            this.button_addmat.TabIndex = 60;
            this.button_addmat.Text = "Ajouter";
            this.button_addmat.UseVisualStyleBackColor = true;
            this.button_addmat.Click += new System.EventHandler(this.button_addmat_Click);
            // 
            // comboBox_mat
            // 
            this.comboBox_mat.FormattingEnabled = true;
            this.comboBox_mat.Items.AddRange(new object[] {
            "Non motorisé",
            "Motorisé"});
            this.comboBox_mat.Location = new System.Drawing.Point(91, 17);
            this.comboBox_mat.Name = "comboBox_mat";
            this.comboBox_mat.Size = new System.Drawing.Size(131, 21);
            this.comboBox_mat.TabIndex = 40;
            this.comboBox_mat.SelectedIndexChanged += new System.EventHandler(this.comboBox_mat_SelectedIndexChanged);
            // 
            // label_typmat
            // 
            this.label_typmat.AutoSize = true;
            this.label_typmat.Location = new System.Drawing.Point(8, 20);
            this.label_typmat.Name = "label_typmat";
            this.label_typmat.Size = new System.Drawing.Size(85, 13);
            this.label_typmat.TabIndex = 0;
            this.label_typmat.Text = "Type de matériel";
            // 
            // textBox_idmat
            // 
            this.textBox_idmat.Location = new System.Drawing.Point(91, 43);
            this.textBox_idmat.Name = "textBox_idmat";
            this.textBox_idmat.Size = new System.Drawing.Size(131, 20);
            this.textBox_idmat.TabIndex = 50;
            this.textBox_idmat.TextChanged += new System.EventHandler(this.textBox_mixte_TextChanged);
            // 
            // label_idmat
            // 
            this.label_idmat.AutoSize = true;
            this.label_idmat.Location = new System.Drawing.Point(8, 46);
            this.label_idmat.Name = "label_idmat";
            this.label_idmat.Size = new System.Drawing.Size(53, 13);
            this.label_idmat.TabIndex = 0;
            this.label_idmat.Text = "Identifiant";
            // 
            // textBox_recap
            // 
            this.textBox_recap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_recap.Location = new System.Drawing.Point(83, 147);
            this.textBox_recap.Name = "textBox_recap";
            this.textBox_recap.ReadOnly = true;
            this.textBox_recap.Size = new System.Drawing.Size(284, 20);
            this.textBox_recap.TabIndex = 1;
            this.textBox_recap.TabStop = false;
            // 
            // label_recap
            // 
            this.label_recap.AutoSize = true;
            this.label_recap.Location = new System.Drawing.Point(15, 150);
            this.label_recap.Name = "label_recap";
            this.label_recap.Size = new System.Drawing.Size(66, 13);
            this.label_recap.TabIndex = 2;
            this.label_recap.Text = "Récapitulatif";
            // 
            // button_prec
            // 
            this.button_prec.Enabled = false;
            this.button_prec.Location = new System.Drawing.Point(373, 147);
            this.button_prec.Name = "button_prec";
            this.button_prec.Size = new System.Drawing.Size(49, 23);
            this.button_prec.TabIndex = 3;
            this.button_prec.TabStop = false;
            this.button_prec.Text = "<<";
            this.button_prec.UseVisualStyleBackColor = true;
            this.button_prec.Click += new System.EventHandler(this.button_prec_Click);
            // 
            // button_suiv
            // 
            this.button_suiv.Enabled = false;
            this.button_suiv.Location = new System.Drawing.Point(427, 147);
            this.button_suiv.Name = "button_suiv";
            this.button_suiv.Size = new System.Drawing.Size(49, 23);
            this.button_suiv.TabIndex = 3;
            this.button_suiv.TabStop = false;
            this.button_suiv.Text = ">>";
            this.button_suiv.UseVisualStyleBackColor = true;
            this.button_suiv.Click += new System.EventHandler(this.button_suiv_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(11, 118);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 4;
            this.button_quit.TabStop = false;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // dataGridView_recap
            // 
            this.dataGridView_recap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.idmat,
            this.datach,
            this.nbh});
            this.dataGridView_recap.Location = new System.Drawing.Point(18, 173);
            this.dataGridView_recap.Name = "dataGridView_recap";
            this.dataGridView_recap.Size = new System.Drawing.Size(444, 271);
            this.dataGridView_recap.TabIndex = 5;
            this.dataGridView_recap.TabStop = false;
            // 
            // label_mixte
            // 
            this.label_mixte.AutoSize = true;
            this.label_mixte.Location = new System.Drawing.Point(8, 72);
            this.label_mixte.Name = "label_mixte";
            this.label_mixte.Size = new System.Drawing.Size(68, 13);
            this.label_mixte.TabIndex = 0;
            this.label_mixte.Text = "Date d\'achat";
            this.label_mixte.Visible = false;
            // 
            // textBox_mixte
            // 
            this.textBox_mixte.Location = new System.Drawing.Point(91, 69);
            this.textBox_mixte.Name = "textBox_mixte";
            this.textBox_mixte.Size = new System.Drawing.Size(131, 20);
            this.textBox_mixte.TabIndex = 55;
            this.textBox_mixte.Visible = false;
            this.textBox_mixte.TextChanged += new System.EventHandler(this.textBox_mixte_TextChanged);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type matériel";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // idmat
            // 
            this.idmat.HeaderText = "Identifiant";
            this.idmat.Name = "idmat";
            this.idmat.ReadOnly = true;
            // 
            // datach
            // 
            this.datach.HeaderText = "Date Achat";
            this.datach.Name = "datach";
            this.datach.ReadOnly = true;
            // 
            // nbh
            // 
            this.nbh.HeaderText = "Nb Heures";
            this.nbh.Name = "nbh";
            this.nbh.ReadOnly = true;
            // 
            // Form_princ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 456);
            this.Controls.Add(this.dataGridView_recap);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_suiv);
            this.Controls.Add(this.button_prec);
            this.Controls.Add(this.label_recap);
            this.Controls.Add(this.groupBox_mat);
            this.Controls.Add(this.groupBox_coo);
            this.Controls.Add(this.textBox_recap);
            this.Name = "Form_princ";
            this.Text = "AgriGes";
            this.groupBox_coo.ResumeLayout(false);
            this.groupBox_coo.PerformLayout();
            this.groupBox_mat.ResumeLayout(false);
            this.groupBox_mat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_coo;
        private System.Windows.Forms.Button button_addcoo;
        private System.Windows.Forms.ComboBox comboBox_coo;
        private System.Windows.Forms.TextBox textBox_idcoo;
        private System.Windows.Forms.Label label_typcul;
        private System.Windows.Forms.Label label_idcoo;
        private System.Windows.Forms.GroupBox groupBox_mat;
        private System.Windows.Forms.Button button_addmat;
        private System.Windows.Forms.ComboBox comboBox_mat;
        private System.Windows.Forms.Label label_typmat;
        private System.Windows.Forms.TextBox textBox_idmat;
        private System.Windows.Forms.Label label_idmat;
        private System.Windows.Forms.TextBox textBox_recap;
        private System.Windows.Forms.Label label_recap;
        private System.Windows.Forms.Button button_prec;
        private System.Windows.Forms.Button button_suiv;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_clot;
        private System.Windows.Forms.DataGridView dataGridView_recap;
        private System.Windows.Forms.TextBox textBox_mixte;
        private System.Windows.Forms.Label label_mixte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn datach;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbh;
    }
}

