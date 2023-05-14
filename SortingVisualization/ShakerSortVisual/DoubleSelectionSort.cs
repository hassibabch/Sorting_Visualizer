using System.Threading;

namespace ShakerSortVisual
{
    public class DoubleSelectionSort : Sort
    {
        private int _firstIndex;
        private int _lastIndex;
        private readonly int _delay = 20;

        public DoubleSelectionSort(int[] array) : base(array)
        {
            _firstIndex = 0;
            _lastIndex = Array.Length - 1;
        }

        public override bool IsArraySorted()
        {
            return IsArraySorted(_firstIndex, _lastIndex);
        }

        public override void OneStepOfSort()
        {
            var smallestElement = new Element(int.MaxValue, -1);
            var biggestElement = new Element(int.MinValue, -1);

            //searching for smallest and biggest element
            for (var i = _firstIndex; i <= _lastIndex; i++)
            {
                if (Array[i] >= biggestElement.Value)
                {
                    biggestElement.Value = Array[i];
                    biggestElement.Index = i;
                }
                if (Array[i] <= smallestElement.Value)
                {
                    smallestElement.Value = Array[i];
                    smallestElement.Index = i;
                }
            }

            int firstValue = Array[_firstIndex];
            int lastValue = Array[_lastIndex];
            int smallestValue = Array[smallestElement.Index];
            int biggestValue = Array[biggestElement.Index];

            if (firstValue == biggestValue && lastValue == smallestValue)
            {
                Array[_firstIndex] = smallestValue;
                Array[_lastIndex] = biggestValue;
            }
            else
            {
                if (firstValue == biggestValue)
                {
                    Array[_lastIndex] = biggestValue;
                    Array[smallestElement.Index] = lastValue;
                    Array[_firstIndex] = smallestValue;
                }
                else if (lastValue == smallestValue)
                {
                    Array[_lastIndex] = biggestValue;
                    Array[_firstIndex] = smallestValue;
                    Array[biggestElement.Index] = firstValue;
                }
                else
                {

                    Array[smallestElement.Index] = firstValue;
                    Array[biggestElement.Index] = lastValue;
                    Array[_firstIndex] = smallestValue;
                    Array[_lastIndex] = biggestValue;

                }
            }

            Show(smallestElement.Index, biggestElement.Index);
            _firstIndex++;
            _lastIndex--;
        }

        private void Show(params int[] changedIndexes)
        {
            //mark elements with colors
            DrawElement(GraphicTools.Red, _firstIndex);
            DrawElement(GraphicTools.Red, _lastIndex);

            foreach (var index in changedIndexes)
            {
                DrawElement(GraphicTools.Green, index);
            }

            Thread.Sleep(_delay); //delay so color change can be seen

            //delete elements
            DrawElement(GraphicTools.Black, _firstIndex, true);
            DrawElement(GraphicTools.Black, _lastIndex, true);

            foreach (var index in changedIndexes)
            {
                DrawElement(GraphicTools.Black, index, true);
            }

            //redraw them in white
            DrawElement(GraphicTools.White, _firstIndex);
            DrawElement(GraphicTools.White, _lastIndex);

            foreach (var index in changedIndexes)
            {
                DrawElement(GraphicTools.White, index);
            }
        }
    }
}