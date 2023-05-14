using System.Threading;

namespace ShakerSortVisual
{
    public class BubbleSort : Sort
    {
        private int _delay = 5;
        private int _lastIndex;

        public BubbleSort(int[] array) : base(array)
        {
            _lastIndex = Array.Length - 1;
        }

        public override bool IsArraySorted()
        {
            return IsArraySorted(0, _lastIndex);
        }

        public override void OneStepOfSort()
        {
            for (int i = 0; i < _lastIndex; i++)
            {
                DrawElement(GraphicTools.Red, i);
                DrawElement(GraphicTools.Red, i + 1);
                Thread.Sleep(_delay);
                if (Array[i] > Array[i + 1])
                {
                    SwapElements(ref Array[i], ref Array[i + 1]);

                    //delete elements
                    DrawElement(GraphicTools.Black, i, true);
                    DrawElement(GraphicTools.Black, i + 1, true);

                    //Draw them in green
                    DrawElement(GraphicTools.Green, i);
                    DrawElement(GraphicTools.Green, i + 1);
                    Thread.Sleep(_delay); // for visual effect
                }

                DrawElement(GraphicTools.White, i);
                DrawElement(GraphicTools.White, i + 1);
            }

            _lastIndex--;
        }
    }
}