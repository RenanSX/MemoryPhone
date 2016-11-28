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
            if (e.PropertyName == "WhiteStyle")
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
    }
}
