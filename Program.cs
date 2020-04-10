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
    }
}
