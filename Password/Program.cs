namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityAttempts = 3;
            string password = "12345";
            string userInput;

            while (quantityAttempts > 0)
            {
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine("Пароль подобран!");
                }
                else
                {
                    quantityAttempts--;
                    Console.WriteLine("Введите пароль еще раз!");
                }
            }
        }
    }
}