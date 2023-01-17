using System;

namespace InterviewTasks.Recursiveness
{
    public static class Factorial
    {
        public static decimal Calculate(int n)
        {
            if (n == 0) return 1;
            var f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }

        /// <summary>
        /// Write factorial calculation function in a recursive manner
        /// See <see cref="Calculate"/> function above to see how Factorial is calculated using a loop
        /// Run tests from <see cref="FactorialTests"/> to make sure the implementation is correct
        /// </summary>
        public static decimal CalculateRecursive(int n)
        {
            throw new NotImplementedException();
        }
    }
}