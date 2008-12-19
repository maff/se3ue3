using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A2
{
    public partial class MainWindow : Form
    {
        private Komplex erg = new Komplex(0, 0);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Komplex z1 = new Komplex(tbRE1.Text, tbIM1.Text);
            Komplex z2 = new Komplex(tbRE2.Text, tbIM2.Text);

            this.erg = z1 + z2;
            tbErg.Text = this.erg.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Komplex z1 = new Komplex(tbRE1.Text, tbIM1.Text);
            Komplex z2 = new Komplex(tbRE2.Text, tbIM2.Text);

            this.erg = z1 - z2;
            tbErg.Text = this.erg.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Komplex z1 = new Komplex(tbRE1.Text, tbIM1.Text);
            Komplex z2 = new Komplex(tbRE2.Text, tbIM2.Text);

            this.erg = z1 * z2;
            tbErg.Text = this.erg.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Komplex z1 = new Komplex(tbRE1.Text, tbIM1.Text);
            Komplex z2 = new Komplex(tbRE2.Text, tbIM2.Text);

            this.erg = z1 / z2;
            tbErg.Text = this.erg.ToString();
        }

        private void rbKart_CheckedChanged(object sender, EventArgs e)
        {
            Komplex.displayExponential = false;
            tbErg.Text = this.erg.ToString();
        }

        private void rbExp_CheckedChanged(object sender, EventArgs e)
        {
            Komplex.displayExponential = true;
            tbErg.Text = this.erg.ToString();
        }
    }
}
