using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.PlayerComponent;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			SimplePlayer player = new SimplePlayer(new MediaRender());
			player.Play("http://127.0.0.1/source");

			Console.ReadLine();
		}
	}
}
