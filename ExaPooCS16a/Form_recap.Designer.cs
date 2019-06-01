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
            this.groupBox_cordes = new System.Windows.Forms.GroupBox();
            this.dataGridView_cordes = new System.Windows.Forms.DataGridView();
            this.Id_instr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbcordes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_air = new System.Windows.Forms.GroupBox();
            this.dataGridView_air = new System.Windows.Forms.DataGridView();
            this.textBox_idscom = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.Identifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbtouches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soufflet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox_cordes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cordes)).BeginInit();
            this.groupBox_air.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_air)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_cordes
            // 
            this.groupBox_cordes.Controls.Add(this.dataGridView_cordes);
            this.groupBox_cordes.Location = new System.Drawing.Point(12, 55);
            this.groupBox_cordes.Name = "groupBox_cordes";
            this.groupBox_cordes.Size = new System.Drawing.Size(364, 192);
            this.groupBox_cordes.TabIndex = 0;
            this.groupBox_cordes.TabStop = false;
            this.groupBox_cordes.Text = "Instruments à cordes";
            // 
            // dataGridView_cordes
            // 
            this.dataGridView_cordes.AllowUserToAddRows = false;
            this.dataGridView_cordes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cordes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_instr,
            this.Prix,
            this.nbcordes});
            this.dataGridView_cordes.Location = new System.Drawing.Point(27, 19);
            this.dataGridView_cordes.Name = "dataGridView_cordes";
            this.dataGridView_cordes.Size = new System.Drawing.Size(308, 167);
            this.dataGridView_cordes.TabIndex = 1;
            // 
            // Id_instr
            // 
            this.Id_instr.HeaderText = "Identifiant";
            this.Id_instr.Name = "Id_instr";
            this.Id_instr.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            this.Prix.Width = 50;
            // 
            // nbcordes
            // 
            this.nbcordes.HeaderText = "Nb Cordes";
            this.nbcordes.Name = "nbcordes";
            this.nbcordes.ReadOnly = true;
            this.nbcordes.Width = 80;
            // 
            // groupBox_air
            // 
            this.groupBox_air.Controls.Add(this.dataGridView_air);
            this.groupBox_air.Location = new System.Drawing.Point(12, 253);
            this.groupBox_air.Name = "groupBox_air";
            this.groupBox_air.Size = new System.Drawing.Size(370, 252);
            this.groupBox_air.TabIndex = 0;
            this.groupBox_air.TabStop = false;
            this.groupBox_air.Text = "Instruments à air";
            // 
            // dataGridView_air
            // 
            this.dataGridView_air.AllowUserToAddRows = false;
            this.dataGridView_air.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_air.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identifiant,
            this.dataGridViewTextBoxColumn1,
            this.nbtouches,
            this.Soufflet});
            this.dataGridView_air.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_air.Name = "dataGridView_air";
            this.dataGridView_air.Size = new System.Drawing.Size(358, 217);
            this.dataGridView_air.TabIndex = 1;
            // 
            // textBox_idscom
            // 
            this.textBox_idscom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox_idscom.Location = new System.Drawing.Point(39, 13);
            this.textBox_idscom.Name = "textBox_idscom";
            this.textBox_idscom.ReadOnly = true;
            this.textBox_idscom.Size = new System.Drawing.Size(221, 20);
            this.textBox_idscom.TabIndex = 1;
            // 
            // button_close
            // 
            this.button_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_close.Location = new System.Drawing.Point(301, 10);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Fermer";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // Identifiant
            // 
            this.Identifiant.HeaderText = "Identifiant";
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // nbtouches
            // 
            this.nbtouches.HeaderText = "Nb Touches";
            this.nbtouches.Name = "nbtouches";
            this.nbtouches.ReadOnly = true;
            this.nbtouches.Width = 80;
            // 
            // Soufflet
            // 
            this.Soufflet.HeaderText = "Soufflet";
            this.Soufflet.Name = "Soufflet";
            this.Soufflet.ReadOnly = true;
            this.Soufflet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Soufflet.Width = 80;
            // 
            // Form_recap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 548);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_idscom);
            this.Controls.Add(this.groupBox_air);
            this.Controls.Add(this.groupBox_cordes);
            this.Name = "Form_recap";
            this.Text = "Music Store - Stock";
            this.groupBox_cordes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cordes)).EndInit();
            this.groupBox_air.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_air)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_cordes;
        private System.Windows.Forms.DataGridView dataGridView_cordes;
        private System.Windows.Forms.GroupBox groupBox_air;
        private System.Windows.Forms.DataGridView dataGridView_air;
        private System.Windows.Forms.TextBox textBox_idscom;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_instr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbcordes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbtouches;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Soufflet;
    }
}