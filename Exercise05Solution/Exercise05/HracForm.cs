using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise05
{
    public partial class HracForm : Form
    {
        Hrac hrac;

        public HracForm()
        {
            hrac = new Hrac();
            InitializeComponent();
            InitializeHrac();
        }

        public HracForm(Hrac hrac)
        {
            this.hrac = hrac;
            InitializeComponent();
            InitializeHrac();
        }

       
        private void InitializeHrac()
        {
            textBoxJmeno.Text = hrac.getJmeno();
            comboBoxKlub.SelectedItem = hrac.getKlub();
            textBoxGol.Text = hrac.getGolPocet().ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HracForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            hrac.setJmeno(textBoxJmeno.Text);
            hrac.setKlub((FotbalovyKlub) comboBoxKlub.SelectedItem);
            int pocetGolu;
            int.TryParse(textBoxGol.Text, out pocetGolu);
            hrac.setGolPocet(pocetGolu);
        }

        private void btnStorno_Click(object sender, EventArgs e)
        {
            if (sender is Form form && form.DialogResult == DialogResult.Cancel)
                return;
            if (textBoxJmeno.Text.Length == 0)
            {
               
            }
        }
    }
}
