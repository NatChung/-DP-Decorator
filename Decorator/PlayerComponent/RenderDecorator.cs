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
		public IMediaSource MediaSource { get ; set; }

		public RenderDecorator(IMediaRender render)
		{
			this.Render = render;
			this.MediaSource = this.Render.MediaSource;
		}

	}
}
