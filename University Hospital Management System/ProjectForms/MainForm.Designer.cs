﻿namespace University_Hospital_Management_System.ProjectForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.viewUserData_btn = new System.Windows.Forms.Button();
            this.showPatientsData_btn = new System.Windows.Forms.Button();
            this.patientsDataPanel = new System.Windows.Forms.Panel();
            this.patientsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchPatientsData_btn = new System.Windows.Forms.Button();
            this.patientID_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patientName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveChanges_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.patientsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, ";
            // 
            // viewUserData_btn
            // 
            this.viewUserData_btn.Location = new System.Drawing.Point(17, 105);
            this.viewUserData_btn.Name = "viewUserData_btn";
            this.viewUserData_btn.Size = new System.Drawing.Size(128, 58);
            this.viewUserData_btn.TabIndex = 2;
            this.viewUserData_btn.Text = "View my Data";
            this.viewUserData_btn.UseVisualStyleBackColor = true;
            // 
            // showPatientsData_btn
            // 
            this.showPatientsData_btn.Location = new System.Drawing.Point(17, 186);
            this.showPatientsData_btn.Name = "showPatientsData_btn";
            this.showPatientsData_btn.Size = new System.Drawing.Size(128, 58);
            this.showPatientsData_btn.TabIndex = 0;
            this.showPatientsData_btn.Text = "Show Patients Data";
            this.showPatientsData_btn.UseVisualStyleBackColor = true;
            this.showPatientsData_btn.Click += new System.EventHandler(this.showPatientsData_btn_Click);
            // 
            // patientsDataPanel
            // 
            this.patientsDataPanel.Controls.Add(this.saveChanges_btn);
            this.patientsDataPanel.Controls.Add(this.patientsDataGridView);
            this.patientsDataPanel.Controls.Add(this.searchPatientsData_btn);
            this.patientsDataPanel.Controls.Add(this.patientID_txt);
            this.patientsDataPanel.Controls.Add(this.label4);
            this.patientsDataPanel.Controls.Add(this.patientName_txt);
            this.patientsDataPanel.Controls.Add(this.label3);
            this.patientsDataPanel.Controls.Add(this.label2);
            this.patientsDataPanel.Location = new System.Drawing.Point(420, 27);
            this.patientsDataPanel.Name = "patientsDataPanel";
            this.patientsDataPanel.Size = new System.Drawing.Size(506, 538);
            this.patientsDataPanel.TabIndex = 4;
            this.patientsDataPanel.Visible = false;
            this.patientsDataPanel.VisibleChanged += new System.EventHandler(this.patientsDataPanel_VisibleChanged);
            // 
            // patientsDataGridView
            // 
            this.patientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGridView.Location = new System.Drawing.Point(3, 127);
            this.patientsDataGridView.Name = "patientsDataGridView";
            this.patientsDataGridView.Size = new System.Drawing.Size(500, 367);
            this.patientsDataGridView.TabIndex = 6;
            // 
            // searchPatientsData_btn
            // 
            this.searchPatientsData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientsData_btn.Location = new System.Drawing.Point(311, 90);
            this.searchPatientsData_btn.Name = "searchPatientsData_btn";
            this.searchPatientsData_btn.Size = new System.Drawing.Size(102, 31);
            this.searchPatientsData_btn.TabIndex = 2;
            this.searchPatientsData_btn.Text = "Search";
            this.searchPatientsData_btn.UseVisualStyleBackColor = true;
            this.searchPatientsData_btn.Click += new System.EventHandler(this.searchPatientsData_btn_Click);
            // 
            // patientID_txt
            // 
            this.patientID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.patientID_txt.Location = new System.Drawing.Point(124, 90);
            this.patientID_txt.MaxLength = 10;
            this.patientID_txt.Name = "patientID_txt";
            this.patientID_txt.Size = new System.Drawing.Size(62, 29);
            this.patientID_txt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient ID :";
            // 
            // patientName_txt
            // 
            this.patientName_txt.Enabled = false;
            this.patientName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.patientName_txt.Location = new System.Drawing.Point(97, 49);
            this.patientName_txt.MaxLength = 70;
            this.patientName_txt.Name = "patientName_txt";
            this.patientName_txt.Size = new System.Drawing.Size(331, 29);
            this.patientName_txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patients Data :";
            // 
            // saveChanges_btn
            // 
            this.saveChanges_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges_btn.Location = new System.Drawing.Point(325, 497);
            this.saveChanges_btn.Name = "saveChanges_btn";
            this.saveChanges_btn.Size = new System.Drawing.Size(169, 38);
            this.saveChanges_btn.TabIndex = 3;
            this.saveChanges_btn.Text = "Save Changes";
            this.saveChanges_btn.UseVisualStyleBackColor = true;
            this.saveChanges_btn.Click += new System.EventHandler(this.saveChanges_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 568);
            this.Controls.Add(this.patientsDataPanel);
            this.Controls.Add(this.showPatientsData_btn);
            this.Controls.Add(this.viewUserData_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Hospital Management System - Main Page";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.patientsDataPanel.ResumeLayout(false);
            this.patientsDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewUserData_btn;
        private System.Windows.Forms.Button showPatientsData_btn;
        private System.Windows.Forms.Panel patientsDataPanel;
        private System.Windows.Forms.DataGridView patientsDataGridView;
        private System.Windows.Forms.Button searchPatientsData_btn;
        private System.Windows.Forms.TextBox patientID_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patientName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveChanges_btn;
    }
}