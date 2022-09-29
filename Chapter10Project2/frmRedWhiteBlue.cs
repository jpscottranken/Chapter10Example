using System;
using System.Windows.Forms;

namespace Chapter10Project2
{
    public partial class frmRedWhiteBlue : Form
    {
        public frmRedWhiteBlue()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(255, 0, 0);
            //this.Close();
            Form redForm = new frmRed();
            redForm.ShowDialog();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(255, 255, 255);
            //this.Close();
            Form whiteForm = new frmWhite();
            whiteForm.ShowDialog();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, 0, 255);
            //this.Close();
            Form blueForm = new frmBlue();
            blueForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                            "Do You Really Want To Exit?",
                            "EXIT NOW?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmRedWhiteBlue_Load(object sender, EventArgs e)
        {

        }
    }
}
