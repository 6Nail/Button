using System;
using System.Threading;

namespace Button
{
    class Program
    {
        static void Main(string[] args)
        {
            var buttonRandom = new Button()
            {
                Height = 7,
                Width = 13,
                Text = "Random",
                ColorForeground = ConsoleColor.White,
                ColorBackgroud = ConsoleColor.Blue
            };
            buttonRandom.OnClickEvent+= ShowRandomNumber;

            var buttonColor = new Button()
            {
                Height = 7,
                Width = 15,
                Text = "Emoji",
                ColorForeground = ConsoleColor.Green,
                ColorBackgroud = ConsoleColor.DarkCyan
            };
            buttonColor.OnClickEvent+=Smile;

            var buttonText = new Button()
            {
                Height = 5,
                Width = 13,
                Text = "Lmao",
                ColorForeground = ConsoleColor.Yellow,
                ColorBackgroud = ConsoleColor.Red
            };
            buttonText.OnClickEvent+=ShowText;

            var buttonBeep = new Button()
            {
                Height = 7,
                Width = 15,
                Text = "Wail",
                ColorForeground = ConsoleColor.DarkMagenta,
                ColorBackgroud = ConsoleColor.Yellow
            };
            buttonBeep.OnClickEvent+=Beep;

            ConsoleKeyInfo pressed;
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                buttonRandom.ShowButton();

                Console.SetCursorPosition(0, 8);
                buttonColor.ShowButton();

                Console.SetCursorPosition(0, 16);
                buttonText.ShowButton();

                Console.SetCursorPosition(0, 22);
                buttonBeep.ShowButton();

                pressed = Console.ReadKey();

                if (pressed.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 2);
                    buttonRandom.OnClick();

                    Console.SetCursorPosition(0, 10);
                    buttonColor.OnClick();

                    Console.SetCursorPosition(0, 18);
                    buttonText.OnClick();

                    Console.SetCursorPosition(0, 24); 
                    buttonBeep.OnClick();

                }
            }
        }
        public static void ShowRandomNumber()
        {
            var random = new Random();
            Console.Write(random.Next(0,13));
        }
        public static void Smile()
        {
            var random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: Console.Write(":)"); break;
                case 1: Console.Write(":("); break;
                case 2: Console.Write(":D"); break;
                case 3: Console.Write(":0"); break;
            }
            
        }
        public static void ShowText()
        {
            var random = new Random();
            switch (random.Next(0, 4))
            {
                case 0: Console.Write("Седня выходной?!"); break;
                case 1: Console.Write("Взял кредит в долларах"); break;
                case 2: Console.Write("Доллар Падает"); break;
                case 3: Console.Write("Че по чем!"); break;
            }
        }
        public static void Beep()
        {
            Console.Beep(37, 500);
        }
    }
}
