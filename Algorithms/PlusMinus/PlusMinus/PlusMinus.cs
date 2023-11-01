
namespace PlusMinus
{
    public class Solution
    {
        public static void Execute(List<int> arr)
        {
            var negative = arr.Where(col => col < 0).ToList();
            var positive = arr.Where(col => col > 0).ToList();
            var zeros = arr.Where(col => col == 0).ToList();

            if (negative.Count > 0)
            {
                decimal a =Convert.ToDecimal(negative.Count()) / Convert.ToDecimal(arr.Count());
                Console.WriteLine(a);
            }
            if (positive.Count > 0)
            {
                Console.WriteLine(positive.Count() / arr.Count());
            }
            if (zeros.Count > 0)
            {
                Console.WriteLine(zeros.Count() / arr.Count());
            }

        }
    }
}
