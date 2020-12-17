using System;

namespace KpIEp_Laba_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Character1 char1 = new Character1();
            Character2 char2 = new Character2();
            char1.random = new Random();
            char2.random = new Random();
            char1.HitNotify += DisplayMessage;
            char2.HitNotify += DisplayMessage;
            bool hod = false;

            Console.WriteLine("Чар1 бьет первым:");

            for (int i = 0; i < 50; i++)
            {
                char1.life = 135;
                char2.life = 150;
                while (char1.life > 0 && char2.life > 0)
                {
                    if (!hod)
                    {
                        char1.Hit(char2);
                        if (char2.Freze)
                        {
                            hod = false;
                        }
                        else
                        {
                            hod = true;
                        }
                    }
                    else
                    {
                        char2.Hit(char1);
                        if (char1.Freze == true)
                        {
                            hod = true;
                        }
                        else
                        {
                            hod = false;
                        }
                    }
                }
                if (char1.life < 0)
                {
                    char1.Dead();
                }
                else
                {
                    char2.Dead();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Чар2 бьет первым:");

            for (int i = 0; i < 50; i++)
            {
                char1.life = 135;
                char2.life = 150;
                while (char1.life > 0 && char2.life > 0)
                {
                    if (!hod)
                    {
                        char2.Hit(char1);
                        if (char1.Freze == true)
                        {
                            hod = true;
                        }
                        else
                        {
                            hod = false;
                        }

                    }
                    else
                    {
                        char1.Hit(char2);
                        if (char2.Freze)
                        {
                            hod = false;
                        }
                        else
                        {
                            hod = true;
                        }
                    }
                }
                if (char1.life < 0)
                {
                    char1.Dead();
                }
                else
                {
                    char2.Dead();
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
