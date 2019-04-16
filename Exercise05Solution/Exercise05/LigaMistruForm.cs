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
    public partial class LigaMistruForm : Form
    {
        Hraci hraci;

        private delegate void LogCountChangeHander(uint previousCount, uint newCount);

        private LogCountChangeHander logCountChangeHander = null;

        public LigaMistruForm()
        {
            hraci = new Hraci();
            InitializeComponent();
            RefillFootballersView();
        }

        private void RefillFootballersView()
        {
            dataGridView1.Rows.Clear();
            for (uint i = 0; i < hraci.Count; i++)
            {
                footballersDataGridView.Rows.Add(footballers[i].Name,
                    footballers[i].Club.ToString(),
                    footballers[i].GoalCount.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
