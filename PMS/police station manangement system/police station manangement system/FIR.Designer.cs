namespace police_station_manangement_system
{
    partial class FIR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.firub = new System.Windows.Forms.Button();
            this.firvb = new System.Windows.Forms.Button();
            this.fircb = new System.Windows.Forms.Button();
            this.firCU1 = new police_station_manangement_system.firCU();
            this.firU11 = new police_station_manangement_system.firU1();
            this.firV1 = new police_station_manangement_system.firV();
            this.slider = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slider);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.firub);
            this.panel1.Controls.Add(this.firvb);
            this.panel1.Controls.Add(this.fircb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 991);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(22, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 45);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(22, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 45);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(22, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(55, 45);
            this.panel5.TabIndex = 7;
            // 
            // firub
            // 
            this.firub.BackColor = System.Drawing.Color.Transparent;
            this.firub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firub.FlatAppearance.BorderSize = 0;
            this.firub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firub.Location = new System.Drawing.Point(0, 206);
            this.firub.Name = "firub";
            this.firub.Size = new System.Drawing.Size(260, 45);
            this.firub.TabIndex = 6;
            this.firub.Text = "Update";
            this.firub.UseVisualStyleBackColor = false;
            this.firub.Click += new System.EventHandler(this.button2_Click);
            // 
            // firvb
            // 
            this.firvb.BackColor = System.Drawing.Color.Transparent;
            this.firvb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firvb.FlatAppearance.BorderSize = 0;
            this.firvb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firvb.Location = new System.Drawing.Point(0, 365);
            this.firvb.Name = "firvb";
            this.firvb.Size = new System.Drawing.Size(260, 45);
            this.firvb.TabIndex = 5;
            this.firvb.Text = "View";
            this.firvb.UseVisualStyleBackColor = false;
            this.firvb.Click += new System.EventHandler(this.button1_Click);
            // 
            // fircb
            // 
            this.fircb.BackColor = System.Drawing.Color.Transparent;
            this.fircb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fircb.FlatAppearance.BorderSize = 0;
            this.fircb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fircb.Location = new System.Drawing.Point(0, 27);
            this.fircb.Name = "fircb";
            this.fircb.Size = new System.Drawing.Size(260, 45);
            this.fircb.TabIndex = 4;
            this.fircb.Text = "Create";
            this.fircb.UseVisualStyleBackColor = false;
            this.fircb.Click += new System.EventHandler(this.button5_Click);
            // 
            // firCU1
            // 
            this.firCU1.Location = new System.Drawing.Point(266, 0);
            this.firCU1.Name = "firCU1";
            this.firCU1.Size = new System.Drawing.Size(1648, 988);
            this.firCU1.TabIndex = 4;
            this.firCU1.Load += new System.EventHandler(this.firCU1_Load);
            // 
            // firU11
            // 
            this.firU11.Location = new System.Drawing.Point(266, 0);
            this.firU11.Name = "firU11";
            this.firU11.Size = new System.Drawing.Size(1648, 988);
            this.firU11.TabIndex = 5;
            // 
            // firV1
            // 
            this.firV1.Location = new System.Drawing.Point(266, 0);
            this.firV1.Name = "firV1";
            this.firV1.Size = new System.Drawing.Size(1648, 988);
            this.firV1.TabIndex = 6;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.DarkGray;
            this.slider.Location = new System.Drawing.Point(246, 27);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(18, 45);
            this.slider.TabIndex = 14;
            // 
            // FIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firV1);
            this.Controls.Add(this.firU11);
            this.Controls.Add(this.firCU1);
            this.Controls.Add(this.panel1);
            this.Name = "FIR";
            this.Size = new System.Drawing.Size(1934, 991);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fircb;
        private System.Windows.Forms.Button firub;
        private System.Windows.Forms.Button firvb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private firCU firCU1;
        private firU1 firU11;
        private firV firV1;
        private System.Windows.Forms.Panel slider;
    }
}
