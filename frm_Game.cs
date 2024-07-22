using System;
using System.Drawing;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class frm_Game : Form
    {
        public frm_Game()
        {
            InitializeComponent();
        }
        private void frm_Game_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);

            Pen pen = new Pen(Black);
            pen.Width = 3;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 270, 80, 270, 290);
            e.Graphics.DrawLine(pen, 340, 80, 340, 290);
            e.Graphics.DrawLine(pen, 200, 150, 410, 150);
            e.Graphics.DrawLine(pen, 200, 220, 410, 220);
        }
        private void frm_Game_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = "Player 1";
        }
        void DisableAllButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        void EnableAllButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        void ResetAllButtons()
        {
            btn1.Tag = 1;
            btn2.Tag = 2;
            btn3.Tag = 3;
            btn4.Tag = 4;
            btn5.Tag = 5;
            btn6.Tag = 6;
            btn7.Tag = 7;
            btn8.Tag = 8;
            btn9.Tag = 9;
        }
        void ShowAllButtons()
        {
            ResetAllButtons();

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = true;
            EnableAllButtons();
        }
        void ResetAllPhotos()
        {
            pc1.Tag = 1;
            pc2.Tag = 2;
            pc3.Tag = 3;
            pc4.Tag = 4;
            pc5.Tag = 5;
            pc6.Tag = 6;
            pc7.Tag = 7;
            pc8.Tag = 8;
            pc9.Tag = 9;
        }
        bool HasGameEnded()
        {
            if (((pc1.Tag.ToString() == pc2.Tag.ToString()) && (pc1.Tag.ToString() == pc3.Tag.ToString())) ||
                ((pc4.Tag.ToString() == pc5.Tag.ToString()) && (pc4.Tag.ToString() == pc6.Tag.ToString())) ||
                ((pc7.Tag.ToString() == pc8.Tag.ToString()) && (pc7.Tag.ToString() == pc9.Tag.ToString())) ||
                ((pc1.Tag.ToString() == pc4.Tag.ToString()) && (pc1.Tag.ToString() == pc7.Tag.ToString())) ||
                ((pc2.Tag.ToString() == pc5.Tag.ToString()) && (pc2.Tag.ToString() == pc8.Tag.ToString())) ||
                ((pc3.Tag.ToString() == pc6.Tag.ToString()) && (pc3.Tag.ToString() == pc9.Tag.ToString())) ||
                ((pc1.Tag.ToString() == pc5.Tag.ToString()) && (pc1.Tag.ToString() == pc9.Tag.ToString())) ||
                ((pc3.Tag.ToString() == pc5.Tag.ToString()) && (pc3.Tag.ToString() == pc7.Tag.ToString())))
                return true;
            return false;
        }
        bool HaveAllButtonsBeenUsed()
        {
            if ((btn1.Visible == false) && (btn2.Visible == false) && (btn3.Visible == false) && (btn4.Visible == false) &&
                (btn5.Visible == false) && (btn6.Visible == false) && (btn7.Visible == false) && (btn8.Visible == false) &&
                (btn9.Visible == false))
                return true;
            return false;
        }
        bool IsDraw()
        {
            if (HaveAllButtonsBeenUsed())
                return true;
            return false;
        }
        void ResetScreen()
        {
            btnExit.Visible = false;
            btnReset.Visible = false;
            lblPlayer.Visible = true;
            label1.Visible = true;
            lblPlayer.Text = lblPlayer.Tag.ToString();
            ShowAllButtons();
            ResetAllPhotos();
        }
        void CheckResult(Button btni)
        {
            if (HasGameEnded())
            {
                lblPlayer.Visible = false;
                label1.Visible = false;
                
                MessageBox.Show(btni.Tag.ToString() + " has won!", "The Game Has Ended"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisableAllButtons();
                btnExit.Visible = true;
                btnReset.Visible = true;
            }
            else if (IsDraw())
            {
                lblPlayer.Visible = false;
                label1.Visible = false;
                
                MessageBox.Show("Draw!", "The Game Has Ended"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DisableAllButtons();
                btnExit.Visible = true;
                btnReset.Visible = true;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1") 
            {
                pc1.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn1.Visible = false;
                pc1.Tag = "O";
                btn1.Tag = "Player 1";
            }
            else
            {
                pc1.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn1.Visible = false;
                pc1.Tag = "X";
                btn1.Tag = "Player 2";
            }

            CheckResult(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc2.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn2.Visible = false;
                pc2.Tag = "O";
                btn2.Tag = "Player 1";
            }
            else
            {
                pc2.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn2.Visible = false;
                pc2.Tag = "X";
                btn2.Tag = "Player 2";
            }

            CheckResult(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc3.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn3.Visible = false;
                pc3.Tag = "O";
                btn3.Tag = "Player 1";
            }
            else
            {
                pc3.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn3.Visible = false;
                pc3.Tag = "X";
                btn3.Tag = "Player 2";
            }

            CheckResult(btn3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc4.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn4.Visible = false;
                pc4.Tag = "O";
                btn4.Tag = "Player 1";
            }
            else
            {
                pc4.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn4.Visible = false;
                pc4.Tag = "X";
                btn4.Tag = "Player 2";
            }

            CheckResult(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc5.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn5.Visible = false;
                pc5.Tag = "O";
                btn5.Tag = "Player 1";
            }
            else
            {
                pc5.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn5.Visible = false;
                pc5.Tag = "X";
                btn5.Tag = "Player 2";
            }

            CheckResult(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc6.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn6.Visible = false;
                pc6.Tag = "O";
                btn6.Tag = "Player 1";
            }
            else
            {
                pc6.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn6.Visible = false;
                pc6.Tag = "X";
                btn6.Tag = "Player 2";
            }

            CheckResult(btn6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc7.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn7.Visible = false;
                pc7.Tag = "O";
                btn7.Tag = "Player 1";
            }
            else
            {
                pc7.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn7.Visible = false;
                pc7.Tag = "X";
                btn7.Tag = "Player 2";
            }

            CheckResult(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc8.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn8.Visible = false;
                pc8.Tag = "O";
                btn8.Tag = "Player 1";
            }
            else
            {
                pc8.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn8.Visible = false;
                pc8.Tag = "X";
                btn8.Tag = "Player 2";
            }

            CheckResult(btn8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblPlayer.Text == "Player 1")
            {
                pc9.Image = Resources.O1;
                lblPlayer.Text = "Player 2";
                btn9.Visible = false;
                pc9.Tag = "O";
                btn9.Tag = "Player 1";
            }
            else
            {
                pc9.Image = Resources.X1;
                lblPlayer.Text = "Player 1";
                btn9.Visible = false;
                pc9.Tag = "X";
                btn9.Tag = "Player 2";
            }

            CheckResult(btn9);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }
    }
}