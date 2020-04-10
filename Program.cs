using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

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
