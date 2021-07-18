using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRune.Services
{
    public class RandomService
    {
        public Random Random = new Random();

        public int Next(int max) => Random.Next(max);
    
        public int Next(int min, int max) => Random.Next(min, max);
    }
}
