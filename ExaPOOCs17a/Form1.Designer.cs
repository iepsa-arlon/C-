namespace ExaPOOCs17a
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
            this.groupBox_intro = new System.Windows.Forms.GroupBox();
            this.button_val = new System.Windows.Forms.Button();
            this.textBox_dim3 = new System.Windows.Forms.TextBox();
            this.textBox_dim2 = new System.Windows.Forms.TextBox();
            this.textBox_dim1 = new System.Windows.Forms.TextBox();
            this.label_dim3 = new System.Windows.Forms.Label();
            this.label_dim2 = new System.Windows.Forms.Label();
            this.label_dim1 = new System.Windows.Forms.Label();
            this.label_carb = new System.Windows.Forms.Label();
            this.comboBox_typcarb = new System.Windows.Forms.ComboBox();
            this.comboBox_typcit = new System.Windows.Forms.ComboBox();
            this.label_typcit = new System.Windows.Forms.Label();
            this.button_ValTypCit = new System.Windows.Forms.Button();
            this.button_quit = new System.Windows.Forms.Button();
            this.dataGridView_recap = new System.Windows.Forms.DataGridView();
            this.typcit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typcarb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dim1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dim2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dim3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_intro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_intro
            // 
            this.groupBox_intro.Controls.Add(this.button_val);
            this.groupBox_intro.Controls.Add(this.textBox_dim3);
            this.groupBox_intro.Controls.Add(this.textBox_dim2);
            this.groupBox_intro.Controls.Add(this.textBox_dim1);
            this.groupBox_intro.Controls.Add(this.label_dim3);
            this.groupBox_intro.Controls.Add(this.label_dim2);
            this.groupBox_intro.Controls.Add(this.label_dim1);
            this.groupBox_intro.Controls.Add(this.label_carb);
            this.groupBox_intro.Controls.Add(this.comboBox_typcarb);
            this.groupBox_intro.Location = new System.Drawing.Point(252, 9);
            this.groupBox_intro.Name = "groupBox_intro";
            this.groupBox_intro.Size = new System.Drawing.Size(315, 141);
            this.groupBox_intro.TabIndex = 0;
            this.groupBox_intro.TabStop = false;
            this.groupBox_intro.Text = "Nouvelle citerne";
            // 
            // button_val
            // 
            this.button_val.Location = new System.Drawing.Point(234, 107);
            this.button_val.Name = "button_val";
            this.button_val.Size = new System.Drawing.Size(75, 23);
            this.button_val.TabIndex = 3;
            this.button_val.Text = "Valider";
            this.button_val.UseVisualStyleBackColor = true;
            // 
            // textBox_dim3
            // 
            this.textBox_dim3.Location = new System.Drawing.Point(103, 109);
            this.textBox_dim3.Name = "textBox_dim3";
            this.textBox_dim3.Size = new System.Drawing.Size(100, 20);
            this.textBox_dim3.TabIndex = 3;
            // 
            // textBox_dim2
            // 
            this.textBox_dim2.Location = new System.Drawing.Point(103, 80);
            this.textBox_dim2.Name = "textBox_dim2";
            this.textBox_dim2.Size = new System.Drawing.Size(100, 20);
            this.textBox_dim2.TabIndex = 3;
            // 
            // textBox_dim1
            // 
            this.textBox_dim1.Location = new System.Drawing.Point(103, 52);
            this.textBox_dim1.Name = "textBox_dim1";
            this.textBox_dim1.Size = new System.Drawing.Size(100, 20);
            this.textBox_dim1.TabIndex = 3;
            // 
            // label_dim3
            // 
            this.label_dim3.AutoSize = true;
            this.label_dim3.Location = new System.Drawing.Point(6, 112);
            this.label_dim3.Name = "label_dim3";
            this.label_dim3.Size = new System.Drawing.Size(31, 13);
            this.label_dim3.TabIndex = 3;
            this.label_dim3.Text = "Dim3";
            // 
            // label_dim2
            // 
            this.label_dim2.AutoSize = true;
            this.label_dim2.Location = new System.Drawing.Point(6, 83);
            this.label_dim2.Name = "label_dim2";
            this.label_dim2.Size = new System.Drawing.Size(31, 13);
            this.label_dim2.TabIndex = 3;
            this.label_dim2.Text = "Dim2";
            // 
            // label_dim1
            // 
            this.label_dim1.AutoSize = true;
            this.label_dim1.Location = new System.Drawing.Point(6, 55);
            this.label_dim1.Name = "label_dim1";
            this.label_dim1.Size = new System.Drawing.Size(31, 13);
            this.label_dim1.TabIndex = 3;
            this.label_dim1.Text = "Dim1";
            // 
            // label_carb
            // 
            this.label_carb.AutoSize = true;
            this.label_carb.Location = new System.Drawing.Point(6, 28);
            this.label_carb.Name = "label_carb";
            this.label_carb.Size = new System.Drawing.Size(94, 13);
            this.label_carb.TabIndex = 1;
            this.label_carb.Text = "Type de carburant";
            // 
            // comboBox_typcarb
            // 
            this.comboBox_typcarb.FormattingEnabled = true;
            this.comboBox_typcarb.Location = new System.Drawing.Point(103, 25);
            this.comboBox_typcarb.Name = "comboBox_typcarb";
            this.comboBox_typcarb.Size = new System.Drawing.Size(121, 21);
            this.comboBox_typcarb.TabIndex = 1;
            // 
            // comboBox_typcit
            // 
            this.comboBox_typcit.FormattingEnabled = true;
            this.comboBox_typcit.Location = new System.Drawing.Point(99, 16);
            this.comboBox_typcit.Name = "comboBox_typcit";
            this.comboBox_typcit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_typcit.TabIndex = 1;
            // 
            // label_typcit
            // 
            this.label_typcit.AutoSize = true;
            this.label_typcit.Location = new System.Drawing.Point(12, 19);
            this.label_typcit.Name = "label_typcit";
            this.label_typcit.Size = new System.Drawing.Size(81, 13);
            this.label_typcit.TabIndex = 1;
            this.label_typcit.Text = "Type de citerne";
            // 
            // button_ValTypCit
            // 
            this.button_ValTypCit.Location = new System.Drawing.Point(145, 54);
            this.button_ValTypCit.Name = "button_ValTypCit";
            this.button_ValTypCit.Size = new System.Drawing.Size(75, 23);
            this.button_ValTypCit.TabIndex = 2;
            this.button_ValTypCit.Text = "Créer";
            this.button_ValTypCit.UseVisualStyleBackColor = true;
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(15, 54);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(75, 23);
            this.button_quit.TabIndex = 3;
            this.button_quit.Text = "Quitter";
            this.button_quit.UseVisualStyleBackColor = true;
            // 
            // dataGridView_recap
            // 
            this.dataGridView_recap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typcit,
            this.vol,
            this.typcarb,
            this.dim1,
            this.dim2,
            this.dim3});
            this.dataGridView_recap.Location = new System.Drawing.Point(12, 159);
            this.dataGridView_recap.Name = "dataGridView_recap";
            this.dataGridView_recap.Size = new System.Drawing.Size(642, 248);
            this.dataGridView_recap.TabIndex = 4;
            // 
            // typcit
            // 
            this.typcit.HeaderText = "Typcit";
            this.typcit.Name = "typcit";
            this.typcit.ReadOnly = true;
            // 
            // vol
            // 
            this.vol.HeaderText = "Volume";
            this.vol.Name = "vol";
            this.vol.ReadOnly = true;
            // 
            // typcarb
            // 
            this.typcarb.HeaderText = "TypCarb";
            this.typcarb.Name = "typcarb";
            this.typcarb.ReadOnly = true;
            // 
            // dim1
            // 
            this.dim1.HeaderText = "C/L";
            this.dim1.Name = "dim1";
            this.dim1.ReadOnly = true;
            // 
            // dim2
            // 
            this.dim2.HeaderText = "D/H";
            this.dim2.Name = "dim2";
            this.dim2.ReadOnly = true;
            // 
            // dim3
            // 
            this.dim3.HeaderText = "l";
            this.dim3.Name = "dim3";
            this.dim3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 438);
            this.Controls.Add(this.dataGridView_recap);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.button_ValTypCit);
            this.Controls.Add(this.groupBox_intro);
            this.Controls.Add(this.label_typcit);
            this.Controls.Add(this.comboBox_typcit);
            this.Name = "Form1";
            this.Text = "Gestion citernes";
            this.groupBox_intro.ResumeLayout(false);
            this.groupBox_intro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_intro;
        private System.Windows.Forms.Button button_val;
        private System.Windows.Forms.TextBox textBox_dim3;
        private System.Windows.Forms.TextBox textBox_dim2;
        private System.Windows.Forms.TextBox textBox_dim1;
        private System.Windows.Forms.Label label_dim3;
        private System.Windows.Forms.Label label_dim2;
        private System.Windows.Forms.Label label_dim1;
        private System.Windows.Forms.Label label_carb;
        private System.Windows.Forms.ComboBox comboBox_typcarb;
        private System.Windows.Forms.ComboBox comboBox_typcit;
        private System.Windows.Forms.Label label_typcit;
        private System.Windows.Forms.Button button_ValTypCit;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.DataGridView dataGridView_recap;
        private System.Windows.Forms.DataGridViewTextBoxColumn typcit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typcarb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dim1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dim2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dim3;
    }
}

