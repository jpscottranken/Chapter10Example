using System;
using System.Windows.Forms;

namespace Chapter10Project2
{
    public partial class frmBlue : Form
    {
        public frmBlue()
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

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.Close();
            Form whiteForm = new frmWhite();
            whiteForm.ShowDialog();
        }

        private void frmBlue_Load(object sender, EventArgs e)
        {

        }
    }
}
