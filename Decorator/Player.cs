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
		private IMediaRender render;

		public Player(IMediaRender render)
		{
			this.render = render;
			AddSubview(this.render.View);
		}

		private void AddSubview(View view)
		{
			
		}

		public void Play()
		{
			this.render.AddAudioData(new byte[] { });
			this.render.AddVideoData(new byte[] { });
		}
	}
}
