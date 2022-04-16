namespace Session1
{
    partial class NologoutDetected
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
            this.mess = new System.Windows.Forms.Label();
            this.Reasons = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.system = new System.Windows.Forms.RadioButton();
            this.soft = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Session1.Properties.Resources.white_2x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // mess
            // 
            this.mess.AutoSize = true;
            this.mess.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mess.ForeColor = System.Drawing.Color.White;
            this.mess.Location = new System.Drawing.Point(12, 110);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(49, 13);
            this.mess.TabIndex = 5;
            this.mess.Text = "Office:";
            // 
            // Reasons
            // 
            this.Reasons.AutoSize = true;
            this.Reasons.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reasons.ForeColor = System.Drawing.Color.White;
            this.Reasons.Location = new System.Drawing.Point(12, 145);
            this.Reasons.Name = "Reasons";
            this.Reasons.Size = new System.Drawing.Size(65, 13);
            this.Reasons.TabIndex = 6;
            this.Reasons.Text = "Reasons:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 176);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(699, 197);
            this.textBox1.TabIndex = 7;
            // 
            // system
            // 
            this.system.AutoSize = true;
            this.system.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.system.ForeColor = System.Drawing.Color.White;
            this.system.Location = new System.Drawing.Point(145, 397);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(114, 17);
            this.system.TabIndex = 37;
            this.system.TabStop = true;
            this.system.Text = "System Crash";
            this.system.UseVisualStyleBackColor = true;
            // 
            // soft
            // 
            this.soft.AutoSize = true;
            this.soft.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soft.ForeColor = System.Drawing.Color.White;
            this.soft.Location = new System.Drawing.Point(15, 397);
            this.soft.Name = "soft";
            this.soft.Size = new System.Drawing.Size(124, 17);
            this.soft.TabIndex = 37;
            this.soft.TabStop = true;
            this.soft.Text = "Software Crash";
            this.soft.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(75)))), ((int)(((byte)(102)))));
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(321, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 38);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Confirm";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NologoutDetected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(106)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(726, 468);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.soft);
            this.Controls.Add(this.system);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Reasons);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NologoutDetected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No logout Detected";
            this.Load += new System.EventHandler(this.NologoutDetected_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mess;
        private System.Windows.Forms.Label Reasons;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton system;
        private System.Windows.Forms.RadioButton soft;
        private System.Windows.Forms.Button btnSave;
    }
}