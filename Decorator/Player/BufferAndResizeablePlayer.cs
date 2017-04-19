using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Decorator.PlayerComponent;

namespace Decorator.Player
{
	public class BufferAndResizeablePlayer : BasePlayer
	{
		public BufferAndResizeablePlayer(IMediaRender render) : base(render)
		{
		}
		
	}
}
