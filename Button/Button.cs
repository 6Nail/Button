using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Button
{
    public class Button
    {
        public event Action OnClickEvent;

        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor ColorForeground { get; set; }
        public ConsoleColor ColorBackgroud { get; set; }
        public string Text { get; set; }


 
        public void ShowButton(bool action = false)
        {
            if (action) { Height -= Constants.changeSize; Width -= Constants.changeSize; }

            Console.ForegroundColor = ColorForeground;
            Console.BackgroundColor = ColorBackgroud;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (IsBorder(i,j))
                    {
                        Console.Write('*');
                    }
                    else if(IsCenterButton(i,j))
                    {
                        j += Text.Length - 1;
                        Console.Write(Text);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write("\n");
            }

            if (action) { Height += Constants.changeSize; Width += Constants.changeSize; }

            Console.ResetColor();
        }

        public void OnClick()
        {
            ShowButton(true);
            OnClickEvent?.Invoke();
        }

        public bool IsBorder(int height, int width)
        {
            return (height == 0 || height == Height - 1) || (width == 0 || width == Width - 1);
        }

     
        public bool IsCenterButton(int height, int width)
        {
            return width == Width / 2 - Text.Length / 2 && height == Height / 2;
        }
    }
}
