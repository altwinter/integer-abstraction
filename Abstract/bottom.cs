namespace Abstract
{
    public class Bottom : Value
    {

        private static readonly Bottom instance = new Bottom();
        private Bottom()
        {

        }

        public static Bottom Value
        {
            get
            {
                return instance;
            }
        }


        public override string StringRepresentation()
        {
            return "Ω";
        }
    }
}