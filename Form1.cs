using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Game_Click(object sender, EventArgs e)
        {
            Form frm_Game = new frm_Game();
            frm_Game.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
