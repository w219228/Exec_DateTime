using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int year = today.Year;
			int month = today.Month;
			DateTime dt = new DateTime(year, month, 1);
			DateTime dt1= dt.AddMonths(1);
			DateTime result = dt1.AddDays(-1);
			Console.WriteLine(result);
		}
	}
}
