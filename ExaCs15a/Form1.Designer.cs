namespace ExaCs15a
{
    partial class Form_princ
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
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
            this.groupBox_coo = new System.Windows.Forms.GroupBox();
            this.button_addcoo = new System.Windows.Forms.Button();
            this.comboBox_coo = new System.Windows.Forms.ComboBox();
            this.textBox_idcoo = new System.Windows.Forms.TextBox();
            this.label_typcul = new System.Windows.Forms.Label();
            this.label_idcoo = new System.Windows.Forms.Label();
            this.groupBox_mat = new System.Windows.Forms.GroupBox();
            this.button_addmat = new System.Windows.Forms.Button();
            this.comboBox_mat = new System.Windows.Forms.ComboBox();
            this.label_typmat = new System.Windows.Forms.Label();
            this.textBox_mixte = new System.Windows.Forms.TextBox();
            this.label_mixte = new System.Windows.Forms.Label();
            this.textBox_recap = new System.Windows.Forms.TextBox();
            this.label_recap = new System.Windows.Forms.Label();
            this.button_prec = new System.Windows.Forms.Button();
            this.button_suiv = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.groupBox_coo.SuspendLayout();
            this.groupBox_mat.SuspendLayout();
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
            this.button_addcoo.Location = new System.Drawing.Point(20, 70);
            this.button_addcoo.Name = "button_addcoo";
            this.button_addcoo.Size = new System.Drawing.Size(75, 23);
            this.button_addcoo.TabIndex = 3;
            this.button_addcoo.Text = "Ajouter";
            this.button_addcoo.UseVisualStyleBackColor = true;
            // 
            // comboBox_coo
            // 
            this.comboBox_coo.FormattingEnabled = true;
            this.comboBox_coo.Location = new System.Drawing.Point(100, 42);
            this.comboBox_coo.Name = "comboBox_coo";
            this.comboBox_coo.Size = new System.Drawing.Size(108, 21);
            this.comboBox_coo.TabIndex = 2;
            // 
            // textBox_idcoo
            // 
            this.textBox_idcoo.Location = new System.Drawing.Point(72, 19);
            this.textBox_idcoo.Name = "textBox_idcoo";
            this.textBox_idcoo.Size = new System.Drawing.Size(136, 20);
            this.textBox_idcoo.TabIndex = 1;
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
            this.groupBox_mat.Controls.Add(this.button_addmat);
            this.groupBox_mat.Controls.Add(this.comboBox_mat);
            this.groupBox_mat.Controls.Add(this.label_typmat);
            this.groupBox_mat.Controls.Add(this.textBox_mixte);
            this.groupBox_mat.Controls.Add(this.label_mixte);
            this.groupBox_mat.Location = new System.Drawing.Point(231, 12);
            this.groupBox_mat.Name = "groupBox_mat";
            this.groupBox_mat.Size = new System.Drawing.Size(231, 99);
            this.groupBox_mat.TabIndex = 1;
            this.groupBox_mat.TabStop = false;
            this.groupBox_mat.Text = "Matériel";
            // 
            // button_addmat
            // 
            this.button_addmat.Location = new System.Drawing.Point(11, 71);
            this.button_addmat.Name = "button_addmat";
            this.button_addmat.Size = new System.Drawing.Size(75, 23);
            this.button_addmat.TabIndex = 3;
            this.button_addmat.Text = "Ajouter";
            this.button_addmat.UseVisualStyleBackColor = true;
            // 
            // comboBox_mat
            // 
            this.comboBox_mat.FormattingEnabled = true;
            this.comboBox_mat.Location = new System.Drawing.Point(91, 17);
            this.comboBox_mat.Name = "comboBox_mat";
            this.comboBox_mat.Size = new System.Drawing.Size(131, 21);
            this.comboBox_mat.TabIndex = 2;
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
            // textBox_mixte
            // 
            this.textBox_mixte.Location = new System.Drawing.Point(91, 43);
            this.textBox_mixte.Name = "textBox_mixte";
            this.textBox_mixte.Size = new System.Drawing.Size(131, 20);
            this.textBox_mixte.TabIndex = 1;
            // 
            // label_mixte
            // 
            this.label_mixte.AutoSize = true;
            this.label_mixte.Location = new System.Drawing.Point(8, 46);
            this.label_mixte.Name = "label_mixte";
            this.label_mixte.Size = new System.Drawing.Size(68, 13);
            this.label_mixte.TabIndex = 0;
            this.label_mixte.Text = "Date d\'achat";
            // 
            // textBox_recap
            // 
            this.textBox_recap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_recap.Location = new System.Drawing.Point(111, 117);
            this.textBox_recap.Name = "textBox_recap";
            this.textBox_recap.ReadOnly = true;
            this.textBox_recap.Size = new System.Drawing.Size(213, 20);
            this.textBox_recap.TabIndex = 1;
            // 
            // label_recap
            // 
            this.label_recap.AutoSize = true;
            this.label_recap.Location = new System.Drawing.Point(46, 120);
            this.label_recap.Name = "label_recap";
            this.label_recap.Size = new System.Drawing.Size(66, 13);
            this.label_recap.TabIndex = 2;
            this.label_recap.Text = "Récapitulatif";
            // 
            // button_prec
            // 
            this.button_prec.Location = new System.Drawing.Point(330, 115);
            this.button_prec.Name = "button_prec";
            this.button_prec.Size = new System.Drawing.Size(49, 23);
            this.button_prec.TabIndex = 3;
            this.button_prec.Text = "<<";
            this.button_prec.UseVisualStyleBackColor = true;
            // 
            // button_suiv
            // 
            this.button_suiv.Location = new System.Drawing.Point(385, 115);
            this.button_suiv.Name = "button_suiv";
            this.button_suiv.Size = new System.Drawing.Size(49, 23);
            this.button_suiv.TabIndex = 3;
            this.button_suiv.Text = ">>";
            this.button_suiv.UseVisualStyleBackColor = true;
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(6, 290);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 4;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // Form_princ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 316);
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
        private System.Windows.Forms.TextBox textBox_mixte;
        private System.Windows.Forms.Label label_mixte;
        private System.Windows.Forms.TextBox textBox_recap;
        private System.Windows.Forms.Label label_recap;
        private System.Windows.Forms.Button button_prec;
        private System.Windows.Forms.Button button_suiv;
        private System.Windows.Forms.Button button_quit;
    }
}

