namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> part = new List<int>();

            part.Add(10);
            part.Add(50);
            part.Add(20);
            part.Add(30);
            part.Add(40);

            Value val = Compute.Eval(part);

            Console.WriteLine(val.StringRepresentation());
        }
    }
}