using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class BufferRender : RenderDecorator
	{
		public BufferRender(IMediaRender render) : base(render)
		{
		}

		public override void AddAudioData(byte[] data)
		{
			base.AddAudioData(data);
			CacheData(data);
		}

		public override void AddVideoData(byte[] data)
		{
			base.AddVideoData(data);
			CacheData(data);
		}

		private void CacheData(byte[] data)
		{

		}
	}
}
