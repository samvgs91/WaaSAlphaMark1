using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WaaSDomain;

namespace WaaSAlphaMark1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USERNAME or EMAIL")
            {
                txtUser.Text = "";
                txtUser.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USERNAME or EMAIL";
                txtUser.ForeColor = SystemColors.GrayText;
            }
            lblErrorMessage.Visible = false;
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

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lnklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
            createUser.FormClosed += ReturnFromCreate;
            this.Hide();
        }

        private void pboxClose2_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ReturnFromCreate(object sender, FormClosedEventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            this.Show();
            txtUser.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
          
            if(ValidateInput())
            {
                UserModel userModel = new UserModel();
                bool validateLogin = userModel.LoginUser(txtUser.Text, txtPassword.Text);
                if (validateLogin)
                {
                    Main_Portal mainPortal = new Main_Portal();
                    mainPortal.Show();
                    mainPortal.FormClosed += ReturnFromCreate;
                    this.Hide();
                }
            }

        }

        private bool ValidateInput()
        {
            bool validation = true;

            if (txtPassword.Text == "PASSWORD")
            {
                lblErrorMessage.Visible = true;
                validation = false;
                txtPassword.Focus();
                MsgError("Must enter a password");
            }

            if (txtUser.Text == "USERNAME or EMAIL")
            {
                lblErrorMessage.Visible = true;
                validation = false;
                txtUser.Focus();
                MsgError("Must Enter UserName or Email");   
            }
            return validation;
        }

        private void MsgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }
    }
}
