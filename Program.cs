using System.Media;
using System.Runtime.InteropServices;

namespace BadToTheBoneRiff
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [DllImport("user32.dll")]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void Main(string[] args)
        {
            AllocConsole();

            IntPtr hwnd = FindWindow("ConsoleWindowClass", Console.Title);

            ShowWindow(hwnd, 0);

            SoundPlayer player = new SoundPlayer(@"sound.wav");

            while(true)
            {
                Random rand = new Random();

                int index = rand.Next(0, 6942069); // get random numbers
                Console.WriteLine(index);

                if (index == 1072842)
                {
                    player.Play();
                    int randtime = rand.Next(300000, 1500000); // 5-25 minutes wait time
                    Thread.Sleep(randtime);
                }
            }
        }
    }
}