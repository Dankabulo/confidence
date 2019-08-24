namespace Confidence
{
    partial class new_remboursement_form
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_id_pret = new System.Windows.Forms.TextBox();
            this.dt_date_remboursement = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "Identifiant pret :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(138, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 2);
            this.panel3.TabIndex = 100;
            // 
            // txt_id_pret
            // 
            this.txt_id_pret.BackColor = System.Drawing.SystemColors.Control;
            this.txt_id_pret.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_pret.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_pret.Location = new System.Drawing.Point(138, 44);
            this.txt_id_pret.Name = "txt_id_pret";
            this.txt_id_pret.Size = new System.Drawing.Size(156, 16);
            this.txt_id_pret.TabIndex = 90;
            // 
            // dt_date_remboursement
            // 
            this.dt_date_remboursement.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dt_date_remboursement.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dt_date_remboursement.Location = new System.Drawing.Point(151, 155);
            this.dt_date_remboursement.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_remboursement.Name = "dt_date_remboursement";
            this.dt_date_remboursement.Size = new System.Drawing.Size(161, 29);
            this.dt_date_remboursement.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "Date creation :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel7.Location = new System.Drawing.Point(151, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 2);
            this.panel7.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 97;
            this.label6.Text = "Montant :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel6.Location = new System.Drawing.Point(151, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 2);
            this.panel6.TabIndex = 96;
            // 
            // txt_montant
            // 
            this.txt_montant.BackColor = System.Drawing.SystemColors.Control;
            this.txt_montant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_montant.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_montant.Location = new System.Drawing.Point(151, 121);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(156, 16);
            this.txt_montant.TabIndex = 93;
            this.txt_montant.TextChanged += new System.EventHandler(this.txtsolde_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_date_remboursement);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txt_montant);
            this.groupBox1.Controls.Add(this.txt_id_pret);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 358);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations de remboursement";
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(265, 385);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(121, 43);
            this.materialRaisedButton8.TabIndex = 103;
            this.materialRaisedButton8.Text = "valider";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // new_remboursement_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 440);
            this.Controls.Add(this.materialRaisedButton8);
            this.Controls.Add(this.groupBox1);
            this.Name = "new_remboursement_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REMBOURSEMENT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_id_pret;
        private MetroFramework.Controls.MetroDateTime dt_date_remboursement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
    }
}