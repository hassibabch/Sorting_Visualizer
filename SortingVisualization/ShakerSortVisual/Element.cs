namespace ShakerSortVisual
{
    public struct Element //used to store index and value of biggest and smalled element during Double Selection Sort
    {
        public int Value { get; set; }
        public int Index { get; set; }

        public Element(int value, int index)
        {
            Value = value;
            Index = index;
        }

        public Element(Element element) : this(element.Value, element.Index)
        {

        }
    }
}