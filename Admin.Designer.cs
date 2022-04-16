namespace Session1
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddUser = new System.Windows.Forms.LinkLabel();
            this.Exit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOffice = new System.Windows.Forms.ComboBox();
            this.AdminDG = new System.Windows.Forms.DataGridView();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session1.Properties.Resources.white_2x;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            this.AddUser.AutoSize = true;
            this.AddUser.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.AddUser.Location = new System.Drawing.Point(22, 102);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(66, 13);
            this.AddUser.TabIndex = 2;
            this.AddUser.TabStop = true;
            this.AddUser.Text = "Add User";
            this.AddUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddUser_LinkClicked);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.LinkColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(106, 102);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 13);
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = true;
            this.Exit.Text = "Exit";
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Office:";
            // 
            // cmbOffice
            // 
            this.cmbOffice.FormattingEnabled = true;
            this.cmbOffice.Items.AddRange(new object[] {
            "Abu dhabi",
            "Cairo",
            "Bahrain",
            "Doha",
            "Riyadh"});
            this.cmbOffice.Location = new System.Drawing.Point(86, 126);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.Size = new System.Drawing.Size(140, 21);
            this.cmbOffice.TabIndex = 5;
            this.cmbOffice.SelectedIndexChanged += new System.EventHandler(this.cmbOffice_SelectedIndexChanged);
            // 
            // AdminDG
            // 
            this.AdminDG.AllowUserToAddRows = false;
            this.AdminDG.AllowUserToDeleteRows = false;
            this.AdminDG.BackgroundColor = System.Drawing.Color.White;
            this.AdminDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminDG.GridColor = System.Drawing.Color.White;
            this.AdminDG.Location = new System.Drawing.Point(26, 177);
            this.AdminDG.Name = "AdminDG";
            this.AdminDG.ReadOnly = true;
            this.AdminDG.Size = new System.Drawing.Size(1032, 284);
            this.AdminDG.TabIndex = 6;
            this.AdminDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminDG_CellContentClick);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.Red;
            this.btnEnable.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnable.ForeColor = System.Drawing.Color.White;
            this.btnEnable.Location = new System.Drawing.Point(215, 485);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(157, 38);
            this.btnEnable.TabIndex = 8;
            this.btnEnable.Text = "Enable/disable Login";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.btnChange.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(26, 485);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(151, 38);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change Role";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.AdminDG);
            this.Controls.Add(this.cmbOffice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMONIC Airlines Automation System";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel AddUser;
        private System.Windows.Forms.LinkLabel Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOffice;
        private System.Windows.Forms.DataGridView AdminDG;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnChange;
    }
}