namespace ExaPooCS16a
{
    partial class Form_recap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_idcoop_nbouv = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.dataGridView_recap = new System.Windows.Forms.DataGridView();
            this.TypeMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fcout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbEss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freins = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_idcoop_nbouv
            // 
            this.textBox_idcoop_nbouv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox_idcoop_nbouv.Location = new System.Drawing.Point(39, 13);
            this.textBox_idcoop_nbouv.Name = "textBox_idcoop_nbouv";
            this.textBox_idcoop_nbouv.ReadOnly = true;
            this.textBox_idcoop_nbouv.Size = new System.Drawing.Size(221, 20);
            this.textBox_idcoop_nbouv.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_close.Location = new System.Drawing.Point(526, 11);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Fermer";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // dataGridView_recap
            // 
            this.dataGridView_recap.AllowUserToAddRows = false;
            this.dataGridView_recap.AllowUserToDeleteRows = false;
            this.dataGridView_recap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeMat,
            this.Fcout,
            this.pmax,
            this.Puis,
            this.NbEss,
            this.Freins});
            this.dataGridView_recap.Location = new System.Drawing.Point(39, 39);
            this.dataGridView_recap.Name = "dataGridView_recap";
            this.dataGridView_recap.ReadOnly = true;
            this.dataGridView_recap.Size = new System.Drawing.Size(562, 211);
            this.dataGridView_recap.TabIndex = 3;
            // 
            // TypeMat
            // 
            this.TypeMat.Frozen = true;
            this.TypeMat.HeaderText = "Type";
            this.TypeMat.Name = "TypeMat";
            this.TypeMat.ReadOnly = true;
            this.TypeMat.Width = 50;
            // 
            // Fcout
            // 
            this.Fcout.Frozen = true;
            this.Fcout.HeaderText = "Fact Cout";
            this.Fcout.Name = "Fcout";
            this.Fcout.ReadOnly = true;
            this.Fcout.Width = 85;
            // 
            // pmax
            // 
            this.pmax.Frozen = true;
            this.pmax.HeaderText = "Poids Max";
            this.pmax.Name = "pmax";
            this.pmax.ReadOnly = true;
            this.pmax.Width = 85;
            // 
            // Puis
            // 
            this.Puis.Frozen = true;
            this.Puis.HeaderText = "Puissance";
            this.Puis.Name = "Puis";
            this.Puis.ReadOnly = true;
            // 
            // NbEss
            // 
            this.NbEss.Frozen = true;
            this.NbEss.HeaderText = "Nb Essieux";
            this.NbEss.Name = "NbEss";
            this.NbEss.ReadOnly = true;
            // 
            // Freins
            // 
            this.Freins.Frozen = true;
            this.Freins.HeaderText = "Freins";
            this.Freins.Name = "Freins";
            this.Freins.ReadOnly = true;
            // 
            // Form_recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 262);
            this.Controls.Add(this.dataGridView_recap);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_idcoop_nbouv);
            this.Name = "Form_recap";
            this.Text = "Coopérative - Matériel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_idcoop_nbouv;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridView dataGridView_recap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fcout;
        private System.Windows.Forms.DataGridViewTextBoxColumn pmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbEss;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Freins;
    }
}