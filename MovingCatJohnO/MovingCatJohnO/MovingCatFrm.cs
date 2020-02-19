
/*
 * Created by: John Omage
 * Created on:2feb2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program displays a menu strip with a drop-down menu of 2 menu items
 *  When i click on each menu item, the picture in the picture box changes accordingly.
 * when i click on each menu item, the picture in the picture box changes according. when i click on the exit menu item the program closes.
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

namespace MovingCatJohnO
{
    public partial class MovingCatFrm : Form
    {
        public MovingCatFrm()
        {
            InitializeComponent();
        }

        private void Cat1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
            this.picCat.Image = Properties.Resources.cat1;
        }

    

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cat2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void Frank1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.Frank1;
        }

        private void Frank2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.Frank2;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
