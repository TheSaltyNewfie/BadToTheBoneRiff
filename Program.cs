using System.Drawing.Printing;
using System.Media;

namespace BadToTheBoneRiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer(@"sound.wav");

            while(true)
            {
                Random rand = new Random();

                int index = rand.Next(0, 6942069);
                Console.WriteLine(index);

                if (index == 1072842)
                {
                    player.Play();
                    Thread.Sleep(300000);
                }
            }
        }
    }
}