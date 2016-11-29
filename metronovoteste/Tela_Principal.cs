using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using metronovoteste.metro;
using MetroFramework.Forms;
using metronovoteste.metro;
namespace metronovoteste
{
    public partial class Tela_Principal : MetroForm
    {
        public Tela_Principal()
        {
            InitializeComponent();

            if (MetroUI.DesignMode == false)
            {
                MetroUI.Style.PropertyChanged += Style_PropertyChanged;
                 MetroUI.Style.DarkStyle = true;
            }
            
            this.WindowState = FormWindowState.Maximized;
            
            

        }

        void Style_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
          
            if (e.PropertyName == "DarkStyle")
            {
                BackColor = MetroUI.Style.BackColor;
                Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sEToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void éToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            //this.Dispose();
            

        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x84) // WM_NCHITTEST
                msg.Result = (IntPtr)0x02;  // HTCAPTION
            else
                base.WndProc(ref msg);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(MetroUI.Style.AccentColor))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }

            using (SolidBrush brush = new SolidBrush(MetroUI.Style.AccentColor))
            {
                e.Graphics.DrawString(Text.ToUpper(), MetroUI.Style.LightFont, brush, 10, 8);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        
    }
}
