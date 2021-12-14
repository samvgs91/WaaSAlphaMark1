using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace WaaSAlphaMark1
{
    public partial class Main_Portal : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private string UserId;
        private string SelectedWorkspaceFileId;
        private string SelectedDatasetId;

        public Main_Portal(string userId)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            UserId = userId;

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wmsg, int wparam, int lparam);

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {

                DisableButton();

                currentBtn = (IconButton)senderBtn;
                //currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.BackColor = Color.FromArgb(243, 179, 64);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                ibtnHome.IconChar = currentBtn.IconChar;
                lblHome.Text = currentBtn.Text;
                // ibtnHome.IconColor = color;
            }
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(233, 227, 215);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(244, 243, 239);
                currentBtn.ForeColor = Color.FromArgb(54, 76, 99);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(54, 76, 99);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentChildForm != null)
        //    {
        //        currentChildForm.Close();
        //    }
        //    using (childForm)
        //    {
        //        currentChildForm = childForm;
        //        childForm.TopLevel = false;
        //        childForm.FormBorderStyle = FormBorderStyle.None;
        //        childForm.Dock = DockStyle.Fill;
        //        childForm.Size = pnlDesktop.Size;
        //        pnlDesktop.Controls.Add(childForm);
        //        pnlDesktop.Tag = childForm;
        //        childForm.BringToFront();
        //        childForm.Show();
        //    }
        //}

        private void ibtnWorkspace_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            //OpenChildForm(new Workspace(UserId));
            OpenWorkspace();
        }

        private void OpenWorkspace()
        {

            Workspace childForm = new Workspace(UserId);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //using (childForm)
            //{
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = pnlDesktop.Size;
            childForm.Selected += new EventHandler(GetWorkspaceFile);
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void OpenDataSets()
        {
            DataSets childForm = new DataSets(UserId);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            //using (childForm)
            //{
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = pnlDesktop.Size;
            childForm.Selected += new EventHandler(GetDatasetView);
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void GetWorkspaceFile(object sender, EventArgs e)
        {
            Workspace frm = sender as Workspace;
            if (frm != null)
            {
                SelectedWorkspaceFileId = frm.GetSelectedFile();
                //MessageBox.Show("Id Seleceted from Child Form is: " + SelectedWorkspaceFileId);
                OpenDataSetViewFromFile();
            }
        }

        private void GetDatasetView(object sender, EventArgs e)
        {
            DataSets frm = sender as DataSets;
            if (frm != null)
            {
                SelectedDatasetId = frm.GetSelectedDatasetId();
                //MessageBox.Show("Id Seleceted from Child Form is: " + SelectedWorkspaceFileId);
                OpenDataSetView();
            }
        }

        private void OpenDataSetViewFromFile()
        {
            DatasetViewNew childForm = new DatasetViewNew(UserId, SelectedWorkspaceFileId);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = pnlDesktop.Size;
            //childForm.Selected += new EventHandler(GetWorkspaceFile);
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.FormClosed += ResetWorkSpace;
            SelectedWorkspaceFileId = null;
        }


        private void OpenDataSetView()
        {
            DatasetView childForm = new DatasetView(UserId, SelectedDatasetId);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = pnlDesktop.Size;
           // childForm.Selected += new EventHandler(GetWorkspaceFile);
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.FormClosed += ResetWorkSpace;
            SelectedDatasetId = null;
            SelectedWorkspaceFileId = null;
        }

        private void ResetWorkSpace(object sender, FormClosedEventArgs e)
        {
            //ActivateButton(sender, RGBColors.color2);
            //OpenChildForm(new Workspace(UserId));
            currentChildForm = null;
            OpenDataSets();
            //OpenWorkspace();
        }

        private void ibtnData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenDataSets();
        }

        private void ibtnModel_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void ibtnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void ibtnConfiguration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            ibtnHome.IconChar = IconChar.Home;
            //ibtnHome.IconColor = Color.FromArgb(54, 76, 99);
            lblHome.Text = "Home";
            if(currentChildForm != null) currentChildForm.Close();
            

        }

        private void pnlMenu_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Main_Portal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pboxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Minimized;
        }

        private void ibtnNewFile_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
