using Pyramid.Interfaces;
using Pyramid.Models;
using System;

namespace Pyramid
{
	public class RecursivePyramidSolver : IPyramidSolver
	{
		public long PyramidMaximumTotal(PyramidModel pyramid)
		{
			return GetTotalAbove(pyramid.Rows - 1, 0, pyramid);
		}

		private static long GetTotalAbove(int row, int column, PyramidModel pyramid)
		{
			if (row < 0)
			{
				return 0;
			}

			var myValue = pyramid[row, column];
			var left = myValue + GetTotalAbove(row - 1, column, pyramid);
			var right = myValue + GetTotalAbove(row - 1, column + 1, pyramid);

			return Math.Max(left, right);
		}
	}
}