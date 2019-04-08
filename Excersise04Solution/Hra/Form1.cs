using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();

        public Form1()
        {
            stats.UpdatedStats += new UpdatedStatsEventHandler(delegate (Object o, EventArgs a)
            {
                correctLabel.Text = $"Correct: {stats.Correct}";
                missedLabel.Text = $"Missed: {stats.Missed}";
                accurancyLabel.Text = $"Accurancy: {stats.Accurancy}%";
            });


            InitializeComponent();
        }

        private void difficultyLabel_Click(object sender, EventArgs e)
        {

        }

        private void correctLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (gameListBox.Items.Count == 6)
                {
                    Timer.Stop();
                    MessageBox.Show("Game over!");
                }
                else
                {
                    gameListBox.Items.Add((Keys)random.Next(65, 91));
               
            }
            
        }

        private void gameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            bool correctKey = gameListBox.Items.Contains(e.KeyCode);
            if (correctKey)
            {
                gameListBox.Items.Remove(e.KeyCode);
                gameListBox.Refresh();
            }
            stats.Update(correctKey);
        }
    }
}
