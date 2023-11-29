using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Launcher : Form
    {
        private int _ticks;
        public Launcher()
        {
            InitializeComponent();
        }

        private void Fortnite_Click(object sender, EventArgs e)
        {
            try
            {
                string fort = @"C:\\Users\\AppData\\game.exe";

                Process.Start(fort);
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Errore Allo Start");

            }
        }

        private void Rocket_Click(object sender, EventArgs e)
        {
            try
            {
                string rocket = @"C:\\Users\\AppData\\game.exe";
                Process.Start(rocket);
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Errore Allo Start");
            }
        }

        private void Fivem_Click(object sender, EventArgs e)
        {

            try
            {
                string fivem = @"C:\\Users\\AppData\\game.exe";
                Process.Start(fivem);
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Errore Allo Start");
            }

        }

        private void Amoung_Click(object sender, EventArgs e)
        {
            try
            {
                string amoung = @"C:\\Users\\AppData\\game.exe";
                Process.Start(amoung);
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Errore Allo Start");
            }

        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }
    }
}
