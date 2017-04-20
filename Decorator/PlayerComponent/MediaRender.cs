using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class MediaRender : IMediaRender
	{
		public View View { get; set; }
		public IMediaSource MediaSource { get; set ; }

		public MediaRender(IMediaSource source)
		{
			this.View = new View();
			this.MediaSource = source;
			this.MediaSource.OnAudioData = AddAudioData;
			this.MediaSource.OnVideoData = AddVideoData;
		}
		public void AddVideoData(byte[] v)
		{
			Console.WriteLine("Added video data");
		}

		public void AddAudioData(byte[] v)
		{
			Console.WriteLine("Added audio data");
		}
	}
}
