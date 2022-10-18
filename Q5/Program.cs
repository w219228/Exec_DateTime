using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime dt1 = new DateTime(2022, 12, 31);
			DateTime first = new DateTime(2022, 1, 1);
			DayOfWeek dayOfWeek1 = first.DayOfWeek;

			for (DateTime dt =new DateTime(2022,1,2);dt<=dt1; dt=dt.AddDays(7))
			{
				Console.WriteLine(dt);
			}
		}
	}
}
