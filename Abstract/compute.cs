namespace Abstract
{
    public class Compute
    {
        private Compute()
        {
        }

        public static Value Eval(List<int> integers)
        {
            if (integers.Count == 0)
                return Bottom.Value;

            List<int> nums = integers.Distinct().ToList();
            nums.Sort();

            if (nums.Count == 1)
                return new Prime(nums.First());

            int step = 0;
            int prev = nums.First();
            int i = 1;

            while (i < nums.Count)
            {
                if (step == -1) break;

                if (step == 0)
                {
                    step = nums[i] - prev;
                }
                else
                {
                    step = ((nums[i] - prev) == step) ? step : -1;
                }

                prev = nums[i];
                ++i;
            }

            if (step == -1)
                return new IntegerInterval(nums.First(), nums.Last());

            return new IntegerIntervalPace(nums.First(), nums.Last(), step);
        }

    }
}