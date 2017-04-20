using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class JitterBuffer : MediaSourceDecorator
	{
		public JitterBuffer(IMediaSource source) : base(source)
		{
		}
	}
}
