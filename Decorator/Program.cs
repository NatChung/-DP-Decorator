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
			BufferAndResizeablePlayer player = new BufferAndResizeablePlayer(render);

			Console.ReadLine();
		}
	}
}
