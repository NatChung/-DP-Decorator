using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class View
	{
		public Action<View> OnTouchEvent { get; set; }
	}
}
