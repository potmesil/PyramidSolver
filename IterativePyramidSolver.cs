using Pyramid.Interfaces;
using Pyramid.Models;
using System;

namespace Pyramid
{
	public class IterativePyramidSolver : IPyramidSolver
    {
        public long PyramidMaximumTotal(PyramidModel pyramid)
        {            
            pyramid = new PyramidModel(pyramid); // Creating of new instance to preserve of changing source data array

            for (var row = 1; row < pyramid.Rows; row++)
            {
                for (var col = 0; col < pyramid.Rows - row; col++)
                {
                    pyramid[row, col] += Math.Max(pyramid[row - 1, col], pyramid[row - 1, col + 1]);
                }
            }

            return pyramid[pyramid.Rows - 1, 0];
        }
    }
}