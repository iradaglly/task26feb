namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {//task4-4reqemli ededi tersine cevir//
          int n=1343;
            int rem;
            int revNumber = 0;
            if (n < 0)
            {
                Console.WriteLine(false);
            }
            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                revNumber = (revNumber * 10) + rem;
            }
            Console.WriteLine(revNumber);

        }
    }
}