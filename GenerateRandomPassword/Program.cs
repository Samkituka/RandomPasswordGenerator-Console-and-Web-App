namespace GenerateRandomPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RandomPasswordGenerator randomPasswordGenerator = new RandomPasswordGenerator();
            string result;
            result = randomPasswordGenerator.RandomPassword(true, true, true, true, 10);

            Console.WriteLine("Hello, \n This Console Application generates random passwords for users. \n");
            Console.Write(" Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Username : {username}");
            Console.WriteLine($"Random Password: {result}");
            Console.ReadKey();
        }
    }
}