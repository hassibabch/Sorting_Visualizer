using System.Drawing;
using System.Windows.Forms;

namespace ShakerSortVisual
{
    public class GraphicTools //used to store everything needed for drawing elements inside sorting classes
    {
        public Graphics @Graphics { get; set; }
        public PictureBox @PictureBox { get; set; }
        public int ElementThickness { get; set; }
        public int HeightDifference { get; set; }

        public Pen White { get; }
        public Pen Black { get; }
        public Pen Red { get; }
        public Pen Green { get; }

        public GraphicTools(int elementThickness) //elementThickness must be passed because its default value iz zero, and it gets passed to Pens before getting value by getter
        {
            ElementThickness = elementThickness;
            White = new Pen(Color.White, ElementThickness - 1);
            Black = new Pen(Color.Black, ElementThickness - 1);
            Red = new Pen(Color.Red, ElementThickness - 1);
            Green = new Pen(Color.LimeGreen, ElementThickness - 1);
        }

    }
}