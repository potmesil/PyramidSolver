using Pyramid.Interfaces;
using Pyramid.Models;
using System;

namespace Pyramid.Helpers
{
	public class RandomPyramidGenerator : IPyramidGenerator
    {
        private readonly int _rows;
        private readonly int _range;
        private readonly Random _random;

        public RandomPyramidGenerator(int rows, int range)
        {
            _rows = rows;
            _range = range;
            _random = new Random();
        }

        public PyramidModel GeneratePyramid()
        {
            var pyramid = new PyramidModel(_rows);

            for (var row = 0; row < _rows; row++)
            {
                for (var col = 0; col < _rows - row; col++)
                {
                    pyramid[row, col] = _random.Next(1, _range);
                }
            }

            return pyramid;
        }
    }
}