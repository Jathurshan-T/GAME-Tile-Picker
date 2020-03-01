using System;
using System.Drawing;
using System.Windows.Forms;

namespace TilePicker
{
    /* Jathurshan Theivikaran
     * November 15, 2018
     * This program allows user to select tiles with randomized colours and see if they win or lose
     */

    public partial class frmTilePicker : Form
    {
        //global variables for changing game values
        Grid Grid = new Grid(8, 8, 40), GridResults = new Grid(8, 8, 20);
        bool ShowResults, Start;
        int Score, ClickedCounter = 10;

        public frmTilePicker()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            //create graphics object
            Graphics g = e.Graphics;

            //draw grid if button has been clicked
            if (Start)
            {
                Grid.Draw(g, 20, 50);
            }

            //draw results grid after each game
            if (ShowResults)
            {
                GridResults.Draw(g, 370, 210);
            }

            //dispose graphics object
            g.Dispose();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //hide second grid
            ShowResults = false;

            //check if button has been clicked
            Start = true;

            //call ResetTiles method
            Grid.ResetTiles(Grid, GridResults);

            //reset form game values
            Score = 0;
            ClickedCounter = 0;
            lblScore.Text = Score.ToString();
            lblClicked.Text = ClickedCounter.ToString();
            lblResults.Visible = false;

            //randomize colour tiles
            Grid.SwitchTiles();

            //refresh form
            this.Refresh();
        }

        private void FrmTilePicker_MouseClick(object sender, MouseEventArgs e)
        {
            //find indexes of width and height of grid
            int X = (e.X - 20) / 40;
            int Y = (e.Y - 50) / 40;

            //check if 10 tiles are not selected and if cursor is clicked within grid
            if (ClickedCounter < 10 && X >= 0 && X < 8 && Y >= 0 && Y < 8)
            {
                //change button text to restart
                btnStart.Text = "RESTART";

                //store which tile is clicked
                Tile Tile = Grid.GetTile(Y + 1, X + 1);
                Tile TileResults = GridResults.GetTile(Y + 1, X + 1);

                //check if tile has not been selected
                if (!Tile.Selected)
                {
                    //add to counter of number of clicked tiles
                    ClickedCounter++;

                    //change tile preoperties and value of score
                    Score = Grid.GetScore(Tile, TileResults);

                    //update form labels
                    lblClicked.Text = ClickedCounter.ToString();
                    lblScore.Text = Score.ToString();

                    //check if exactly 10 tiles have been selected
                    if (ClickedCounter == 10)
                    {
                        //change form for end of game results
                        Grid.GameEnd();
                        
                        //show secondary grid showing all clicked tile colours
                        ShowResults = true;

                        //player wins if score is greater than 30
                        if (Score >= 30)
                        {
                            lblResults.Text = "YOU WIN!";
                        }
                        else
                        {
                            lblResults.Text = "YOU LOSE";
                        }
                        //display results
                        lblResults.Visible = true;
                    }
                    //refresh form
                    this.Refresh();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}