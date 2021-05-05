using System.Drawing;

namespace TilePicker
{
    class Tile
    {
        //global variables used as fields
        private int mSize, mBorderThickness, mPoints;
        private Color mBackgroundColour, mBorderColour, mHiddenColour;
        private bool mSelected;

        public Tile(int Size, Color BackgroundColour, Color BorderColour, int BorderThickness, Color HiddenColour, int Points, bool Selected)
        {
            //store values that are passed through method
            this.mSize = Size;
            this.mBackgroundColour = BackgroundColour;
            this.mBorderColour = BorderColour;
            this.mBorderThickness = BorderThickness;
            this.mHiddenColour = HiddenColour;
            this.mPoints = Points;
            this.mSelected = Selected;
        }

        //create properties using set, get
        public int Size
        {
            set { this.mSize = value; }
            get { return this.mSize; }
        }
        public Color BackgroundColour
        {
            set { this.mBackgroundColour = value; }
            get { return this.mBackgroundColour; }
        }
        public Color BorderColour
        {
            set { this.mBorderColour = value; }
            get { return this.mBorderColour; }
        }
        public int BorderThickness
        {
            set { this.mBorderThickness = value; }
            get { return this.mBorderThickness; }
        }
        public Color HiddenColour
        {
            set { this.mHiddenColour = value; }
            get { return this.mHiddenColour; }
        }
        public int Points
        {
            set { this.mPoints = value; }
            get { return this.mPoints; }
        }
        public bool Selected
        {
            set { this.mSelected = value; }
            get { return this.mSelected; }
        }

        public void Draw(Graphics g, int X, int Y)
        {
            //create pen and brush with specific colour and thickness that are passed values
            Pen BorderPen = new Pen(this.mBorderColour, this.mBorderThickness);
            SolidBrush BackBrush = new SolidBrush(this.mBackgroundColour);

            //draw tile
            g.FillRectangle(BackBrush, X, Y, this.mSize, this.mSize);
            g.DrawRectangle(BorderPen, X, Y, this.mSize, this.mSize);

            //dispose drawing tools
            BorderPen.Dispose();
            BackBrush.Dispose();
        }
    }
}