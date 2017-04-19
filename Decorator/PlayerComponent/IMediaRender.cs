using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public interface IMediaRender
	{
		View View { get;  }
		void AddVideoData(byte[] data);
		void AddAudioData(byte[] data);
	}
}
