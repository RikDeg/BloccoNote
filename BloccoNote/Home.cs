using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloccoNote
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
        }


        private void cambiaImpostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impostazioni imp = new Impostazioni();
            imp.Show();
        }
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Show(this, Control.MousePosition);
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("DX");
            }
        }

        private void elencoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nota nt = new Nota();
            nt.Show();
        }

        private void elencoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fil = Directory.GetFiles(Properties.Settings.Default.PercorsoNote);
                for(int i=0;i<fil.Length;i++)
                {
                    Lista.Items.Add(fil[i]);
                }
                Lista.Show(this,Control.MousePosition);
            }
            catch { }
        }

        private void Lista_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Nota nn = new Nota(e.ClickedItem.ToString());
            //MessageBox.Show(e.ClickedItem.ToString());
            nn.Show();
        }
    }
}
