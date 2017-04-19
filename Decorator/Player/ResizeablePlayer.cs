using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Decorator.Player;

namespace Decorator.PlayerComponent
{
	public class ResizeablePlayer : BasePlayer
	{
		public ResizeablePlayer(IMediaRender render) : base(render)
		{
		}
		public override void Play(string v)
		{
			this.Url = v;
			Thread playThread = new Thread(DoWork);
			playThread.Start();
		}
	}
}
