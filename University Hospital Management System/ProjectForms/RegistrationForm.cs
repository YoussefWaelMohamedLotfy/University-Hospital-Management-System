﻿using System;
using System.Windows.Forms;
using University_Hospital_Management_System.ProjectClasses;

namespace University_Hospital_Management_System.ProjectForms
{
    public partial class RegistrationForm : Form
    {
        string selectedGender;
        string userType;

        public RegistrationForm()
        {
            selectedGender = string.Empty;
            userType = string.Empty;
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (CheckIfTextValid())
            {
                OrclDatabase.RegisterNewUser(newName_txt.Text, newUserName_txt.Text, newPassword_txt.Text, specialty_comboBox.SelectedItem.ToString(), selectedGender);
                this.Dispose();
                this.Close();
            }
        }

        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            selectedGender = ((RadioButton)sender).Text;
        }

        private void UserType_CheckedChanged(object sender, EventArgs e)
        {
            userType = ((RadioButton)sender).Text;
        }

        private bool CheckIfTextValid()
        {
            if (string.IsNullOrEmpty(selectedGender) || string.IsNullOrEmpty(userType) ||
                string.IsNullOrEmpty(newName_txt.Text) || string.IsNullOrWhiteSpace(newName_txt.Text) ||
                string.IsNullOrEmpty(newUserName_txt.Text) || string.IsNullOrWhiteSpace(newUserName_txt.Text) ||
                string.IsNullOrEmpty(newPassword_txt.Text) || string.IsNullOrWhiteSpace(newPassword_txt.Text) ||
                string.IsNullOrEmpty(newConfirmedPassword_txt.Text) || string.IsNullOrWhiteSpace(newConfirmedPassword_txt.Text))
            {
                MessageBox.Show("Data is missing.");
                return false;
            }

            if (newPassword_txt.Text != newConfirmedPassword_txt.Text)
            {
                MessageBox.Show("Check password again");
                return false;
            }

            return true;
        }
    }
}