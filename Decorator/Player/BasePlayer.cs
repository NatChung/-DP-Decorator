﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Decorator.PlayerComponent;

namespace Decorator.Player
{
	public abstract class BasePlayer
	{
		protected IMediaRender Render { get; set; }
		protected string Url { get; set; }
		public BasePlayer(IMediaRender render)
		{
			this.Render = render;
			AddSubview(this.Render.View);
		}
		protected void AddSubview(View subview)
		{
		}
		public void Play(string v)
		{
			this.Url = v;
			DoWork();
		}
		
		protected void DoWork()
		{
			this.Render.AddVideoData(new byte[] { });
			this.Render.AddAudioData(new byte[] { });
		}

	}
}
