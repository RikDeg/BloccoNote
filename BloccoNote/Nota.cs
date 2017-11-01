using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloccoNote
{
    public partial class Nota : Form
    {
        usrCtrlEditText ctr; 

        public Nota()
        {
            InitializeComponent();
            //Set dimensioni controlli
            ctr = new usrCtrlEditText();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            ctr.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(ctr);
        }

        public Nota(String path)
        {
            InitializeComponent();
            //Set dimensioni controlli
            ctr = new usrCtrlEditText(path);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            ctr.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(ctr);
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuovaNota neu = new nuovaNota();
            neu.Show();
            ctr.salva(Properties.Settings.Default.nomeTemp); //Manca nome file
        }
    }
}
