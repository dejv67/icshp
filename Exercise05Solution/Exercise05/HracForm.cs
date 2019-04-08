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
        Hrac vysledekHrac;

        public HracForm()
        {
            vysledekHrac = new Hrac();
            InitializeComponent();
        }

        private void InitializeFootballerUI()
        {
            textBoxJmeno.Text = vysledekHrac.;
            comboBoxKlub.SelectedItem = vysledekHrac.Club;
            textBoxGol.Text = vysledekHrac.GoalCount.ToString();
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
    }
}
