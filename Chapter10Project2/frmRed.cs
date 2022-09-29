using System;
using System.Windows.Forms;

namespace Chapter10Project2
{
    public partial class frmRed : Form
    {
        public frmRed()
        {
            InitializeComponent();
        }

        private void btmHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form homeForm = new frmRedWhiteBlue();
            homeForm.ShowDialog();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.Close();
            Form whiteForm = new frmWhite();
            whiteForm.ShowDialog();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.Close();
            Form blueForm = new frmBlue();
            blueForm.ShowDialog();
        }

        private void frmRed_Load(object sender, EventArgs e)
        {

        }
    }
}
