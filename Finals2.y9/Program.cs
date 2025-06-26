namespace Finals2.y9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user1 = "Yusuf5";
            string pass1 = "33kk";
            string user2 = "Mary80";
            string pass2 = "af5r";

            string username  = "";
            string password = "";
            while((username != user1 || password != pass1) && (username != user2 || password != pass2))
            {
                Console.Write("Enter username: ");
                username = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if ((username == user1 && password == pass1) || (username == user2 && password == pass2))
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("Access denied");
                }
            }
    }
}
