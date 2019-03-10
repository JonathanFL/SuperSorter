using System;
using System.Linq;

namespace SuperSorter.Generating
{
    class ArrayGenerator : IArrayGenerator
    {
        public int[] Array { get; set; }

        private int _seed;
        private int _max;
        private int _size;

        public ArrayGenerator(int seed,int max, int sizeN)
        {
            _seed = seed;
            _max = max;
            _size = sizeN;
        }

        public int[] GenerateArray()
        {
            Random randNum = new Random(_seed);
            Array = Enumerable
                .Repeat(0, _size)
                .Select(i => randNum.Next(0, _max))
                .ToArray();
            return Array;
        }
    }
}
