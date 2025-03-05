using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessmentc_
{
    public interface IPlayable
    {
        void Play();
    }

    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music...");
        }
    }

    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }
    }

    public class Player : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }
    }

    
}
