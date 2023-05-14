using System.Drawing;

namespace ShakerSortVisual
{
    public abstract class Sort
    {
        protected int[] Array;
        protected GraphicTools GraphicTools;

        public GraphicTools GraphicTool
        {
            set => GraphicTools = value;
        }

        protected Sort(int[] array)
        {
            Array = array;
        }

        public abstract void OneStepOfSort();

        public virtual bool IsArraySorted()
        {
            return IsArraySorted(0, Array.Length - 1);
        }

        protected bool IsArraySorted(int from, int to)
        {
            for (var i = from; i < to; i++)
            {
                if (Array[i] > Array[i + 1])
                    return false;
            }

            return true;
        }

        protected void SwapElements<T>(ref T element1, ref T element2)
        {
            var help = element1;
            element1 = element2;
            element2 = help;

        }
        public void DrawElement(Pen pen, int index, bool delete = false)
        {
            if (!delete)
            {
                GraphicTools.Graphics.DrawLine(pen, (index + 0.5f) * GraphicTools.ElementThickness, GraphicTools.PictureBox.Height - Array[index] * GraphicTools.HeightDifference,
                    (index + 0.5f) * GraphicTools.ElementThickness, GraphicTools.PictureBox.Height);
            }
            else //drawing over whole line(this should be done with black)
            {
                GraphicTools.Graphics.DrawLine(pen, (index + 0.5f) * GraphicTools.ElementThickness, 0,
                    (index + 0.5f) * GraphicTools.ElementThickness, GraphicTools.PictureBox.Height);

            }
        }
    }
}