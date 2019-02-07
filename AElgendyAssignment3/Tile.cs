/*Assignment 3
 * Game Programming
 * TIC TAC TOE
 * Revision History
 * Created by:Azza Elgendy
 * Section 1
 * created on November 15th 
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

namespace AElgendyAssignment3
{   /// <summary>
    /// tile class gives picturebox prop.
    /// </summary>
    class Tile : PictureBox
    {
        /// <summary>
        ///  class variables
        /// </summary>
        private const int WIDTH = 70;
        private const int HEIGHT = 70;
        public int Row { get; set; }
        public int Col { get; set; }
        public int pictureIndex { get; set; } = 0;
        /// <summary>
        /// class constructor
        /// </summary>
        public Tile()
        {
            this.Width = WIDTH;
            this.Height = HEIGHT;
            this.Visible = true;
            this.BorderStyle
                = BorderStyle.FixedSingle;
            this.SizeMode
                = PictureBoxSizeMode.Zoom;//fit photo
            this.BringToFront();
        }
        /// <summary>
        /// function switch the images
        /// </summary>
        /// <param name="PictureIndex">Control the required picture</param>
        public void TileIndex(int PictureIndex)
        {
            this.pictureIndex = PictureIndex;
            //assign picture to picturebox
            switch (pictureIndex)
            {
                case 0:
                    if (this.Image != null)
                    {
                        this.Image.Dispose();
                        this.Image = null;
                    }
                    break;
                case 2:
                    if (this.Image == null)
                    {
                        this.Image = Properties.Resources.O;
                    }
                    break;
                case 1:
                    if (this.Image == null)
                    {
                        this.Image = Properties.Resources.X;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
