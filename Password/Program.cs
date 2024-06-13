namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityAttempts = 3;
            string password = "12345";
            string userInput;

            for (int i = 0; i < quantityAttempts; i++)
            {
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Пароль подобран!");
                    return;
                }
                else
                {
                    Console.WriteLine("Введите пароль еще раз!");
                }
            }
        }
    }
}