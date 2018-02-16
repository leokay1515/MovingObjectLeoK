/*
 * Leo kay
 * Feb 16, 2018
 * Code: ICS3U
 * This program changes the cat image when the mune item is clicked
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

namespace MovingObject
{
    public partial class frmMovingObject : Form
    {
        public frmMovingObject()
        {
            InitializeComponent();
        }
        //Close the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Change the image to cat1
        private void object1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat1;
        }
        //Change the image to cat2
        private void mniObject2_Click(object sender, EventArgs e)
        {
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
