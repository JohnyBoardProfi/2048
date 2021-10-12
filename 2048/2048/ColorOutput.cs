using System;

namespace _2048
{
    class ColorOutput : IDisposable
    { 
        public ColorOutput(ConsoleColor fg, ConsoleColor bg = ConsoleColor.Black)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
        }

        public void Dispose() => Console.ResetColor();
    }
}