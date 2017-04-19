using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public abstract class RenderDecorator : IMediaRender
	{
		public IMediaRender Render { get; set; }
		public View View { get => this.Render.View; }

		public RenderDecorator(IMediaRender render)
		{
			this.Render = render;
		}

		public virtual void AddAudioData(byte[] data)
		{
			this.Render.AddAudioData(data);
		}

		public virtual void AddVideoData(byte[] data)
		{
			this.Render.AddVideoData(data);
		}
	}
}
