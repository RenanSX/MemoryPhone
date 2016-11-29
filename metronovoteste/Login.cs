using MetroFramework.Forms;
using metronovoteste.metro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metronovoteste
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //metroStyleManager1.BackColor = Color.FromArgb(255, 99, 71); 
            metroPanel2.Location = new Point(
            this.ClientSize.Width / 2 - metroPanel2.Size.Width / 2,
            this.ClientSize.Height / 2 - metroPanel2.Size.Height / 2);
            metroPanel2.Anchor = AnchorStyles.None;
            if (MetroUI.DesignMode == false)
            {
                MetroUI.Style.PropertyChanged += Style_PropertyChanged;
                MetroUI.Style.DarkStyle = true;
            }
        }
        void Style_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "DarkStyle")
            {
                BackColor = MetroUI.Style.BackColor;
                Refresh();
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Tela_Principal principal = new Tela_Principal();
            principal.Show();
            this.Hide();
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

        /// <summary>
        /// support form moving whereever the user clicks inside the form (only for demonstration)
        /// </summary>
        /// <param name="msg"></param>
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x84) // WM_NCHITTEST
                msg.Result = (IntPtr)0x02;  // HTCAPTION
            else
                base.WndProc(ref msg);
        }
    }
}
