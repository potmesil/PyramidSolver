using NUnit.Framework;
using PyramidSolver.Interfaces;
using PyramidSolver.Models;
using System;
using System.Collections.Generic;

namespace PyramidSolver
{
	[TestFixture]
    public class PyramidSolverTests
    {
        [Test]
        [TestCaseSource(nameof(GetSolvers))]
        public void Test(IPyramidSolver solver)
        {
	        var pyramid = new PyramidModel(new[,]
	        {
		        { 00059, 00207, 00098, 00095 },
		        { 00087, 00001, 00070, 0x000 },
		        { 00036, 00041, 0x000, 0x000 },
		        { 00023, 0x000, 0x000, 0x000 }
	        });
            var result = solver.PyramidMaximumTotal(pyramid);

            Console.WriteLine(pyramid);
            Console.WriteLine("Total : {0}", result);
            Console.WriteLine("Expected : {0}", 353);

            Assert.AreEqual(353, result);
        }

        private IEnumerable<IPyramidSolver> GetSolvers()
        {
			yield return new IterativePyramidSolver();
            yield return new RecursivePyramidSolver();
		}
    }
}