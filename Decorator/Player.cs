using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.PlayerComponent;

namespace Decorator
{
	public class Player
	{
		private IMediaRender redner;

		public Player(IMediaRender render)
		{
			this.redner = render;
		}

		public void Play()
		{
			this.redner.AddAudioData(new byte[] { });
			this.redner.AddVideoData(new byte[] { });
		}
	}
}
