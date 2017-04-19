using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Decorator.PlayerComponent;

namespace Decorator
{
	public class SimplePlayer
	{
		private IMediaRender Render { get; set; }
		public string Url { get; set; }

		public void Play(string v)
		{
			this.Url = v;
			AddSubview(this.Render.View);
			Play();
		}

		public SimplePlayer(IMediaRender render)
		{
			this.Render = render;
		}

		private void Play()
		{
			Thread playThread = new Thread(DoWork);
			playThread.Start();
		}

		private void AddSubview(View subview)
		{
		}

		private void DoWork()
		{
			while (true)
			{
				this.Render.AddVideoData(new byte[] {});
				this.Render.AddAudioData(new byte[] {});
				Thread.Sleep(1000);
			}
		}
	}
}
