using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo
{
    public partial class LaunchGame : Form
    {
        Form lnc;

        int nrRand;

       // Random random = new Random();
        Piesa piesa = new Piesa();

        public LaunchGame(Form launcher)
        {

            lnc = launcher;
            InitializeComponent();
            pion1.Left = 400;
        }

        public LaunchGame() { }

        private void btnPush_Click(object sender, EventArgs e)
        {
            


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*nrRand = random.Next(1, 7);

            if (nrRand == 1)
                game.lDice.Text = "1";


            if (nrRand == 2)
                game.lDice.Text = "2";
            if (nrRand == 3)
                game.lDice.Text = "3";
            if (nrRand == 4)
                game.lDice.Text = "4";
            if (nrRand == 5)
                game.lDice.Text = "5";
            if (nrRand == 6)
                game.lDice.Text = "6";*/
             piesa.daCuZarul();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            lnc.Show();
        }

        private void pion1_Click(object sender, EventArgs e)
        {

        }

      

        private void LaunchGame_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }
    }
}
