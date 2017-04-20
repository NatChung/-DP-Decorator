using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Player;
using Decorator.PlayerComponent;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			IMediaRender render = new ResizeableRender(new MediaRender(new JitterBuffer(new MediaSource())));
			BasePlayer BufferANdResizeablePlayer = new BasePlayer(render);

			Console.ReadLine();
		}
	}
}
