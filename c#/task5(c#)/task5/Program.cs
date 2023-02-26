namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        //3reqemli ededin reqemleri cemi//
        {
            int num = 347;
            int rem;
            int sum = 0;
            while (num>0)
            {
                rem = num % 10;
                sum=sum + rem;
                num= num / 10;

            }
            Console.WriteLine(sum);
        }
    }
}