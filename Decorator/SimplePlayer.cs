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
		public string Url { get; set; }
		private MediaRender Render { get; set; }
		public SimplePlayer(string url)
		{
			this.Url = url;
			this.Render = new MediaRender();
		}

		public void Play()
		{
			Thread playThread = new Thread(DoWork);
			playThread.Start();
		}

		private void DoWork()
		{
			while (true)
			{
				Thread.Sleep(1000);
				this.Render.AddVideoData(new byte[] {});
				this.Render.AddAudioData(new byte[] {});
			}
		}
	}
}
