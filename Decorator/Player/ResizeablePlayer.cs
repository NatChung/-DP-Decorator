using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class ResizeablePlayer
	{
		private ResizeableRender resizeableRender;

		public ResizeablePlayer(ResizeableRender resizeableRender)
		{
			this.resizeableRender = resizeableRender;
		}

		public void Play(string v)
		{
			throw new NotImplementedException();
		}
	}
}
