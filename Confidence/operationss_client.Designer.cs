﻿namespace Confidence
{
    partial class operationss_client
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prenom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_postnom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_compte_a_terme = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_compte_courant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_message_compte = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_generer_rapport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_nouvelle_operation = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtdate_creation = new MetroFramework.Controls.MetroDateTime();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtsolde = new System.Windows.Forms.TextBox();
            this.cmboperation = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtcompte = new System.Windows.Forms.TextBox();
            this.materialRaisedButton11 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_progression = new System.Windows.Forms.Panel();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblprogresseBar = new System.Windows.Forms.Label();
            this.txtnom_rapport = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_requete = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel_nouvelle_operation.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel_progression.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(369, 177);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton1.TabIndex = 64;
            this.materialRaisedButton1.Text = "verifier";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_prenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_postnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(68, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 171);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations sur le client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prenom :";
            // 
            // txt_prenom
            // 
            this.txt_prenom.Depth = 0;
            this.txt_prenom.Hint = "";
            this.txt_prenom.Location = new System.Drawing.Point(96, 113);
            this.txt_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.PasswordChar = '\0';
            this.txt_prenom.SelectedText = "";
            this.txt_prenom.SelectionLength = 0;
            this.txt_prenom.SelectionStart = 0;
            this.txt_prenom.Size = new System.Drawing.Size(176, 23);
            this.txt_prenom.TabIndex = 4;
            this.txt_prenom.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Postnom :";
            // 
            // txt_postnom
            // 
            this.txt_postnom.Depth = 0;
            this.txt_postnom.Hint = "";
            this.txt_postnom.Location = new System.Drawing.Point(96, 74);
            this.txt_postnom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_postnom.Name = "txt_postnom";
            this.txt_postnom.PasswordChar = '\0';
            this.txt_postnom.SelectedText = "";
            this.txt_postnom.SelectionLength = 0;
            this.txt_postnom.SelectionStart = 0;
            this.txt_postnom.Size = new System.Drawing.Size(176, 23);
            this.txt_postnom.TabIndex = 2;
            this.txt_postnom.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // txt_nom
            // 
            this.txt_nom.Depth = 0;
            this.txt_nom.Hint = "";
            this.txt_nom.Location = new System.Drawing.Point(96, 37);
            this.txt_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.PasswordChar = '\0';
            this.txt_nom.SelectedText = "";
            this.txt_nom.SelectionLength = 0;
            this.txt_nom.SelectionStart = 0;
            this.txt_nom.Size = new System.Drawing.Size(176, 23);
            this.txt_nom.TabIndex = 0;
            this.txt_nom.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialRaisedButton8);
            this.groupBox2.Controls.Add(this.lbl_message_compte);
            this.groupBox2.Controls.Add(this.materialRaisedButton7);
            this.groupBox2.Controls.Add(this.materialRaisedButton3);
            this.groupBox2.Controls.Add(this.materialRaisedButton2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_compte_courant);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_compte_a_terme);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(68, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 217);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comptes existants";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Comptes a termes :";
            // 
            // txt_compte_a_terme
            // 
            this.txt_compte_a_terme.Depth = 0;
            this.txt_compte_a_terme.Hint = "";
            this.txt_compte_a_terme.Location = new System.Drawing.Point(159, 54);
            this.txt_compte_a_terme.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_compte_a_terme.Name = "txt_compte_a_terme";
            this.txt_compte_a_terme.PasswordChar = '\0';
            this.txt_compte_a_terme.SelectedText = "";
            this.txt_compte_a_terme.SelectionLength = 0;
            this.txt_compte_a_terme.SelectionStart = 0;
            this.txt_compte_a_terme.Size = new System.Drawing.Size(122, 23);
            this.txt_compte_a_terme.TabIndex = 6;
            this.txt_compte_a_terme.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comptes courant :";
            // 
            // txt_compte_courant
            // 
            this.txt_compte_courant.Depth = 0;
            this.txt_compte_courant.Hint = "";
            this.txt_compte_courant.Location = new System.Drawing.Point(159, 100);
            this.txt_compte_courant.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_compte_courant.Name = "txt_compte_courant";
            this.txt_compte_courant.PasswordChar = '\0';
            this.txt_compte_courant.SelectedText = "";
            this.txt_compte_courant.SelectionLength = 0;
            this.txt_compte_courant.SelectionStart = 0;
            this.txt_compte_courant.Size = new System.Drawing.Size(122, 23);
            this.txt_compte_courant.TabIndex = 8;
            this.txt_compte_courant.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(301, 49);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton2.TabIndex = 66;
            this.materialRaisedButton2.Text = "lancer";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Visible = false;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(301, 95);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton3.TabIndex = 67;
            this.materialRaisedButton3.Text = "lancer";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Visible = false;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // lbl_message_compte
            // 
            this.lbl_message_compte.AutoSize = true;
            this.lbl_message_compte.Location = new System.Drawing.Point(6, 173);
            this.lbl_message_compte.Name = "lbl_message_compte";
            this.lbl_message_compte.Size = new System.Drawing.Size(134, 17);
            this.lbl_message_compte.TabIndex = 66;
            this.lbl_message_compte.Text = "Compte message !!";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(22, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(535, 372);
            this.dataGridView2.TabIndex = 66;
            this.dataGridView2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_generer_rapport);
            this.groupBox3.Controls.Add(this.materialRaisedButton4);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox3.Location = new System.Drawing.Point(553, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 521);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recentes oprtations";
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(195, 434);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(127, 38);
            this.materialRaisedButton4.TabIndex = 68;
            this.materialRaisedButton4.Text = "supprimer";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Visible = false;
            // 
            // btn_generer_rapport
            // 
            this.btn_generer_rapport.Depth = 0;
            this.btn_generer_rapport.Location = new System.Drawing.Point(382, 434);
            this.btn_generer_rapport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_generer_rapport.Name = "btn_generer_rapport";
            this.btn_generer_rapport.Primary = true;
            this.btn_generer_rapport.Size = new System.Drawing.Size(175, 38);
            this.btn_generer_rapport.TabIndex = 69;
            this.btn_generer_rapport.Text = "generer le rapport";
            this.btn_generer_rapport.UseVisualStyleBackColor = true;
            this.btn_generer_rapport.Visible = false;
            this.btn_generer_rapport.Click += new System.EventHandler(this.btn_generer_rapport_Click);
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(325, 457);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(174, 38);
            this.materialRaisedButton6.TabIndex = 70;
            this.materialRaisedButton6.Text = "nouvelle operation";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.materialRaisedButton6_Click);
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(301, 49);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton7.TabIndex = 68;
            this.materialRaisedButton7.Text = "effectuer";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Visible = false;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Location = new System.Drawing.Point(301, 95);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton8.TabIndex = 71;
            this.materialRaisedButton8.Text = "effectuer";
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            this.materialRaisedButton8.Visible = false;
            this.materialRaisedButton8.Click += new System.EventHandler(this.materialRaisedButton8_Click);
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Location = new System.Drawing.Point(325, 457);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(174, 38);
            this.materialRaisedButton9.TabIndex = 71;
            this.materialRaisedButton9.Text = "annuler";
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            this.materialRaisedButton9.Visible = false;
            this.materialRaisedButton9.Click += new System.EventHandler(this.materialRaisedButton9_Click);
            // 
            // panel_nouvelle_operation
            // 
            this.panel_nouvelle_operation.Controls.Add(this.groupBox4);
            this.panel_nouvelle_operation.Location = new System.Drawing.Point(553, 47);
            this.panel_nouvelle_operation.Name = "panel_nouvelle_operation";
            this.panel_nouvelle_operation.Size = new System.Drawing.Size(591, 518);
            this.panel_nouvelle_operation.TabIndex = 72;
            this.panel_nouvelle_operation.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialRaisedButton11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.materialRaisedButton10);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.txtcompte);
            this.groupBox4.Controls.Add(this.dtdate_creation);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.txtsolde);
            this.groupBox4.Controls.Add(this.cmboperation);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox4.Location = new System.Drawing.Point(25, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 466);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "nouvelle operation";
            // 
            // dtdate_creation
            // 
            this.dtdate_creation.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtdate_creation.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtdate_creation.Location = new System.Drawing.Point(178, 130);
            this.dtdate_creation.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtdate_creation.Name = "dtdate_creation";
            this.dtdate_creation.Size = new System.Drawing.Size(161, 29);
            this.dtdate_creation.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Date creation :";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel7.Location = new System.Drawing.Point(178, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(159, 2);
            this.panel7.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Solde :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel6.Location = new System.Drawing.Point(178, 197);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(159, 2);
            this.panel6.TabIndex = 66;
            // 
            // txtsolde
            // 
            this.txtsolde.BackColor = System.Drawing.SystemColors.Control;
            this.txtsolde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsolde.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsolde.Location = new System.Drawing.Point(178, 180);
            this.txtsolde.Name = "txtsolde";
            this.txtsolde.Size = new System.Drawing.Size(156, 16);
            this.txtsolde.TabIndex = 65;
            // 
            // cmboperation
            // 
            this.cmboperation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmboperation.FormattingEnabled = true;
            this.cmboperation.Items.AddRange(new object[] {
            "Depot",
            "Retrait"});
            this.cmboperation.Location = new System.Drawing.Point(178, 82);
            this.cmboperation.Name = "cmboperation";
            this.cmboperation.Size = new System.Drawing.Size(156, 25);
            this.cmboperation.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel4.Location = new System.Drawing.Point(175, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 2);
            this.panel4.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Type operation :";
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Location = new System.Drawing.Point(267, 245);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton10.TabIndex = 73;
            this.materialRaisedButton10.Text = "valider";
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            this.materialRaisedButton10.Click += new System.EventHandler(this.materialRaisedButton10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Compte :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(105)))), ((int)(((byte)(161)))));
            this.panel3.Location = new System.Drawing.Point(171, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 2);
            this.panel3.TabIndex = 72;
            // 
            // txtcompte
            // 
            this.txtcompte.BackColor = System.Drawing.SystemColors.Control;
            this.txtcompte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcompte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcompte.Location = new System.Drawing.Point(171, 42);
            this.txtcompte.Name = "txtcompte";
            this.txtcompte.Size = new System.Drawing.Size(156, 16);
            this.txtcompte.TabIndex = 71;
            // 
            // materialRaisedButton11
            // 
            this.materialRaisedButton11.Depth = 0;
            this.materialRaisedButton11.Location = new System.Drawing.Point(267, 404);
            this.materialRaisedButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton11.Name = "materialRaisedButton11";
            this.materialRaisedButton11.Primary = true;
            this.materialRaisedButton11.Size = new System.Drawing.Size(113, 38);
            this.materialRaisedButton11.TabIndex = 73;
            this.materialRaisedButton11.Text = "fermer";
            this.materialRaisedButton11.UseVisualStyleBackColor = true;
            this.materialRaisedButton11.Click += new System.EventHandler(this.materialRaisedButton11_Click);
            // 
            // panel_progression
            // 
            this.panel_progression.Controls.Add(this.metroProgressBar);
            this.panel_progression.Controls.Add(this.lblprogresseBar);
            this.panel_progression.Location = new System.Drawing.Point(557, 586);
            this.panel_progression.Name = "panel_progression";
            this.panel_progression.Size = new System.Drawing.Size(420, 66);
            this.panel_progression.TabIndex = 72;
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
            this.lblprogresseBar.Location = new System.Drawing.Point(147, 12);
            this.lblprogresseBar.Name = "lblprogresseBar";
            this.lblprogresseBar.Size = new System.Drawing.Size(110, 17);
            this.lblprogresseBar.TabIndex = 10;
            this.lblprogresseBar.Text = "chargement 0%...";
            // 
            // txtnom_rapport
            // 
            this.txtnom_rapport.Depth = 0;
            this.txtnom_rapport.Hint = "";
            this.txtnom_rapport.Location = new System.Drawing.Point(128, 49);
            this.txtnom_rapport.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnom_rapport.Name = "txtnom_rapport";
            this.txtnom_rapport.PasswordChar = '\0';
            this.txtnom_rapport.SelectedText = "";
            this.txtnom_rapport.SelectionLength = 0;
            this.txtnom_rapport.SelectionStart = 0;
            this.txtnom_rapport.Size = new System.Drawing.Size(183, 23);
            this.txtnom_rapport.TabIndex = 25;
            this.txtnom_rapport.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Nom rapport :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtnom_rapport);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox5.Location = new System.Drawing.Point(68, 518);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 99);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Notation rapport";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // txt_requete
            // 
            this.txt_requete.Location = new System.Drawing.Point(68, 632);
            this.txt_requete.Name = "txt_requete";
            this.txt_requete.Size = new System.Drawing.Size(100, 20);
            this.txt_requete.TabIndex = 74;
            this.txt_requete.Visible = false;
            // 
            // operationss_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_requete);
            this.Controls.Add(this.panel_nouvelle_operation);
            this.Controls.Add(this.panel_progression);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.materialRaisedButton9);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.groupBox1);
            this.Name = "operationss_client";
            this.Size = new System.Drawing.Size(1197, 677);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel_nouvelle_operation.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel_progression.ResumeLayout(false);
            this.panel_progression.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_prenom;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_postnom;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_compte_a_terme;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_compte_courant;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Label lbl_message_compte;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRaisedButton btn_generer_rapport;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton8;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton9;
        private System.Windows.Forms.Panel panel_nouvelle_operation;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroDateTime dtdate_creation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtsolde;
        private System.Windows.Forms.ComboBox cmboperation;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcompte;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton11;
        private System.Windows.Forms.Panel panel_progression;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.Label lblprogresseBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnom_rapport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TextBox txt_requete;
    }
}