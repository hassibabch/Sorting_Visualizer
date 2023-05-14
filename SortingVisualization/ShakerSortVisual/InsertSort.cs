using System.Threading;

namespace ShakerSortVisual
{
    public class InsertSort : Sort
    {
        private int _currentIndex;
        private Element _key;
        private int _startingKeyIndex;
        private int _delay = 40;

        public InsertSort(int[] array) : base(array)
        {
            _key = new Element(Array[1], 1);
            _startingKeyIndex = 1;
            _currentIndex = 0;
        }

        public override void OneStepOfSort()
        {
            if (_currentIndex >= 0)
            {
                if (_key.Value < Array[_currentIndex])
                {
                    SwapElements(ref Array[_currentIndex], ref Array[_key.Index]);
                    //delete both elements
                    DrawElement(GraphicTools.Black, _key.Index, true);
                    DrawElement(GraphicTools.Black, _currentIndex, true);
                    //draw passed element in white
                    DrawElement(GraphicTools.White, _key.Index);

                    _key.Index = _currentIndex;
                    _currentIndex--;
                    //draw current key element in red
                    DrawElement(GraphicTools.Red, _key.Index);
                }
                else
                {
                    FoundKeysPlace();
                }
            }
            else
            {
                FoundKeysPlace();
            }
        }

        private void FoundKeysPlace()
        {
            //coloring key element because it's place is found
            DrawElement(GraphicTools.Green, _key.Index);
            Thread.Sleep(_delay); //waiting for green to be seen by user, then painting it in white
            DrawElement(GraphicTools.White, _key.Index);
            _startingKeyIndex++;
            _key = new Element(Array[_startingKeyIndex], _startingKeyIndex);
            _currentIndex = _key.Index - 1;
        }
    }
}