
namespace Abstract
{
    public class Top : Value
    {

        private static readonly Top instance = new Top();

        private Top()
        {

        }

        public static Top Value
        {
            get
            {
                return instance;
            }
        }

        public override string StringRepresentation()
        {
            return "α";
        }
    }
}