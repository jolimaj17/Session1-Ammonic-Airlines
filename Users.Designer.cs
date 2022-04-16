namespace Session1
{
    partial class Users
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
            this.UserDG = new System.Windows.Forms.DataGridView();
            this.lblHi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCrash = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UserDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDG
            // 
            this.UserDG.AllowUserToAddRows = false;
            this.UserDG.AllowUserToDeleteRows = false;
            this.UserDG.BackgroundColor = System.Drawing.Color.White;
            this.UserDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDG.GridColor = System.Drawing.Color.White;
            this.UserDG.Location = new System.Drawing.Point(24, 159);
            this.UserDG.Name = "UserDG";
            this.UserDG.ReadOnly = true;
            this.UserDG.Size = new System.Drawing.Size(865, 284);
            this.UserDG.TabIndex = 14;
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHi.ForeColor = System.Drawing.Color.White;
            this.lblHi.Location = new System.Drawing.Point(21, 120);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(49, 13);
            this.lblHi.TabIndex = 12;
            this.lblHi.Text = "Office:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session1.Properties.Resources.white_2x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(363, 133);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 13);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Office:";
            // 
            // lblCrash
            // 
            this.lblCrash.AutoSize = true;
            this.lblCrash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrash.ForeColor = System.Drawing.Color.White;
            this.lblCrash.Location = new System.Drawing.Point(710, 120);
            this.lblCrash.Name = "lblCrash";
            this.lblCrash.Size = new System.Drawing.Size(49, 13);
            this.lblCrash.TabIndex = 16;
            this.lblCrash.Text = "Office:";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.LinkColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(21, 89);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(32, 13);
            this.Exit.TabIndex = 17;
            this.Exit.TabStop = true;
            this.Exit.Text = "Exit";
            this.Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Exit_LinkClicked);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(920, 483);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.lblCrash);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.UserDG);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserDG;
        private System.Windows.Forms.Label lblHi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCrash;
        private System.Windows.Forms.LinkLabel Exit;
    }
}