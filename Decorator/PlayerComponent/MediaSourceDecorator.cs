using System;

namespace Decorator.PlayerComponent
{
	public class MediaSourceDecorator : IMediaSource
	{
		private IMediaSource mediaSource { get; set; }
		public Action<byte[]> OnVideoData { get; set; }
		public Action<byte[]> OnAudioData { get; set; }

		public MediaSourceDecorator(IMediaSource source)
		{
			this.mediaSource = source;
			OnVideoData = this.mediaSource.OnVideoData;
			OnAudioData = this.mediaSource.OnAudioData;
		}

		public virtual void AddVideoData(byte[] data)
		{
			this.mediaSource.AddVideoData(data);
		}

		public virtual void AddAudioData(byte[] data)
		{
			this.mediaSource.AddAudioData(data);
		}
	}
}