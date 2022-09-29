using System;
using System.Windows.Forms;

namespace Chapter10Project2
{
    public partial class frmWhite : Form
    {
        public frmWhite()
        {
            InitializeComponent();
        }

        private void btmHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Form homeForm = new frmRedWhiteBlue();
            homeForm.ShowDialog();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.Close();
            Form redForm = new frmRed();
            redForm.ShowDialog();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.Close();
            Form blueForm = new frmBlue();
            blueForm.ShowDialog();
        }

        private void frmWhite_Load(object sender, EventArgs e)
        {

        }
    }
}
