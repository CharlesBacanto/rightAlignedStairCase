namespace rightAlignedStairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            static string step(int n, int m)
            {
                string stair = "";
                for (int i = 1; i <= m; i++)
                {
                    stair += ' ';
                }
                for (int j = 1; j <= n; j++)
                {
                    stair += '#';
                }
                return stair;
            }
            static void staircase(int n)
            {
                for(int i = 1; i <=n; i++)
                {
                    Console.WriteLine(step(i, n-i));
                }
            }

            staircase(5);

        }
    }
}