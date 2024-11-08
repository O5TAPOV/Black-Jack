using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Game
    {
        public static void Run()
        {
            while (Restart())
            {

            }
            Exit();
        }

        private static bool Restart()
        {
            
            while (true)
            {
                Console.Write("Бажаєте почати гру знову?\n1 - так\n0 - ні: ");
                string str = Console.ReadLine();

                try
                {
                    return bool.Parse(str);
                }
                catch
                {
                    Console.Write("\nСталась помилка, спробуйте ще раз: ");
                }
            }
        }

        private static void Exit() 
        {
            Console.WriteLine("Дякую, що грали в мою гру! Для зв'язку пишіть в Telergam: @o5tapov");
            Environment.Exit(0); 
        }
    }
}
