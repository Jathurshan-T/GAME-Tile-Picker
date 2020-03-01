using System;
using System.Drawing;

namespace TilePicker
{
    class Grid
    {
        //global variables used as fields
        private Tile[,] mGrid;
        int mRows, mColumns, mCellSize, mScore;

        public Grid(int Rows, int Columns, int CellSize)
        {
            {
                //store dimensional values of grid
                this.mRows = Rows;
                this.mColumns = Columns;
                this.mCellSize = CellSize;

                //create grid
                mGrid = new Tile[mRows, mColumns];

                //use counter to store intervals of colours at different indexes
                int ColourCounter = 0;

                //loop through each tile of grid
                for (int i = 0; i < mRows; i++)
                {
                    for (int j = 0; j < mColumns; j++)
                    {
                        //change colour of tile at specific intervals of indexes
                        if (ColourCounter < 20)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Red, 1, false);
                        }
                        else if (ColourCounter >= 20 && ColourCounter < 40)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Blue, 2, false);
                        }
                        else if (ColourCounter >= 40 && ColourCounter < 45)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Green, 3, false);
                        }
                        else if (ColourCounter >= 45 && ColourCounter < 50)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Maroon, 5, false);
                        }
                        else if (ColourCounter >= 50 && ColourCounter < 54)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Aqua, 10, false);
                        }
                        else if (ColourCounter >= 54 && ColourCounter < 59)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.SaddleBrown, -1, false);
                        }
                        else if (ColourCounter >= 59 && ColourCounter < 64)
                        {
                            this.mGrid[i, j] = new Tile(mCellSize, Color.Black, Color.White, 1, Color.Black, -3, false);
                        }
                        ColourCounter++;
                    }
                }
                //randomize tiles in grid
                SwitchTiles();
            }
        }

        public Tile GetTile(int Row, int Column)
        {
            //find tile from the grid
            return mGrid[Row - 1, Column - 1];
        }

        public void Draw(Graphics g, int X, int Y)
        {
            //draw grid starting from inputted location
            int pX = X;
            int pY = Y;

            //loop through each row and column to draw tile
            for (int i = 0; i < mRows; i++)
            {
                //change height of tile
                pY = Y + (i * this.mCellSize);
                for (int j = 0; j < mColumns; j++)
                {
                    //change width of tile
                    pX = X + (j * this.mCellSize);

                    //draw tiles
                    mGrid[i, j].Draw(g, pX, pY);
                }
            }
        }

        public void SwitchTiles()
        {
            //create random generator
            Random Switch = new Random();

            //store random index values to switch tiles
            int SwitchRow, SwitchColumn;

            //loop randomizing algorithm 3 times
            for (int i = 0; i < 5; i++)
            {
                //loop through each tile of grid
                for (int j = 0; j < mRows; j++)
                {
                    for (int k = 0; k < mColumns; k++)
                    {
                        //find random tile in grid
                        SwitchRow = Switch.Next(0, 8);
                        SwitchColumn = Switch.Next(0, 8);

                        //switch current tile with random tile
                        Tile Temp = this.mGrid[j, k];
                        this.mGrid[j, k] = this.mGrid[SwitchRow, SwitchColumn];
                        this.mGrid[SwitchRow, SwitchColumn] = Temp;
                    }
                }
            }
        }

        public void ResetTiles(Grid mGrid, Grid mGridResults)
        {
            //reset Score variable in this class
            mScore = 0;

            //loop through each tile of grid
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    //reset properties of tiles of both grids
                    Tile mTile = mGrid.GetTile(i + 1, j + 1);
                    Tile mTileResults = mGridResults.GetTile(i + 1, j + 1);

                    //reset properties of tiles
                    mTile.BackgroundColour = Color.Black;
                    mTile.BorderColour = Color.White;
                    mTile.BorderThickness = 1;
                    mTile.Selected = false;
                    mTileResults.BackgroundColour = Color.DarkGray;
                    mTileResults.BorderColour = Color.White;
                }
            }
        }

        public int GetScore(Tile mTile, Tile mTileResults)
        {
            //change properties of tiles
            mTile.Selected = true;
            mTile.BorderThickness = 5;
            mTile.BorderColour = Color.Yellow;
            mTile.BackgroundColour = mTile.HiddenColour;
            mTileResults.BackgroundColour = mTile.HiddenColour;

            //add points from tile to score
            mScore += mTile.Points;

            //return score value
            return mScore;
        }

        public void GameEnd()
        {
            //loop through each of the tiles
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    //store which tile is clicked
                    Tile mTile = GetTile(i + 1, j + 1);

                    //show colour of tile
                    mTile.BackgroundColour = mTile.HiddenColour;

                    //decrease border thickness if tile has not been selected
                    if (!mTile.Selected)
                    {
                        mTile.BorderThickness = 0;
                    }
                }
            }
        }
    }
}
