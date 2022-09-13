
namespace HelpDeskReport.Forms
{
    partial class FormView
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bSelectAll = new FontAwesome.Sharp.IconButton();
            this.bEnter = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Thistle;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 397);
            this.dataGridView.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSearch.Location = new System.Drawing.Point(88, 416);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(421, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSearch.Location = new System.Drawing.Point(12, 414);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 23);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(13, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Results:";
            // 
            // bSelectAll
            // 
            this.bSelectAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSelectAll.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bSelectAll.FlatAppearance.BorderSize = 0;
            this.bSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSelectAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.bSelectAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bSelectAll.IconColor = System.Drawing.Color.Gainsboro;
            this.bSelectAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bSelectAll.Location = new System.Drawing.Point(629, 413);
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.Size = new System.Drawing.Size(75, 23);
            this.bSelectAll.TabIndex = 1;
            this.bSelectAll.Text = "Show All ";
            this.bSelectAll.UseVisualStyleBackColor = false;
            this.bSelectAll.Click += new System.EventHandler(this.bSelectAll_Click);
            // 
            // bEnter
            // 
            this.bEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bEnter.BackColor = System.Drawing.Color.SlateBlue;
            this.bEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bEnter.FlatAppearance.BorderSize = 0;
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnter.ForeColor = System.Drawing.Color.Gainsboro;
            this.bEnter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bEnter.IconColor = System.Drawing.Color.Black;
            this.bEnter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bEnter.Location = new System.Drawing.Point(531, 413);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(75, 23);
            this.bEnter.TabIndex = 2;
            this.bEnter.Text = "Enter";
            this.bEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bEnter.UseVisualStyleBackColor = false;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSelectAll);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormView";
            this.Text = "FormView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private FontAwesome.Sharp.IconButton bSelectAll;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTotal;
        private FontAwesome.Sharp.IconButton bEnter;
    }
}