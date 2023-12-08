namespace Launcher
{
    partial class Launcher
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Fortnite = new System.Windows.Forms.Button();
            this.Fivem = new System.Windows.Forms.Button();
            this.Amoung = new System.Windows.Forms.Button();
            this.Rocket = new System.Windows.Forms.Button();
            this.TESTO = new System.Windows.Forms.Label();
            this.pannello = new System.Windows.Forms.Panel();
            this.Button_web = new System.Windows.Forms.Button();
            this.chiusura = new System.Windows.Forms.Button();
            this.Cod = new System.Windows.Forms.Button();
            this.truck = new System.Windows.Forms.Button();
            this.pannello.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fortnite
            // 
            this.Fortnite.BackColor = System.Drawing.Color.Transparent;
            this.Fortnite.BackgroundImage = global::Launcher.Properties.Resources.Fortnite;
            this.Fortnite.FlatAppearance.BorderSize = 0;
            this.Fortnite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fortnite.Location = new System.Drawing.Point(77, 287);
            this.Fortnite.Name = "Fortnite";
            this.Fortnite.Size = new System.Drawing.Size(105, 105);
            this.Fortnite.TabIndex = 0;
            this.Fortnite.UseVisualStyleBackColor = false;
            this.Fortnite.Click += new System.EventHandler(this.Fortnite_Click);
            // 
            // Fivem
            // 
            this.Fivem.BackColor = System.Drawing.Color.Transparent;
            this.Fivem.BackgroundImage = global::Launcher.Properties.Resources.fivem;
            this.Fivem.FlatAppearance.BorderSize = 0;
            this.Fivem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Fivem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fivem.Location = new System.Drawing.Point(609, 63);
            this.Fivem.Name = "Fivem";
            this.Fivem.Size = new System.Drawing.Size(105, 105);
            this.Fivem.TabIndex = 1;
            this.Fivem.UseVisualStyleBackColor = false;
            this.Fivem.Click += new System.EventHandler(this.Fivem_Click);
            // 
            // Amoung
            // 
            this.Amoung.BackColor = System.Drawing.Color.Transparent;
            this.Amoung.BackgroundImage = global::Launcher.Properties.Resources.amoung;
            this.Amoung.FlatAppearance.BorderSize = 0;
            this.Amoung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Amoung.Location = new System.Drawing.Point(77, 63);
            this.Amoung.Name = "Amoung";
            this.Amoung.Size = new System.Drawing.Size(105, 105);
            this.Amoung.TabIndex = 2;
            this.Amoung.UseVisualStyleBackColor = false;
            this.Amoung.Click += new System.EventHandler(this.Amoung_Click);
            // 
            // Rocket
            // 
            this.Rocket.BackColor = System.Drawing.Color.Transparent;
            this.Rocket.BackgroundImage = global::Launcher.Properties.Resources.rocket;
            this.Rocket.FlatAppearance.BorderSize = 0;
            this.Rocket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rocket.Location = new System.Drawing.Point(609, 287);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(105, 105);
            this.Rocket.TabIndex = 3;
            this.Rocket.UseVisualStyleBackColor = false;
            this.Rocket.Click += new System.EventHandler(this.Rocket_Click);
            // 
            // TESTO
            // 
            this.TESTO.AutoSize = true;
            this.TESTO.BackColor = System.Drawing.Color.Transparent;
            this.TESTO.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TESTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TESTO.Location = new System.Drawing.Point(240, 36);
            this.TESTO.Name = "TESTO";
            this.TESTO.Size = new System.Drawing.Size(315, 22);
            this.TESTO.TabIndex = 4;
            this.TESTO.Text = "LAUNCHER BY ANONYMOUS";
            this.TESTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pannello
            // 
            this.pannello.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pannello.AllowDrop = true;
            this.pannello.BackColor = System.Drawing.Color.Transparent;
            this.pannello.Controls.Add(this.Button_web);
            this.pannello.Controls.Add(this.chiusura);
            this.pannello.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannello.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pannello.Location = new System.Drawing.Point(0, 0);
            this.pannello.Name = "pannello";
            this.pannello.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pannello.Size = new System.Drawing.Size(784, 33);
            this.pannello.TabIndex = 5;
            this.pannello.Paint += new System.Windows.Forms.PaintEventHandler(this.pannello_Paint);
            this.pannello.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pannello_MouseDown);
            // 
            // Button_web
            // 
            this.Button_web.FlatAppearance.BorderSize = 0;
            this.Button_web.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_web.Image = global::Launcher.Properties.Resources.web__1_;
            this.Button_web.Location = new System.Drawing.Point(0, 0);
            this.Button_web.Name = "Button_web";
            this.Button_web.Size = new System.Drawing.Size(43, 33);
            this.Button_web.TabIndex = 1;
            this.Button_web.UseVisualStyleBackColor = true;
            this.Button_web.Click += new System.EventHandler(this.Button_web_Click);
            // 
            // chiusura
            // 
            this.chiusura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chiusura.FlatAppearance.BorderSize = 0;
            this.chiusura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chiusura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chiusura.Image = global::Launcher.Properties.Resources.close;
            this.chiusura.Location = new System.Drawing.Point(744, 0);
            this.chiusura.Name = "chiusura";
            this.chiusura.Size = new System.Drawing.Size(40, 33);
            this.chiusura.TabIndex = 0;
            this.chiusura.UseVisualStyleBackColor = true;
            this.chiusura.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cod
            // 
            this.Cod.BackColor = System.Drawing.Color.Transparent;
            this.Cod.BackgroundImage = global::Launcher.Properties.Resources.prov__1_;
            this.Cod.FlatAppearance.BorderSize = 0;
            this.Cod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cod.Location = new System.Drawing.Point(609, 176);
            this.Cod.Name = "Cod";
            this.Cod.Size = new System.Drawing.Size(105, 105);
            this.Cod.TabIndex = 4;
            this.Cod.UseVisualStyleBackColor = false;
            this.Cod.Click += new System.EventHandler(this.Cod_Click);
            // 
            // truck
            // 
            this.truck.BackColor = System.Drawing.Color.Transparent;
            this.truck.BackgroundImage = global::Launcher.Properties.Resources.eurotruck;
            this.truck.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.truck.FlatAppearance.BorderSize = 0;
            this.truck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.truck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.truck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.truck.Location = new System.Drawing.Point(77, 176);
            this.truck.Name = "truck";
            this.truck.Size = new System.Drawing.Size(105, 105);
            this.truck.TabIndex = 5;
            this.truck.UseVisualStyleBackColor = false;
            this.truck.Click += new System.EventHandler(this.truck_Click);
            // 
            // Launcher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Launcher.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 508);
            this.Controls.Add(this.truck);
            this.Controls.Add(this.Cod);
            this.Controls.Add(this.pannello);
            this.Controls.Add(this.TESTO);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.Amoung);
            this.Controls.Add(this.Fivem);
            this.Controls.Add(this.Fortnite);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.pannello.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fortnite;
        private System.Windows.Forms.Button Fivem;
        private System.Windows.Forms.Button Amoung;
        private System.Windows.Forms.Button Rocket;
        private System.Windows.Forms.Label TESTO;
        private System.Windows.Forms.Panel pannello;
        private System.Windows.Forms.Button chiusura;
        private System.Windows.Forms.Button Button_web;
        private System.Windows.Forms.Button Cod;
        private System.Windows.Forms.Button truck;
    }
}

