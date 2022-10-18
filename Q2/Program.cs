using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime returnBook = DateTime.Today.AddMonths(1);
			Console.WriteLine(returnBook);
		}
	}
}
