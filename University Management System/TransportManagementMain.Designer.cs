namespace University_Management_System
{
    partial class Transport_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transport_Management_System));
            this.TMlogo = new System.Windows.Forms.Label();
            this.Mtbtn = new System.Windows.Forms.Label();
            this.Teacherbtn = new System.Windows.Forms.Label();
            this.stdntbtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TMlogo
            // 
            this.TMlogo.AutoSize = true;
            this.TMlogo.BackColor = System.Drawing.Color.Transparent;
            this.TMlogo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMlogo.Location = new System.Drawing.Point(228, 9);
            this.TMlogo.Name = "TMlogo";
            this.TMlogo.Size = new System.Drawing.Size(320, 39);
            this.TMlogo.TabIndex = 1;
            this.TMlogo.Text = "Transport Management";
            // 
            // Mtbtn
            // 
            this.Mtbtn.AutoSize = true;
            this.Mtbtn.BackColor = System.Drawing.Color.Transparent;
            this.Mtbtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.Mtbtn.Location = new System.Drawing.Point(39, 119);
            this.Mtbtn.Name = "Mtbtn";
            this.Mtbtn.Size = new System.Drawing.Size(216, 29);
            this.Mtbtn.TabIndex = 2;
            this.Mtbtn.Text = "1.Manager Transport";
            this.Mtbtn.Click += new System.EventHandler(this.label2_Click);
            // 
            // Teacherbtn
            // 
            this.Teacherbtn.AutoSize = true;
            this.Teacherbtn.BackColor = System.Drawing.Color.Transparent;
            this.Teacherbtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.Teacherbtn.Location = new System.Drawing.Point(39, 174);
            this.Teacherbtn.Name = "Teacherbtn";
            this.Teacherbtn.Size = new System.Drawing.Size(103, 29);
            this.Teacherbtn.TabIndex = 3;
            this.Teacherbtn.Text = "2.Teacher";
            this.Teacherbtn.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // stdntbtn
            // 
            this.stdntbtn.AutoSize = true;
            this.stdntbtn.BackColor = System.Drawing.Color.Transparent;
            this.stdntbtn.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic);
            this.stdntbtn.Location = new System.Drawing.Point(39, 226);
            this.stdntbtn.Name = "stdntbtn";
            this.stdntbtn.Size = new System.Drawing.Size(105, 29);
            this.stdntbtn.TabIndex = 4;
            this.stdntbtn.Text = "3.Student";
            this.stdntbtn.Click += new System.EventHandler(this.stdntbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Transport_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.stdntbtn);
            this.Controls.Add(this.Teacherbtn);
            this.Controls.Add(this.Mtbtn);
            this.Controls.Add(this.TMlogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transport_Management_System";
            this.Text = "Transport Managment System";
            this.Load += new System.EventHandler(this.Transport_Management_System_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TMlogo;
        private System.Windows.Forms.Label Mtbtn;
        private System.Windows.Forms.Label Teacherbtn;
        private System.Windows.Forms.Label stdntbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}