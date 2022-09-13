
namespace HelpDeskReport
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.topMenuPanel = new System.Windows.Forms.Panel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitleHome = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.bMin = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.bClose = new FontAwesome.Sharp.IconButton();
            this.bUpdate = new FontAwesome.Sharp.IconButton();
            this.bView = new FontAwesome.Sharp.IconButton();
            this.bHome = new FontAwesome.Sharp.IconButton();
            this.nHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.topMenuPanel.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menuPanel.Controls.Add(this.bUpdate);
            this.menuPanel.Controls.Add(this.bView);
            this.menuPanel.Controls.Add(this.bHome);
            this.menuPanel.Controls.Add(this.topMenuPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(180, 481);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuPanel_MouseDown);
            // 
            // topMenuPanel
            // 
            this.topMenuPanel.Controls.Add(this.nHome);
            this.topMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.topMenuPanel.Name = "topMenuPanel";
            this.topMenuPanel.Size = new System.Drawing.Size(180, 89);
            this.topMenuPanel.TabIndex = 0;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pTitle.Controls.Add(this.bMin);
            this.pTitle.Controls.Add(this.iconButton1);
            this.pTitle.Controls.Add(this.lblTitleHome);
            this.pTitle.Controls.Add(this.iconCurrentChildForm);
            this.pTitle.Controls.Add(this.bClose);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(180, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(857, 44);
            this.pTitle.TabIndex = 1;
            this.pTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseDown);
            // 
            // lblTitleHome
            // 
            this.lblTitleHome.AutoSize = true;
            this.lblTitleHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleHome.Location = new System.Drawing.Point(44, 9);
            this.lblTitleHome.Name = "lblTitleHome";
            this.lblTitleHome.Size = new System.Drawing.Size(39, 13);
            this.lblTitleHome.TabIndex = 1;
            this.lblTitleHome.Text = "Home";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(180, 44);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(857, 437);
            this.panelDesktop.TabIndex = 3;
            // 
            // bMin
            // 
            this.bMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bMin.FlatAppearance.BorderSize = 0;
            this.bMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.bMin.IconColor = System.Drawing.Color.Gainsboro;
            this.bMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bMin.IconSize = 18;
            this.bMin.Location = new System.Drawing.Point(785, 12);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(16, 18);
            this.bMin.TabIndex = 3;
            this.bMin.UseVisualStyleBackColor = true;
            this.bMin.Click += new System.EventHandler(this.bMin_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(807, 12);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(16, 18);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Thistle;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Thistle;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 3);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.FlatAppearance.BorderSize = 0;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.bClose.IconColor = System.Drawing.Color.Gainsboro;
            this.bClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bClose.IconSize = 18;
            this.bClose.Location = new System.Drawing.Point(829, 12);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(16, 18);
            this.bClose.TabIndex = 0;
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.bUpdate.FlatAppearance.BorderSize = 0;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.bUpdate.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.bUpdate.IconColor = System.Drawing.Color.Gainsboro;
            this.bUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bUpdate.IconSize = 32;
            this.bUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUpdate.Location = new System.Drawing.Point(0, 209);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bUpdate.Size = new System.Drawing.Size(180, 60);
            this.bUpdate.TabIndex = 3;
            this.bUpdate.Text = "Create Ticket";
            this.bUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bView
            // 
            this.bView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bView.FlatAppearance.BorderSize = 0;
            this.bView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bView.ForeColor = System.Drawing.Color.Gainsboro;
            this.bView.IconChar = FontAwesome.Sharp.IconChar.Binoculars;
            this.bView.IconColor = System.Drawing.Color.Gainsboro;
            this.bView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bView.IconSize = 32;
            this.bView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bView.Location = new System.Drawing.Point(0, 149);
            this.bView.Name = "bView";
            this.bView.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bView.Size = new System.Drawing.Size(180, 60);
            this.bView.TabIndex = 2;
            this.bView.Text = "View";
            this.bView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bView.UseVisualStyleBackColor = true;
            this.bView.Click += new System.EventHandler(this.bView_Click);
            // 
            // bHome
            // 
            this.bHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.bHome.FlatAppearance.BorderSize = 0;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.bHome.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bHome.IconColor = System.Drawing.Color.Gainsboro;
            this.bHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bHome.IconSize = 32;
            this.bHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHome.Location = new System.Drawing.Point(0, 89);
            this.bHome.Name = "bHome";
            this.bHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bHome.Size = new System.Drawing.Size(180, 60);
            this.bHome.TabIndex = 1;
            this.bHome.Text = "Update";
            this.bHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // nHome
            // 
            this.nHome.Image = global::HelpDeskReport.Properties.Resources.flclLogo3;
            this.nHome.Location = new System.Drawing.Point(3, 3);
            this.nHome.Name = "nHome";
            this.nHome.Size = new System.Drawing.Size(171, 82);
            this.nHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nHome.TabIndex = 0;
            this.nHome.TabStop = false;
            this.nHome.Click += new System.EventHandler(this.nHome_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(78, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click \"Update\" in order to update an existing ticket.Input the Order ID then sele" +
    "ct \"Delete\" to delete a ticket.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(78, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Click \"Create Ticket\" in order to create a new ticket.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(78, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(615, 60);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click \"View\" in order to view an existing ticket.You can \"Show All\" or search by " +
    "Tech ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 481);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.topMenuPanel.ResumeLayout(false);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topMenuPanel;
        private FontAwesome.Sharp.IconButton bUpdate;
        private FontAwesome.Sharp.IconButton bView;
        private System.Windows.Forms.PictureBox nHome;
        private System.Windows.Forms.Panel pTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleHome;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton bMin;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton bClose;
        private FontAwesome.Sharp.IconButton bHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}