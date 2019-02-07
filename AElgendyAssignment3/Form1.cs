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
/// <summary>
///  tic tac toe game
/// </summary>
namespace AElgendyAssignment3
{   /// <summary>
    /// player turn based game
    /// </summary>
    public partial class Form1 : Form
    {/// <summary>
     /// Declaration of the global variables
     /// </summary>
        public int pictureIndex = 1;
        int counter = 0;
        public int x;
        public int y;
        public int VGAP;
        bool noWins = false;
        //array of pictureboxes
        Tile[,] pictureBoxMatrix;
        public const int numberOfGrid = 3;
        /// <summary>
        /// intialize the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// will remove the grid from the form
        /// in case of tie or win
        /// </summary>
        public void RemoveGrid()
        {
            pictureIndex = 1;//reset the picture index

            for (int i = 0; i < numberOfGrid; i++)
            {
                for (int j = 0; j < numberOfGrid; j++)
                {
                    this.Controls.Remove(pictureBoxMatrix[i, j]);
                }
            }
            counter = 0;
        }
        /// <summary>
        /// Excutes when player wins
        /// check the winner
        /// </summary>
        public void TheWinner()
        {

            if (pictureIndex == 2)
            {
                MessageBox.Show("Player X Wins");
                RemoveGrid();
                GetImage();
                return;
            }
            if (pictureIndex == 1)
            {
                MessageBox.Show("Player O Wins");
                RemoveGrid();
                GetImage();
                return;
            }

        }
        /// <summary>
        /// Excutes when tie
        /// reset the game
        /// </summary>
        public void noWinner()
        {
            DialogResult r =
                MessageBox.Show(" TIE ! Do you want to play again", "No Winner"
                , MessageBoxButtons.YesNo);
            switch (r)
            {
                case DialogResult.Yes:
                    RemoveGrid();
                    GetImage();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
                default:
                    break;
            }

        }
        /// <summary>
        /// create the game grid 
        /// </summary>
        public void GetImage()
        {
            //declaring local variables
            x = 70;
            y = 70;
            VGAP = 100;
            counter = 0;
            txtPlayerTurn.Text = "Player 1 Start";
            btnPlayer2On.BackColor = Color.Red;
            btnPlayer1On.BackColor = Color.Green;
            try
            {
                pictureBoxMatrix = new Tile[numberOfGrid, numberOfGrid];
                try
                {
                    for (int i = 0; i < numberOfGrid; i++)
                    {
                        for (int j = 0; j < numberOfGrid; j++)
                        {
                            pictureBoxMatrix[i, j] = new Tile();
                            pictureBoxMatrix[i, j].Location
                                = new Point(i * x + VGAP, j * x + y);
                            //generate the click event for the picturebox
                            pictureBoxMatrix[i, j].Click += PictureBox_Click;

                            this.Controls.Add(pictureBoxMatrix[i, j]);

                        }
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error in creating the Game "
                        + ex.Message);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
        /// <summary>
        /// all the game events
        /// excutes when the picturebox clicked
        /// </summary>
        /// <param name="sender">tile</param>
        /// <param name="e"></param>
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //tile class is the sender
            Tile tile = new Tile();
            tile = (Tile)sender;
            //put the image inside the tile
            tile.TileIndex(pictureIndex);
            pictureIndex++;
            counter++;
            //check the picture index rest if needed
            if (pictureIndex > 2)
            {
                pictureIndex = 1;
            }
            //remove the click event so the player cannot change his move
            if (tile.Image != null)
            {
                tile.Click -= PictureBox_Click;
            }
            //checking the win situation 
            if (pictureBoxMatrix[0, 0].pictureIndex
                == pictureBoxMatrix[0, 1].pictureIndex
                && pictureBoxMatrix[0, 2].pictureIndex
                == pictureBoxMatrix[0, 0].pictureIndex
                && pictureBoxMatrix[0, 0].Image != null
                )
            {
                TheWinner();
                return;
            }
            if (pictureBoxMatrix[1, 0].pictureIndex
                    == pictureBoxMatrix[1, 1].pictureIndex
                    && pictureBoxMatrix[1, 2].pictureIndex
                    == pictureBoxMatrix[1, 0].pictureIndex
                    && pictureBoxMatrix[1, 0].Image != null
                    )
            {
                TheWinner();
                return;
            }

            if (pictureBoxMatrix[2, 0].pictureIndex
                == pictureBoxMatrix[2, 1].pictureIndex
                && pictureBoxMatrix[2, 2].pictureIndex
                == pictureBoxMatrix[2, 0].pictureIndex
                && pictureBoxMatrix[2, 0].Image != null
                )
            {
                TheWinner();
                return;
            }

            if (pictureBoxMatrix[0, 0].pictureIndex
                == pictureBoxMatrix[1, 0].pictureIndex
                && pictureBoxMatrix[2, 0].pictureIndex
                == pictureBoxMatrix[0, 0].pictureIndex
                && pictureBoxMatrix[0, 0].Image != null
                )
            {
                TheWinner();
                return;
            }
            if (pictureBoxMatrix[0, 1].pictureIndex
                == pictureBoxMatrix[1, 1].pictureIndex
                && pictureBoxMatrix[2, 1].pictureIndex
                == pictureBoxMatrix[0, 1].pictureIndex
                && pictureBoxMatrix[0, 1].Image != null
                )
            {
                TheWinner();
                return;
            }

            if (pictureBoxMatrix[0, 2].pictureIndex
                == pictureBoxMatrix[1, 2].pictureIndex
                && pictureBoxMatrix[2, 2].pictureIndex
                == pictureBoxMatrix[0, 2].pictureIndex
                && pictureBoxMatrix[0, 2].Image != null
                )
            {
                TheWinner();
                return;
            }
            if (pictureBoxMatrix[0, 0].pictureIndex
                == pictureBoxMatrix[1, 1].pictureIndex
                && pictureBoxMatrix[2, 2].pictureIndex
                == pictureBoxMatrix[0, 0].pictureIndex
                && pictureBoxMatrix[0, 0].Image != null
                )
            {
                TheWinner();
                return;
            }
            if (pictureBoxMatrix[2, 0].pictureIndex
                == pictureBoxMatrix[1, 1].pictureIndex
                && pictureBoxMatrix[0, 2].pictureIndex
                == pictureBoxMatrix[2, 0].pictureIndex
                && pictureBoxMatrix[2, 0].Image != null
                )
            {
                TheWinner();
                return;
            }
            //check the player turn
            if (counter % 2 == 0)
            {
                btnPlayer2On.BackColor = Color.Red;
                btnPlayer1On.BackColor = Color.Green;
                txtPlayerTurn.Text = "Player 1 Turn";

            }
            
            if (counter % 2 != 0)
            {
                btnPlayer1On.BackColor = Color.Red;
                btnPlayer2On.BackColor = Color.Green;
                txtPlayerTurn.Text = "Player 2 Turn";
            }
            //check the tie 
            if (noWins == false && counter == 9)
            {
                noWinner();
            }
        }
        /// <summary>
        /// create the game grid on the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

            GetImage();

        }


    }
}
