namespace task_if_else_switch_
{
    internal class Program
    {
        static void Main(string[] args)
        {//task1-4reqemli ededin palindrom olmasini teyin et//
            int num = 3223;
            int rem;
            int rev = 0;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            num = temp;
            if (num == rev)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
    }
