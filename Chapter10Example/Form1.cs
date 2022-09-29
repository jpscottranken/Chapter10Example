using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] months = { "Select A Monh", 
                                "January", 
                                "February", 
                                "March" };

            foreach (string month in months)
            {
                comboBox1.Items.Add(month);
            }

            radFemale.Checked = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The current index is: " +
                            listBox1.SelectedIndex +
                            "\nThe current item is: " +
                            listBox1.SelectedItem,
                            "LISTBOX INFO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The current index is: " +
                comboBox1.SelectedIndex +
                "\nThe current item is: " +
                comboBox1.SelectedItem,
                "LISTBOX INFO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                MessageBox.Show("The current gender is: " +
                radFemale.Text,
                "FEMALE",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else if (radMale.Checked)
                {
                    MessageBox.Show("The current gender is: " +
                    radMale.Text,
                    "MALE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
        }
    }
}
