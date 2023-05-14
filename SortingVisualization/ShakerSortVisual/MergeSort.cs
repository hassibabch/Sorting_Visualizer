using System.Threading;

namespace ShakerSortVisual
{
    public class MergeSort : Sort
    {
        private int _delay = 5;

        public MergeSort(int[] array) : base(array)
        {

        }

        public override void OneStepOfSort()
        {
            Sort(0, Array.Length - 1);
        }

        private void Merge(int start, int mid, int end)
        {
            int left = start;
            int right = mid + 1;
            int[] helpArray = new int[end - start + 1];
            int index = 0;

            for (int i = start; i <= end; i++)
            {
                if (right > end)
                {
                    helpArray[index++] = Array[left++];
                }
                else if (left > mid)
                {
                    helpArray[index++] = Array[right++];
                }
                else if (Array[right] < Array[left])
                {
                    helpArray[index++] = Array[right++];
                }
                else
                {
                    helpArray[index++] = Array[left++];
                }
            }

            for (int i = 0; i < index; i++)
            {
                Array[start + i] = helpArray[i];
                Show(start + i);
                Thread.Sleep(_delay);
            }
        }

        private void Sort(int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                Sort(start, mid);
                Sort(mid + 1, end);

                Merge(start, mid, end);
            }
        }

        void Show(int index)
        {
            DrawElement(GraphicTools.Black, index, true);
            DrawElement(GraphicTools.Green, index);
            Thread.Sleep(_delay * 2); //for visual effect
            DrawElement(GraphicTools.White, index);

        }
    }
}