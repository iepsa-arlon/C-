namespace ExaCs13a
{
    partial class Form1
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
            this.groupBox_typlog = new System.Windows.Forms.GroupBox();
            this.radioButton_loc = new System.Windows.Forms.RadioButton();
            this.radioButton_com = new System.Windows.Forms.RadioButton();
            this.groupBox_caract = new System.Windows.Forms.GroupBox();
            this.button_valoy = new System.Windows.Forms.Button();
            this.checkBox_paye = new System.Windows.Forms.CheckBox();
            this.textBox_polym = new System.Windows.Forms.TextBox();
            this.textBox_surf = new System.Windows.Forms.TextBox();
            this.textBox_nbpieces = new System.Windows.Forms.TextBox();
            this.label_polym = new System.Windows.Forms.Label();
            this.label_surf = new System.Windows.Forms.Label();
            this.label_nbpieces = new System.Windows.Forms.Label();
            this.button_valog = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.dataGridView_com = new System.Windows.Forms.DataGridView();
            this.dataGridView_loc = new System.Windows.Forms.DataGridView();
            this.label_com = new System.Windows.Forms.Label();
            this.label_loy = new System.Windows.Forms.Label();
            this.groupBox_typlog.SuspendLayout();
            this.groupBox_caract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_com)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_typlog
            // 
            this.groupBox_typlog.Controls.Add(this.radioButton_loc);
            this.groupBox_typlog.Controls.Add(this.radioButton_com);
            this.groupBox_typlog.Location = new System.Drawing.Point(12, 21);
            this.groupBox_typlog.Name = "groupBox_typlog";
            this.groupBox_typlog.Size = new System.Drawing.Size(214, 71);
            this.groupBox_typlog.TabIndex = 0;
            this.groupBox_typlog.TabStop = false;
            this.groupBox_typlog.Text = "Type de logement";
            // 
            // radioButton_loc
            // 
            this.radioButton_loc.AutoSize = true;
            this.radioButton_loc.Location = new System.Drawing.Point(123, 34);
            this.radioButton_loc.Name = "radioButton_loc";
            this.radioButton_loc.Size = new System.Drawing.Size(66, 17);
            this.radioButton_loc.TabIndex = 0;
            this.radioButton_loc.TabStop = true;
            this.radioButton_loc.Text = "Location";
            this.radioButton_loc.UseVisualStyleBackColor = true;
            // 
            // radioButton_com
            // 
            this.radioButton_com.AutoSize = true;
            this.radioButton_com.Location = new System.Drawing.Point(16, 34);
            this.radioButton_com.Name = "radioButton_com";
            this.radioButton_com.Size = new System.Drawing.Size(71, 17);
            this.radioButton_com.TabIndex = 0;
            this.radioButton_com.TabStop = true;
            this.radioButton_com.Text = "Communs";
            this.radioButton_com.UseVisualStyleBackColor = true;
            // 
            // groupBox_caract
            // 
            this.groupBox_caract.Controls.Add(this.button_valoy);
            this.groupBox_caract.Controls.Add(this.checkBox_paye);
            this.groupBox_caract.Controls.Add(this.textBox_polym);
            this.groupBox_caract.Controls.Add(this.textBox_surf);
            this.groupBox_caract.Controls.Add(this.textBox_nbpieces);
            this.groupBox_caract.Controls.Add(this.label_polym);
            this.groupBox_caract.Controls.Add(this.label_surf);
            this.groupBox_caract.Controls.Add(this.label_nbpieces);
            this.groupBox_caract.Location = new System.Drawing.Point(16, 109);
            this.groupBox_caract.Name = "groupBox_caract";
            this.groupBox_caract.Size = new System.Drawing.Size(210, 193);
            this.groupBox_caract.TabIndex = 1;
            this.groupBox_caract.TabStop = false;
            this.groupBox_caract.Text = "Caractéristiques";
            // 
            // button_valoy
            // 
            this.button_valoy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_valoy.Location = new System.Drawing.Point(91, 148);
            this.button_valoy.Name = "button_valoy";
            this.button_valoy.Size = new System.Drawing.Size(113, 23);
            this.button_valoy.TabIndex = 3;
            this.button_valoy.Text = "Valider Loyer";
            this.button_valoy.UseVisualStyleBackColor = true;
            // 
            // checkBox_paye
            // 
            this.checkBox_paye.AutoSize = true;
            this.checkBox_paye.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_paye.Checked = true;
            this.checkBox_paye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_paye.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBox_paye.Location = new System.Drawing.Point(19, 152);
            this.checkBox_paye.Name = "checkBox_paye";
            this.checkBox_paye.Size = new System.Drawing.Size(50, 17);
            this.checkBox_paye.TabIndex = 2;
            this.checkBox_paye.Text = "Payé";
            this.checkBox_paye.UseVisualStyleBackColor = true;
            // 
            // textBox_polym
            // 
            this.textBox_polym.Location = new System.Drawing.Point(91, 117);
            this.textBox_polym.Name = "textBox_polym";
            this.textBox_polym.Size = new System.Drawing.Size(113, 20);
            this.textBox_polym.TabIndex = 1;
            // 
            // textBox_surf
            // 
            this.textBox_surf.Location = new System.Drawing.Point(115, 65);
            this.textBox_surf.Name = "textBox_surf";
            this.textBox_surf.Size = new System.Drawing.Size(52, 20);
            this.textBox_surf.TabIndex = 1;
            // 
            // textBox_nbpieces
            // 
            this.textBox_nbpieces.Location = new System.Drawing.Point(115, 40);
            this.textBox_nbpieces.Name = "textBox_nbpieces";
            this.textBox_nbpieces.Size = new System.Drawing.Size(52, 20);
            this.textBox_nbpieces.TabIndex = 1;
            // 
            // label_polym
            // 
            this.label_polym.AutoSize = true;
            this.label_polym.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_polym.Location = new System.Drawing.Point(16, 120);
            this.label_polym.Name = "label_polym";
            this.label_polym.Size = new System.Drawing.Size(69, 13);
            this.label_polym.TabIndex = 0;
            this.label_polym.Text = "IdSoc / Date";
            // 
            // label_surf
            // 
            this.label_surf.AutoSize = true;
            this.label_surf.Location = new System.Drawing.Point(16, 68);
            this.label_surf.Name = "label_surf";
            this.label_surf.Size = new System.Drawing.Size(44, 13);
            this.label_surf.TabIndex = 0;
            this.label_surf.Text = "Surface";
            // 
            // label_nbpieces
            // 
            this.label_nbpieces.AutoSize = true;
            this.label_nbpieces.Location = new System.Drawing.Point(16, 43);
            this.label_nbpieces.Name = "label_nbpieces";
            this.label_nbpieces.Size = new System.Drawing.Size(93, 13);
            this.label_nbpieces.TabIndex = 0;
            this.label_nbpieces.Text = "Nombre de pièces";
            // 
            // button_valog
            // 
            this.button_valog.Location = new System.Drawing.Point(16, 335);
            this.button_valog.Name = "button_valog";
            this.button_valog.Size = new System.Drawing.Size(109, 23);
            this.button_valog.TabIndex = 2;
            this.button_valog.Text = "Valider Logement";
            this.button_valog.UseVisualStyleBackColor = true;
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(145, 335);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // dataGridView_com
            // 
            this.dataGridView_com.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_com.Location = new System.Drawing.Point(254, 44);
            this.dataGridView_com.Name = "dataGridView_com";
            this.dataGridView_com.Size = new System.Drawing.Size(334, 150);
            this.dataGridView_com.TabIndex = 4;
            // 
            // dataGridView_loc
            // 
            this.dataGridView_loc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_loc.Location = new System.Drawing.Point(254, 242);
            this.dataGridView_loc.Name = "dataGridView_loc";
            this.dataGridView_loc.Size = new System.Drawing.Size(334, 150);
            this.dataGridView_loc.TabIndex = 4;
            // 
            // label_com
            // 
            this.label_com.AutoSize = true;
            this.label_com.Location = new System.Drawing.Point(251, 21);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(149, 13);
            this.label_com.TabIndex = 5;
            this.label_com.Text = "RECAPITULATIF COMMUNS";
            // 
            // label_loy
            // 
            this.label_loy.AutoSize = true;
            this.label_loy.Location = new System.Drawing.Point(251, 216);
            this.label_loy.Name = "label_loy";
            this.label_loy.Size = new System.Drawing.Size(136, 13);
            this.label_loy.TabIndex = 5;
            this.label_loy.Text = "RECAPITULATIF LOYERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 404);
            this.Controls.Add(this.label_loy);
            this.Controls.Add(this.label_com);
            this.Controls.Add(this.dataGridView_loc);
            this.Controls.Add(this.dataGridView_com);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_valog);
            this.Controls.Add(this.groupBox_caract);
            this.Controls.Add(this.groupBox_typlog);
            this.Name = "Form1";
            this.Text = "Gestion Immobilière";
            this.groupBox_typlog.ResumeLayout(false);
            this.groupBox_typlog.PerformLayout();
            this.groupBox_caract.ResumeLayout(false);
            this.groupBox_caract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_com)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_loc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_typlog;
        private System.Windows.Forms.RadioButton radioButton_loc;
        private System.Windows.Forms.RadioButton radioButton_com;
        private System.Windows.Forms.GroupBox groupBox_caract;
        private System.Windows.Forms.Button button_valoy;
        private System.Windows.Forms.CheckBox checkBox_paye;
        private System.Windows.Forms.TextBox textBox_polym;
        private System.Windows.Forms.TextBox textBox_surf;
        private System.Windows.Forms.TextBox textBox_nbpieces;
        private System.Windows.Forms.Label label_polym;
        private System.Windows.Forms.Label label_surf;
        private System.Windows.Forms.Label label_nbpieces;
        private System.Windows.Forms.Button button_valog;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.DataGridView dataGridView_com;
        private System.Windows.Forms.DataGridView dataGridView_loc;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Label label_loy;
    }
}

