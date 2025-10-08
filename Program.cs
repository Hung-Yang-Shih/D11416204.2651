namespace D11416204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入抵達時間");
                int a = int.Parse(Console.ReadLine());
            Console.WriteLine("輸入遲到時間");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("時間");
            Console.WriteLine(findDelayedArrivalTime(a, b));
            int findDelayedArrivalTime(int arrivalTime, int delayedTime)
            {
                //2651
                //1.輸入
                //int arrivalTime, delayedTime

                //2.處理
                int comput;
                comput = arrivalTime + delayedTime;
                comput = comput % 24;
                //3.輸出
                int result;
                result = comput;
                return result;
            }
        }
    }
}
