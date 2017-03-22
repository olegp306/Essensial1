using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Player : IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Start Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Play on Pause");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Play");
        }

        public void Record()
        {
            Console.WriteLine("Start Record");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record");
        }
    }
}
