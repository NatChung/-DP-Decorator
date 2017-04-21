﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.PlayerComponent
{
	public class ResizeableRender : IMediaRender
	{
		private IMediaRender render;

		public ResizeableRender(IMediaRender expect)
		{
			this.render = expect;
			this.render.View.OnTouchEvent = OnTouchEvent;
		}

		private void OnTouchEvent(View obj)
		{
			
		}

		public View View => throw new NotImplementedException();

		public void AddAudioData(byte[] data)
		{
			this.render.AddAudioData(data);
		}

		public void AddVideoData(byte[] data)
		{
			this.render.AddVideoData(data);
		}
	}
}