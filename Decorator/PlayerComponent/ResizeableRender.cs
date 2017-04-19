using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class ResizeableRender : RenderDecorator
	{
		public ResizeableRender(IMediaRender render): base(render)
		{
			AddedTouchEvent(this.Render.View);
		}

		private void AddedTouchEvent(View view)
		{
		}
	}
}
