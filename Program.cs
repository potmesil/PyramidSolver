using PyramidSolver.Helpers;
using PyramidSolver.Interfaces;
using PyramidSolver.Models;
using System;

namespace PyramidSolver
{
	internal class Program
	{
		private static void Main()
		{
			IPyramidGenerator generator = new RandomPyramidGenerator(5, 99);
			PyramidModel pyramid = generator.GeneratePyramid();
			IPyramidSolver solver = new IterativePyramidSolver(); // new RecursivePyramidSolver();

			Console.WriteLine(pyramid);
			Console.WriteLine($"Maximum path sum for this pyramid is: {solver.PyramidMaximumTotal(pyramid)}");

			Console.ReadLine();
		}
	}
}