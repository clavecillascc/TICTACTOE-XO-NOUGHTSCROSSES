namespace TIC_TAC_TOE___A2___Clavecillas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool click = true;

        private void btnR1C1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR1C1.Text = "X";
                click = !click;
                btnR1C1.Enabled = false;
            }
            else
            {
                btnR1C1.Text = "O";
                click = !click;
                btnR1C1.Enabled = false;
            }
            ForWinners();
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR1C2.Text = "X";
                click = !click;
                btnR1C2.Enabled = false;
            }
            else
            {
                btnR1C2.Text = "O";
                click = !click;
                btnR1C2.Enabled = false;
            }
            ForWinners();
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR1C3.Text =  "X";
                click= !click;
                btnR1C3.Enabled = false;
            }
            else
            {
                btnR1C3.Text = "O";
                click = !click;
                btnR1C3.Enabled = false;
            }
            ForWinners();
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR2C1.Text = "X";
                click = !click;
                btnR2C1.Enabled = false;
            }
            else
            {
                btnR2C1.Text = "O";
                click = !click;
                btnR2C1.Enabled = false;
            }
            ForWinners();
        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR2C2.Text = "X";
                click = !click;
                btnR2C2.Enabled = false;
            }
            else
            {
                btnR2C2.Text = "O";
                click = !click;
                btnR2C2.Enabled = false;
            }
            ForWinners();
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR2C3.Text = "X";
                click = !click;
                btnR2C3.Enabled = false;
            }
            else
            {
                btnR2C3.Text = "O";
                click = !click;
                btnR2C3.Enabled = false;
            }
            ForWinners();
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR3C1.Text = "X";
                click = !click;
                btnR3C1.Enabled = false;
            }
            else
            {
                btnR3C1.Text = "O";
                click = !click;
                btnR3C1.Enabled = false;
            }
            ForWinners();
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR3C2.Text = "X";
                click = !click;
                btnR3C2.Enabled = false;
            }
            else
            {
                btnR3C2.Text = "O";
                click = !click;
                btnR3C2.Enabled = false;
            }
            ForWinners();
        }

        private void btnR3C3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                btnR3C3.Text = "X";
                click = !click;
                btnR3C3.Enabled = false;
            }
            else
            {
                btnR3C3.Text = "O";
                click = !click;
                btnR3C3.Enabled = false;
            }
            ForWinners();
        }

        private void ForWinners()
        {
            //HORIZONTAL
            if ((btnR1C1.Text == btnR1C2.Text) && (btnR1C2.Text == btnR1C3.Text))
            {
                click = !click;

                if (click)
                {
                    MessageBox.Show("Player X Wins!");
                }
                else
                {
                    MessageBox.Show("Player O Wins!");
                }
            }
            //HORIZONTAL
            else if ((btnR2C1.Text == btnR2C2.Text) && (btnR2C2.Text == btnR2C3.Text))
            {
                click = !click;

                if (click)
                {
                    MessageBox.Show("Player X Wins!");
                }
                else
                {
                    MessageBox.Show("Player O Wins!");
                }
            }
            //HORIZONTAL
            else if ((btnR3C1.Text == btnR3C2.Text) && (btnR3C2.Text == btnR3C3.Text))
            {
                click = !click;

                if (click)
                {
                    MessageBox.Show("Player X Wins!");
                }
                else
                {
                    MessageBox.Show("Player O Wins!");
                }
            }
        }
    }
}