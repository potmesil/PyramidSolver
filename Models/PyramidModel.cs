using System.Text;

namespace PyramidSolver.Models
{
	public class PyramidModel
	{
		private readonly int[,] _data;

		public PyramidModel(PyramidModel pyramid)
		{
			_data = (int[,])pyramid._data.Clone();
			Rows = pyramid.Rows;
		}

		public PyramidModel(int[,] data)
		{
			_data = data;
			Rows = data.GetLength(0);
		}

		public PyramidModel(int rows)
		{
			_data = new int[rows, rows];
			Rows = rows;
		}

		public int this[int row, int col]
		{
			get => _data[row, col];
			set => _data[row, col] = value;
		}

		public int Rows { get; }

		/// <summary>
		/// Pretty print me
		/// </summary>
		public override string ToString()
		{
			var sb = new StringBuilder();

			for (var row = 0; row < Rows; row++)
			{
				sb.Append(new string(' ', 9 * row / 2));

				for (var col = 0; col < Rows - row; col++)
				{
					sb.AppendFormat("[{0:00000}] ", _data[row, col]);
				}

				sb.AppendLine();
			}

			return sb.ToString();
		}
	}
}