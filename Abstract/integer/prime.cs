namespace Abstract
{
    public class Prime : Integer
    {
        public Prime(int number)
        {
            value = number;
        }

        public override string StringRepresentation()
        {
            return Convert.ToString(value);
        }

        public int Value => value;

        private int value;
    }
}