/*
 * Created by: John Omage
 * Created on: 18-feb-2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program that has a group box with two labels representing and mascot. 
 * When you click on the menu item, the school and mascot changes accordingly. 
 * I also learned the difference  between the assignment "=" operator and the comparison "==" operator.
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

namespace PictureChangingJohnO
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SchoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPicture_Load(object sender, EventArgs e)
        {

        }

        private void MotherTeresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change the labels to reflect Mother teresa
            this.lblSchool.Text = "Mother teresa";
            this.lblMascot.Text = "Spartan";
        }
        private void LblPicture_Click(object sender, EventArgs e)
        {

        }

        private void StMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change the labels to reflect St mark
            this.lblSchool.Text = "StMarks";
            this.lblMascot.Text = "Lion";
        }

        private void ImmaculataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change the labels to reflect Immaculata
            this.lblSchool.Text = "Immaculata";
            this.lblMascot.Text = "Saints";
        }
    }
}
