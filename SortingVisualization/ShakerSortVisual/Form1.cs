using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ShakerSortVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private int _n;
        private int[] _array;
        private Sort _sort;
        private int _elementThickness;
        private int _heightDifference; //between elements
        private GraphicTools _graphicTools;


        private int[] ArrayOfUniques()
        {
            var array = new int[_n];
            var unusedElements = new List<int>();
            var random = new Random();

            for (int i = 0; i < _n; i++)
            {
                unusedElements.Add(i);
            }

            int currentArrayIndex = 0;
            while (unusedElements.Count > 0)
            {
                int index = random.Next(unusedElements.Count);
                array[currentArrayIndex++] = unusedElements[index];
                unusedElements.RemoveAt(index);
            }

            return array;
        }

        private void ShowArray(Pen pen, int delay = 0, bool clearPictureBox = false)
        {
            if (clearPictureBox)
                pictureBox1.Refresh();

            for (int i = 0; i < _n; i++)
            {
                // I can't use sort.DrawElement method here because Show method is called before sort is initialized
                _graphicTools.@Graphics.DrawLine(pen,
                    (i + 0.5f) * _elementThickness, // had to move x by elementThickness/2 because first half of the first element
                    pictureBox1.Height,             // was outside of pictureBox, and there was an empty space after last element
                    (i + 0.5f) * _elementThickness,
                    pictureBox1.Height - _array[i] * _heightDifference);
                Thread.Sleep(delay); //when sorting is over I want to get that nice green elements animation, this delay helps with that, it's 0 when showing unsorted array in the begging
            }
        }


        private void FormArrayBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            _elementThickness = 10;
            _heightDifference = _elementThickness / 2;
            _n = pictureBox1.Width / _elementThickness;
            pictureBox1.SetBounds(20, 20, _n * _elementThickness, (_n - 1) * _heightDifference);
            _array = ArrayOfUniques();
            _graphicTools = new GraphicTools(_elementThickness)
            {
                @Graphics = pictureBox1.CreateGraphics(),
                @PictureBox = pictureBox1,
                HeightDifference = _heightDifference
            };

            ShowArray(_graphicTools.White, 0, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_sort.IsArraySorted())
            {
                _sort.OneStepOfSort();
            }
            else
            {
                ShowArray(_graphicTools.White); //getting rid of last red colored element in InserSort, or any colored elements
                ShowArray(_graphicTools.Green, 10);
                timer1.Stop();
            }

        }

        private void SortBTN_Click(object sender, EventArgs e)
        {
            if (doubleSelectionRB.Checked)
            {
                _sort = new DoubleSelectionSort(_array);
                timer1.Interval = 80;
            }

            if (insertionRB.Checked)
            {
                _sort = new InsertSort(_array);
                timer1.Interval = 15;
            }

            if (bubbleSortRB.Checked)
            {
                _sort = new BubbleSort(_array);
                timer1.Interval = 1;
            }

            if (mergeRB.Checked)
            {
                _sort = new MergeSort(_array);
            }

            if (!_sort.IsArraySorted())
            {
                _sort.GraphicTool = this._graphicTools;
                timer1.Start();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FormArrayBTN_Click(sender, e);
        }
    }
}
