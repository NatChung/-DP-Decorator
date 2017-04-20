using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public interface IMediaSource
	{
		void AddVideoData(byte[] data);
		void AddAudioData(byte[] data);
		Action<byte[]> OnVideoData { get; set; }
		Action<byte[]> OnAudioData { get; set; }
	}
}
