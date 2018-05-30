namespace Jipp_Strzelnica
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ONasButton = new System.Windows.Forms.Button();
            this.KarnetyButton = new System.Windows.Forms.Button();
            this.TrenerzyButton = new System.Windows.Forms.Button();
            this.StanowiskaButton = new System.Windows.Forms.Button();
            this.BronieButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.home1 = new Jipp_Strzelnica.Home();
            this.oNas1 = new Jipp_Strzelnica.ONas();
            this.bronie1 = new Jipp_Strzelnica.Bronie();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.ONasButton);
            this.panel1.Controls.Add(this.KarnetyButton);
            this.panel1.Controls.Add(this.TrenerzyButton);
            this.panel1.Controls.Add(this.StanowiskaButton);
            this.panel1.Controls.Add(this.BronieButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 586);
            this.panel1.TabIndex = 0;
            // 
            // ONasButton
            // 
            this.ONasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONasButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ONasButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.ONasButton.Image = ((System.Drawing.Image)(resources.GetObject("ONasButton.Image")));
            this.ONasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ONasButton.Location = new System.Drawing.Point(0, 529);
            this.ONasButton.Name = "ONasButton";
            this.ONasButton.Size = new System.Drawing.Size(225, 45);
            this.ONasButton.TabIndex = 10;
            this.ONasButton.Text = " O nas";
            this.ONasButton.UseVisualStyleBackColor = true;
            this.ONasButton.Click += new System.EventHandler(this.OnasButton_Click);
            // 
            // KarnetyButton
            // 
            this.KarnetyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KarnetyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KarnetyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.KarnetyButton.Image = ((System.Drawing.Image)(resources.GetObject("KarnetyButton.Image")));
            this.KarnetyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KarnetyButton.Location = new System.Drawing.Point(0, 316);
            this.KarnetyButton.Name = "KarnetyButton";
            this.KarnetyButton.Size = new System.Drawing.Size(225, 45);
            this.KarnetyButton.TabIndex = 9;
            this.KarnetyButton.Text = "  Karnety";
            this.KarnetyButton.UseVisualStyleBackColor = true;
            this.KarnetyButton.Click += new System.EventHandler(this.KarnetyButton_Click);
            // 
            // TrenerzyButton
            // 
            this.TrenerzyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrenerzyButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrenerzyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.TrenerzyButton.Image = ((System.Drawing.Image)(resources.GetObject("TrenerzyButton.Image")));
            this.TrenerzyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TrenerzyButton.Location = new System.Drawing.Point(0, 265);
            this.TrenerzyButton.Name = "TrenerzyButton";
            this.TrenerzyButton.Size = new System.Drawing.Size(225, 45);
            this.TrenerzyButton.TabIndex = 8;
            this.TrenerzyButton.Text = " Trenerzy";
            this.TrenerzyButton.UseVisualStyleBackColor = true;
            this.TrenerzyButton.Click += new System.EventHandler(this.TrenerzyButton_Click);
            // 
            // StanowiskaButton
            // 
            this.StanowiskaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StanowiskaButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StanowiskaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.StanowiskaButton.Image = ((System.Drawing.Image)(resources.GetObject("StanowiskaButton.Image")));
            this.StanowiskaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StanowiskaButton.Location = new System.Drawing.Point(-3, 214);
            this.StanowiskaButton.Name = "StanowiskaButton";
            this.StanowiskaButton.Size = new System.Drawing.Size(228, 45);
            this.StanowiskaButton.TabIndex = 7;
            this.StanowiskaButton.Text = "    Stanowiska";
            this.StanowiskaButton.UseVisualStyleBackColor = true;
            this.StanowiskaButton.Click += new System.EventHandler(this.StanowiskaButton_Click);
            // 
            // BronieButton
            // 
            this.BronieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BronieButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BronieButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.BronieButton.Image = ((System.Drawing.Image)(resources.GetObject("BronieButton.Image")));
            this.BronieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BronieButton.Location = new System.Drawing.Point(0, 163);
            this.BronieButton.Name = "BronieButton";
            this.BronieButton.Size = new System.Drawing.Size(225, 45);
            this.BronieButton.TabIndex = 6;
            this.BronieButton.Text = " Bronie";
            this.BronieButton.UseVisualStyleBackColor = true;
            this.BronieButton.Click += new System.EventHandler(this.BronieButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 112);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(225, 45);
            this.HomeButton.TabIndex = 5;
            this.HomeButton.Text = " Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(120)))), ((int)(((byte)(78)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 17);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(120)))), ((int)(((byte)(78)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(262, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 100);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(86)))));
            this.label1.Location = new System.Drawing.Point(381, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Najlepsza Strzelnica w Twoim Mieście";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1098, 23);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 44);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.home1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.home1.Location = new System.Drawing.Point(225, 112);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(928, 474);
            this.home1.TabIndex = 5;
            // 
            // oNas1
            // 
            this.oNas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.oNas1.Location = new System.Drawing.Point(225, 112);
            this.oNas1.Name = "oNas1";
            this.oNas1.Size = new System.Drawing.Size(928, 471);
            this.oNas1.TabIndex = 6;
            // 
            // bronie1
            // 
            this.bronie1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(86)))), ((int)(((byte)(69)))));
            this.bronie1.Location = new System.Drawing.Point(225, 112);
            this.bronie1.Name = "bronie1";
            this.bronie1.Size = new System.Drawing.Size(928, 471);
            this.bronie1.TabIndex = 7;
            this.bronie1.Load += new System.EventHandler(this.bronie1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 586);
            this.Controls.Add(this.bronie1);
            this.Controls.Add(this.oNas1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strzelnica";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button KarnetyButton;
        private System.Windows.Forms.Button TrenerzyButton;
        private System.Windows.Forms.Button StanowiskaButton;
        private System.Windows.Forms.Button BronieButton;
        private System.Windows.Forms.Button ONasButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private Home home1;
        private ONas oNas1;
        private Bronie bronie1;
    }
}

