﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaaSDomain;

namespace WaaSAlphaMark1
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USERNAME")
            {
                txtUser.Text = "";
                txtUser.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = SystemColors.GrayText;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USERNAME";
                txtUser.ForeColor = SystemColors.GrayText;
            }
            lblErrorMessage.Visible = false;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                txtEmail.ForeColor = SystemColors.GrayText;
            }
            lblErrorMessage.Visible = false;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "PASSWORD";
                txtPassword.ForeColor = SystemColors.GrayText;
                txtPassword.UseSystemPasswordChar = false;
            }
            lblErrorMessage.Visible = false;
        }

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "RE-ENTER  PASSWORD")
            {
                txtRePassword.Text = "";
                txtRePassword.ForeColor = SystemColors.GrayText;
                txtRePassword.UseSystemPasswordChar = true;
            }
        }

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "")
            {
                txtRePassword.Text = "RE-ENTER  PASSWORD";
                txtRePassword.ForeColor = SystemColors.GrayText;
                txtRePassword.UseSystemPasswordChar = false;
            }
            lblErrorMessage.Visible = false;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validatidation = ValidateInputData();

            if (validatidation)
            {
                UserModel userModel = new UserModel();
                userModel.CreateUser(txtUser.Text, txtEmail.Text, txtPassword.Text);
                MessageBox.Show("Great! Now you can sign in");
                this.Close();
            }
        }

        private bool ValidateInputData()
        {
            bool InputDataValidation = true;

            if (txtPassword.Text != txtRePassword.Text) { InputDataValidation = false; MsgError("Must enter same Passwords"); }
            if (txtRePassword.Text == "RE-ENTER  PASSWORD") { InputDataValidation = false; MsgError("Enter the Password again"); }
            if (txtPassword.Text == "PASSWORD") { InputDataValidation = false; MsgError("Enter a Password"); }
            if (txtEmail.Text == "EMAIL") { InputDataValidation = false; MsgError("Enter a Email"); }
            if (txtUser.Text == "USERNAME") { InputDataValidation = false; MsgError("Enter a UserName"); }

            return InputDataValidation;
        }

        private void MsgError(string msg)
            {
                lblErrorMessage.Text = msg;
                lblErrorMessage.Visible = true;
            }
    }
}
