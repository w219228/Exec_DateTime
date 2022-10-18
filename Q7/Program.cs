using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;

			if(hour>=0&&hour<=11)
			{
				Console.WriteLine("現在是早上");
			}
			else if(hour>=12&&hour<=18)
			{
				Console.WriteLine("現在是中午");
			}
			else
			{
				Console.WriteLine("現在是晚上");
			}
		}
	}
}
