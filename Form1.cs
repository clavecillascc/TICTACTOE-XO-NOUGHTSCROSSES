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
            }
            else
            {
                btnR1C1.Text = "Y";
                click = !click;
            }
            btnR1C1.Enabled = false;
        }
    }
}