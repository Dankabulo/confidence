﻿namespace Confidence
{
    partial class clients_options
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients_options));
            this.main3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnom_rapport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_progression = new System.Windows.Forms.Panel();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblprogresseBar = new System.Windows.Forms.Label();
            this.btn_rapport = new Bunifu.Framework.UI.BunifuImageButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel_tools = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtfin = new MetroFramework.Controls.MetroDateTime();
            this.dtdebut = new MetroFramework.Controls.MetroDateTime();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcategorie = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtype = new MetroFramework.Controls.MetroComboBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.main3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_progression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // main3
            // 
            this.main3.Controls.Add(this.groupBox1);
            this.main3.Controls.Add(this.panel_progression);
            this.main3.Controls.Add(this.btn_rapport);
            this.main3.Controls.Add(this.dataGridView2);
            this.main3.Controls.Add(this.panel_tools);
            this.main3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main3.Location = new System.Drawing.Point(0, 0);
            this.main3.Name = "main3";
            this.main3.Size = new System.Drawing.Size(1278, 792);
            this.main3.TabIndex = 7;
            this.main3.Paint += new System.Windows.Forms.PaintEventHandler(this.main3_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnom_rapport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox1.Location = new System.Drawing.Point(123, 640);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 99);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notation rapport";
            this.groupBox1.Visible = false;
            // 
            // txtnom_rapport
            // 
            this.txtnom_rapport.Location = new System.Drawing.Point(128, 50);
            this.txtnom_rapport.Name = "txtnom_rapport";
            this.txtnom_rapport.Size = new System.Drawing.Size(174, 22);
            this.txtnom_rapport.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom rapport :";
            // 
            // panel_progression
            // 
            this.panel_progression.Controls.Add(this.metroProgressBar);
            this.panel_progression.Controls.Add(this.lblprogresseBar);
            this.panel_progression.Location = new System.Drawing.Point(508, 673);
            this.panel_progression.Name = "panel_progression";
            this.panel_progression.Size = new System.Drawing.Size(420, 66);
            this.panel_progression.TabIndex = 25;
            this.panel_progression.Visible = false;
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Location = new System.Drawing.Point(51, 32);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(317, 23);
            this.metroProgressBar.TabIndex = 9;
            // 
            // lblprogresseBar
            // 
            this.lblprogresseBar.AutoSize = true;
            this.lblprogresseBar.BackColor = System.Drawing.SystemColors.Control;
            this.lblprogresseBar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogresseBar.Location = new System.Drawing.Point(151, 12);
            this.lblprogresseBar.Name = "lblprogresseBar";
            this.lblprogresseBar.Size = new System.Drawing.Size(110, 17);
            this.lblprogresseBar.TabIndex = 10;
            this.lblprogresseBar.Text = "chargement 0%...";
            // 
            // btn_rapport
            // 
            this.btn_rapport.BackColor = System.Drawing.SystemColors.Control;
            this.btn_rapport.Image = ((System.Drawing.Image)(resources.GetObject("btn_rapport.Image")));
            this.btn_rapport.ImageActive = null;
            this.btn_rapport.Location = new System.Drawing.Point(1019, 635);
            this.btn_rapport.Name = "btn_rapport";
            this.btn_rapport.Size = new System.Drawing.Size(71, 71);
            this.btn_rapport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_rapport.TabIndex = 9;
            this.btn_rapport.TabStop = false;
            this.btn_rapport.Zoom = 10;
            this.btn_rapport.Click += new System.EventHandler(this.btn_rapport_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(211, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(879, 432);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // panel_tools
            // 
            this.panel_tools.BackColor = System.Drawing.Color.White;
            this.panel_tools.Controls.Add(this.bunifuFlatButton2);
            this.panel_tools.Controls.Add(this.label6);
            this.panel_tools.Controls.Add(this.label5);
            this.panel_tools.Controls.Add(this.dtfin);
            this.panel_tools.Controls.Add(this.dtdebut);
            this.panel_tools.Controls.Add(this.label4);
            this.panel_tools.Controls.Add(this.cmbcategorie);
            this.panel_tools.Controls.Add(this.label3);
            this.panel_tools.Controls.Add(this.cmbtype);
            this.panel_tools.Location = new System.Drawing.Point(69, 36);
            this.panel_tools.Name = "panel_tools";
            this.panel_tools.Size = new System.Drawing.Size(1174, 100);
            this.panel_tools.TabIndex = 7;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(152)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(75)))), ((int)(((byte)(113)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "        Rechercher";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(857, 34);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(75)))), ((int)(((byte)(113)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(89)))), ((int)(((byte)(135)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(118, 35);
            this.bunifuFlatButton2.TabIndex = 52;
            this.bunifuFlatButton2.Text = "        Rechercher";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "au :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "du :";
            // 
            // dtfin
            // 
            this.dtfin.Location = new System.Drawing.Point(596, 54);
            this.dtfin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(200, 29);
            this.dtfin.TabIndex = 5;
            // 
            // dtdebut
            // 
            this.dtdebut.Location = new System.Drawing.Point(596, 19);
            this.dtdebut.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtdebut.Name = "dtdebut";
            this.dtdebut.Size = new System.Drawing.Size(200, 29);
            this.dtdebut.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "categorie :";
            // 
            // cmbcategorie
            // 
            this.cmbcategorie.FormattingEnabled = true;
            this.cmbcategorie.ItemHeight = 23;
            this.cmbcategorie.Items.AddRange(new object[] {
            "Operation d\'entrees",
            "Operation de sorties",
            "Comptes courants",
            "Comptes  a termes"});
            this.cmbcategorie.Location = new System.Drawing.Point(336, 30);
            this.cmbcategorie.Name = "cmbcategorie";
            this.cmbcategorie.Size = new System.Drawing.Size(167, 29);
            this.cmbcategorie.TabIndex = 2;
            this.cmbcategorie.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "type :";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.ItemHeight = 23;
            this.cmbtype.Items.AddRange(new object[] {
            "operations",
            "comptes"});
            this.cmbtype.Location = new System.Drawing.Point(115, 34);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(125, 29);
            this.cmbtype.TabIndex = 0;
            this.cmbtype.UseSelectable = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // clients_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main3);
            this.Name = "clients_options";
            this.Size = new System.Drawing.Size(1278, 792);
            this.main3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_progression.ResumeLayout(false);
            this.panel_progression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel_tools.ResumeLayout(false);
            this.panel_tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel main3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel_tools;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroDateTime dtfin;
        private MetroFramework.Controls.MetroDateTime dtdebut;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox cmbcategorie;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cmbtype;
        private System.Windows.Forms.Panel panel_progression;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.Label lblprogresseBar;
        private Bunifu.Framework.UI.BunifuImageButton btn_rapport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txtnom_rapport;
    }
}