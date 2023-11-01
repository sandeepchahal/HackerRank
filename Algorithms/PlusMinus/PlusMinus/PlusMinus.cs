
namespace PlusMinus
{
    public class Solution
    {
        public static void Execute(List<int> arr)
        {
            var negative = arr.Where(col => col < 0).ToList();
            var positive = arr.Where(col => col > 0).ToList();
            var zeros = arr.Where(col => col == 0).ToList();

            if (positive.Count > 0)
            {
                Console.WriteLine((Convert.ToDecimal(positive.Count) / Convert.ToDecimal(arr.Count)).ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");
            }
            if (negative.Count > 0)
            {
                Console.WriteLine((Convert.ToDecimal(negative.Count) / Convert.ToDecimal(arr.Count)).ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");

            }

            if (zeros.Count > 0)
            {
                Console.WriteLine((Convert.ToDecimal(zeros.Count) / Convert.ToDecimal(arr.Count)).ToString("N6"));
            }
            else
            {
                Console.WriteLine("0.000000");

            }

        }
    }
}
