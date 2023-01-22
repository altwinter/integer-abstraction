namespace Abstract
{
    public class IntegerIntervalPace : Integer
    {
        public IntegerIntervalPace(int start, int last, int step)
        {
            begin = start;
            end = last;
            pace = step;
        }

        public override string StringRepresentation()
        {
            return "[" + Convert.ToString(begin) + ";" + Convert.ToString(end) + "] (" + Convert.ToString(pace) + ")";
        }

        public int Begin => begin;
        public int End => end;
        public int Pace => pace;

        private int begin;
        private int end;
        private int pace;
    }
}