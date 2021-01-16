using System;

namespace MaxSubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, -4, 6, -3, -2, 1, 3, -8 };
            int n = arr.Length;
            int max_sum = MaxSubArraySum(arr, 0, n - 1);

            Console.Write("Maximum sub array sum is " + max_sum);
        }


        static int MaxSubArraySum(int[] arr, int l, int h)
        {
            if (l == h)
                return arr[l];

            int m = (l + h) / 2;

            return Math.Max(Math.Max(MaxSubArraySum(arr, l, m),
                                  MaxSubArraySum(arr, m + 1, h)),
                                 MaxCrossingSum(arr, l, m, h));
        }

        static int MaxCrossingSum(int[] arr, int l, int m, int h)
        {
            int sum = 0;
            int left_sum = int.MinValue;
            for (int i = m; i >= l; i--)
            {
                sum = sum + arr[i];
                if (sum > left_sum)
                    left_sum = sum;
            }

            sum = 0;
            int right_sum = int.MinValue; ;
            for (int i = m + 1; i <= h; i++)
            {
                sum = sum + arr[i];
                if (sum > right_sum)
                    right_sum = sum;
            }

            return Math.Max(left_sum + right_sum, Math.Max(left_sum, right_sum));
        }
    }
}
