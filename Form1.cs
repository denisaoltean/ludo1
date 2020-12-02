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
    public partial class fLudo : Form
    {
        

        public fLudo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form3 inst = new Form3(this);
            inst.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LaunchGame game = new LaunchGame(this);
            game.Show();

            this.Hide();

        }

        private void tbPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayerr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayerrr_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayerrrr_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPlayer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPlayerr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPlayerrr_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbPlayerrrr_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
