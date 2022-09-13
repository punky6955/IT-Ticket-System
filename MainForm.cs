using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HelpDeskReport.Forms;

namespace HelpDeskReport
{
    public partial class MainForm : Form
    {
        //fields
        private IconButton currButton;
        private Panel leftBordButton;
        private Form currChildForm;
        //constructor
        public MainForm()
        {
            InitializeComponent();
            leftBordButton = new Panel();
            leftBordButton.Size = new Size(7, 60);
            menuPanel.Controls.Add(leftBordButton);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //visually show selected button
        private void ActivateButton(object senderbtn, Color color)
        {
            if(senderbtn != null)
            {
                DisableButton();
                currButton = (IconButton)senderbtn;
                currButton.BackColor = Color.FromArgb(37, 36, 81);
                currButton.ForeColor = color;
                currButton.TextAlign = ContentAlignment.MiddleCenter;
                currButton.IconColor = color;
                currButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currButton.ImageAlign = ContentAlignment.MiddleRight;

                //left border
                leftBordButton.BackColor = color;
                leftBordButton.Location = new Point(0, currButton.Location.Y);
                leftBordButton.Visible = true;
                leftBordButton.BringToFront();

                iconCurrentChildForm.IconChar = currButton.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        //set button back to original look
        private void DisableButton()
        {
            if (currButton != null)
            {
                currButton.BackColor = Color.FromArgb(31, 30, 68);
                currButton.ForeColor = Color.Gainsboro;
                currButton.TextAlign = ContentAlignment.MiddleLeft;
                currButton.IconColor = Color.Gainsboro;
                currButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currChildForm != null)
            {
                currChildForm.Close();
            }
            currChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleHome.Text = childForm.Text;
            childForm.Size = panelDesktop.Size; 
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Teal);
            OpenChildForm(new FormHome());
        }

        private void bView_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Fuchsia);
            OpenChildForm(new FormView());
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Lavender);
            OpenChildForm(new FormUpdate());
        }

        private void nHome_Click(object sender, EventArgs e)
        {
            if (currChildForm != null)
            {
                currChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBordButton.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleHome.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void bMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
