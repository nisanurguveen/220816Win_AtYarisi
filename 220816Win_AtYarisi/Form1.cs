using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220816Win_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            AtDurumDegistir(true);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled
                = atRuzgarGrubu.Enabled = atYagız.Enabled = false;
        }
        void AtDurumDegistir(bool durum, PictureBox at)
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled
                = atRuzgarGrubu.Enabled = atYagız.Enabled = durum;
            at.Enabled = true;

        }
        void AtDurumDegistir(bool durum)
        {
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled
                = atRuzgarGrubu.Enabled = atYagız.Enabled = durum;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            atYagız.Left += rnd.Next(1, 5);
            atRuzgarGrubu.Left += rnd.Next(1, 5);
            atPoyraz.Left += rnd.Next(1, 5);
            atGolgeYele.Left += rnd.Next(1, 5);
            atAlver.Left += rnd.Next(1, 5);

            KimKazandi(atYagız);
            KimKazandi(atRuzgarGrubu);
            KimKazandi(atGolgeYele);
            KimKazandi(atPoyraz);
            KimKazandi(atAlver);
        }
        void KimKazandi(PictureBox kazanan)
        {
            if (kazanan.Right-20>=label1.Left)
            {
                timer1.Stop();
                AtDurumDegistir(false, atYagız);
                MessageBox.Show(kazanan.Name);
            }
        }
    }
}
