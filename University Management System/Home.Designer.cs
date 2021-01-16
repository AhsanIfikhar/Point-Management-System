namespace University_Management_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lbl1 = new System.Windows.Forms.Label();
            this.TransportIcon = new System.Windows.Forms.PictureBox();
            this.Transportlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransportIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(285, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(443, 63);
            this.lbl1.TabIndex = 1;
            this.lbl1.Tag = "";
            this.lbl1.Text = "University Management System";
            // 
            // TransportIcon
            // 
            this.TransportIcon.BackColor = System.Drawing.Color.Transparent;
            this.TransportIcon.Image = ((System.Drawing.Image)(resources.GetObject("TransportIcon.Image")));
            this.TransportIcon.Location = new System.Drawing.Point(449, 150);
            this.TransportIcon.Name = "TransportIcon";
            this.TransportIcon.Size = new System.Drawing.Size(200, 200);
            this.TransportIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TransportIcon.TabIndex = 2;
            this.TransportIcon.TabStop = false;
            this.TransportIcon.Click += new System.EventHandler(this.TransportIcon_Click);
            // 
            // Transportlbl
            // 
            this.Transportlbl.AutoSize = true;
            this.Transportlbl.BackColor = System.Drawing.Color.Transparent;
            this.Transportlbl.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Transportlbl.Location = new System.Drawing.Point(445, 357);
            this.Transportlbl.Name = "Transportlbl";
            this.Transportlbl.Size = new System.Drawing.Size(251, 23);
            this.Transportlbl.TabIndex = 5;
            this.Transportlbl.Text = "Transport Management System";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.Transportlbl);
            this.Controls.Add(this.TransportIcon);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "University Managment System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransportIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox TransportIcon;
        private System.Windows.Forms.Label Transportlbl;
    }
}

