/*
 * Created by: Jadon Fournier
 * Created on: 7-Mar-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #11 - NumberGuessing
 * This program allows you to try and guess a hidden number.
*/
   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessing
{
    public partial class frmNumberGuessing : Form
    {
        // Set variable and constants
        const double Number = 3;
        double Input;

        public frmNumberGuessing()
        {
            InitializeComponent();

            //Hide labels
            this.lblAnswer.Hide();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            Input = Convert.ToDouble(txtInput.Text);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Input == Number)
            {
                lblAnswer.Text = "That is correct!";
            }

            else
            {
                lblAnswer.Text = "Incorrect!";
            }

            this.lblAnswer.Show();
        }
    }
}
