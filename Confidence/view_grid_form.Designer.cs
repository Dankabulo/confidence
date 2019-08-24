namespace Confidence
{
    partial class view_grid_form
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
            this.txt_requete = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_view_result = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_message = new System.Windows.Forms.Label();
            this.panel_view_result.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_requete
            // 
            this.txt_requete.Location = new System.Drawing.Point(12, 441);
            this.txt_requete.Name = "txt_requete";
            this.txt_requete.Size = new System.Drawing.Size(79, 20);
            this.txt_requete.TabIndex = 1;
            this.txt_requete.Visible = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(308, 212);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(142, 55);
            this.materialRaisedButton1.TabIndex = 81;
            this.materialRaisedButton1.Text = "actualiser";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // panel_view_result
            // 
            this.panel_view_result.Controls.Add(this.groupBox1);
            this.panel_view_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_view_result.Location = new System.Drawing.Point(0, 0);
            this.panel_view_result.Name = "panel_view_result";
            this.panel_view_result.Size = new System.Drawing.Size(804, 497);
            this.panel_view_result.TabIndex = 82;
            this.panel_view_result.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_message);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultats de la recherche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(22, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError_1);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(19, 30);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(47, 17);
            this.lbl_message.TabIndex = 1;
            this.lbl_message.Text = "label1";
            // 
            // view_grid_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.panel_view_result);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txt_requete);
            this.Name = "view_grid_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESULTATS";
            this.panel_view_result.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_requete;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panel_view_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_message;
    }
}