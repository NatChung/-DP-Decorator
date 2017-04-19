using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public interface IMediaRender
	{
		void AddVideoData(byte[] data);
		void AddAudioData(byte[] data);
	}
}
