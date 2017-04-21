using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class MediaSource : IMediaSource
	{
		public Action<byte[]> OnVideoData { get  ; set; }
		public Action<byte[]> OnAudioData { get ; set; }

		public void AddAudioData(byte[] data)
		{
			OnAudioData(data);
		}

		public void AddVideoData(byte[] data)
		{
			OnVideoData(data);
		}
	}
}
