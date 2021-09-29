namespace InterviewTasks.Recursiveness
{
    public static class Factorial
    {
        public static decimal Calculate(int n)
        {
            // TODO: rewrite as a recursive function
            if (n == 0) return 1;
            var f = 1;
            for (int i = 1; i <= n; i++)
                f *= i;
            return f;
        }
    }
}