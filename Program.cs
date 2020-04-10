using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Player user1 = new Player();
            Console.WriteLine("Allowable players action: ");
            user1.Play();
            user1.Record();
            user1.Pause();
            user1.Stop();
        }
        interface IPlayable
        {
            void Play();
            void Pause();
            void Stop();
        } 
        interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();
        }
        class Player : IPlayable, IRecodable
        {
            public void Play()
            {
                Console.WriteLine("--play--");
            }
            public void Pause()
            {
                Console.WriteLine("--pause--");
            }
            public void Stop()
            {
                Console.WriteLine("--stop--");
            }
            public void Record()
            {
                Console.WriteLine("--record--");
            }
        }
    }
}
