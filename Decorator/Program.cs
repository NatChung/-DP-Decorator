using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			SimplePlayer player = new SimplePlayer("http://127.0.0.1/source");
			player.Play();

			Console.ReadLine();
		}
	}
}
