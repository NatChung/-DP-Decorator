using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class MediaRender : IMediaRender
	{
		public View View { get; set; } = new View();

		public void AddAudioData(byte[] data)
		{
			
		}

		public void AddVideoData(byte[] data)
		{
			
		}
	}
}
