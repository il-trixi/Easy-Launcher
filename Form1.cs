using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Launcher
{
    public partial class Launcher : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Launcher()
        {
            InitializeComponent();
        }



        private void Fortnite_Click(object sender, EventArgs e)
        {
            try
            {
                string fort = @"";

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
                string rocket = @"com.epicgames.launcher://apps/9773aa1aa54f4f7b80e44bef04986cea%3A530145df28a24424923f5828cc9031a1%3ASugar?action=launch&silent=true";
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
                string fivem = @"C:\\Users\\alesj\\AppData\\Local\\FiveM\\FiveM.exe";
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
                string amoung = @"steam://rungameid/945360";
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

        private void button1_Click(object sender, EventArgs e) // close button
        {
            Application.Exit();
        }

        private void Button_web_Click(object sender, EventArgs e)
        {
            Process.Start("www.pabloshop.eu");
        }

        private void pannello_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pannello_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Cod_Click(object sender, EventArgs e)
        {
            string cod = @"";
            Process.Start(cod);
            Application.Exit();
        }

        private void truck_Click(object sender, EventArgs e)
        {
            string truck = @"";
            Process.Start(truck);
            Application.Exit();
        }
    }
}
