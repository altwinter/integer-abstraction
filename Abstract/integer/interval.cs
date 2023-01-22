namespace Abstract
{
    public class IntegerInterval : Integer
    {
        public IntegerInterval(int start, int last)
        {
            begin = start;
            end = last;
        }

        public override string StringRepresentation()
        {
            return "[" + Convert.ToString(begin) + ";" + Convert.ToString(end) + "]";
        }

        public int Begin => begin;
        public int End => end;

        private int begin;
        private int end;
    }
}