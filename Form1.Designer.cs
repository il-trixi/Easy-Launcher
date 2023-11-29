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
            this.SuspendLayout();
            // 
            // Fortnite
            // 
            this.Fortnite.BackgroundImage = global::Launcher.Properties.Resources.Fortnite;
            this.Fortnite.Location = new System.Drawing.Point(77, 287);
            this.Fortnite.Name = "Fortnite";
            this.Fortnite.Size = new System.Drawing.Size(105, 105);
            this.Fortnite.TabIndex = 0;
            this.Fortnite.UseVisualStyleBackColor = true;
            this.Fortnite.Click += new System.EventHandler(this.Fortnite_Click);
            // 
            // Fivem
            // 
            this.Fivem.BackgroundImage = global::Launcher.Properties.Resources.fivem;
            this.Fivem.Location = new System.Drawing.Point(609, 63);
            this.Fivem.Name = "Fivem";
            this.Fivem.Size = new System.Drawing.Size(105, 105);
            this.Fivem.TabIndex = 1;
            this.Fivem.UseVisualStyleBackColor = true;
            this.Fivem.Click += new System.EventHandler(this.Fivem_Click);
            // 
            // Amoung
            // 
            this.Amoung.BackgroundImage = global::Launcher.Properties.Resources.amoung;
            this.Amoung.Location = new System.Drawing.Point(77, 63);
            this.Amoung.Name = "Amoung";
            this.Amoung.Size = new System.Drawing.Size(105, 105);
            this.Amoung.TabIndex = 2;
            this.Amoung.UseVisualStyleBackColor = true;
            this.Amoung.Click += new System.EventHandler(this.Amoung_Click);
            // 
            // Rocket
            // 
            this.Rocket.BackgroundImage = global::Launcher.Properties.Resources.rocket;
            this.Rocket.Location = new System.Drawing.Point(609, 287);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(105, 105);
            this.Rocket.TabIndex = 3;
            this.Rocket.UseVisualStyleBackColor = true;
            this.Rocket.Click += new System.EventHandler(this.Rocket_Click);
            // 
            // TESTO
            // 
            this.TESTO.AutoSize = true;
            this.TESTO.BackColor = System.Drawing.Color.Transparent;
            this.TESTO.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.TESTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TESTO.Location = new System.Drawing.Point(240, 36);
            this.TESTO.Name = "TESTO";
            this.TESTO.Size = new System.Drawing.Size(321, 26);
            this.TESTO.TabIndex = 4;
            this.TESTO.Text = "LAUNCHER BY ANONYMOUS";
            this.TESTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.sfond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TESTO);
            this.Controls.Add(this.Rocket);
            this.Controls.Add(this.Amoung);
            this.Controls.Add(this.Fivem);
            this.Controls.Add(this.Fortnite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fortnite;
        private System.Windows.Forms.Button Fivem;
        private System.Windows.Forms.Button Amoung;
        private System.Windows.Forms.Button Rocket;
        private System.Windows.Forms.Label TESTO;
    }
}

