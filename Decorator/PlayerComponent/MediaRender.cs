using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class MediaRender
	{
		public View View { get; set; }
		internal void AddVideoData(byte[] v)
		{
			Console.WriteLine("Added video data");
		}

		internal void AddAudioData(byte[] v)
		{
			Console.WriteLine("Added audio data");
		}
	}
}
