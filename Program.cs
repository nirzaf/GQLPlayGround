namespace GQLPlayGround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.UtcNow.ToLocalTime();

            DateTime currentDate = DateTime.Now.ToUniversalTime().ToLocalTime();
            Console.WriteLine(currentDateTime);
            Console.WriteLine(currentDateTime.Kind);

            Console.WriteLine(currentDate);
            Console.WriteLine(currentDate.Kind);

            Console.ReadLine();
        }
    }
}