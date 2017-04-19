using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class ResizeableRender : IMediaRender
	{
		public IMediaRender Render { get; set; }
		public ResizeableRender(IMediaRender render)
		{
			this.Render = render;
		}

		public View View { get => this.Render.View; }

		public void AddAudioData(byte[] data)
		{
			this.Render.AddAudioData(data);
		}

		public void AddVideoData(byte[] data)
		{
			this.Render.AddVideoData(data);
		}
	}
}
