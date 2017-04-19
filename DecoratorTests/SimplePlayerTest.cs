using Decorator;
using Xunit;
using NSubstitute;
using Decorator.PlayerComponent;
using System.Threading;
using Decorator.Player;

namespace DecoratorTests
{
	public class SimplePlayerTest
	{
		[Fact]
		[Trait("Decorator", "Simple player")]
		public void PlayTest()
		{
			var expected = Substitute.For<IMediaRender>();
			SimplePlayer sut = new SimplePlayer(expected);

			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
			var view = expected.Received().View;
			Thread.Sleep(100);

		}

		[Fact]
		[Trait("Decorator", "Resizable player")]
		public void ResizeablePlayerTest()
		{
			var expected = Substitute.For<IMediaRender>();
			ResizeableRender resizeableRender = new ResizeableRender(expected);

			ResizeablePlayer sut = new ResizeablePlayer(resizeableRender);
			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
			var view = expected.Received().View;
			Thread.Sleep(100);
		}

		[Fact]
		[Trait("Decorator", "Buffer player")]
		public void BufferPlayerTest()
		{
			var expected = Substitute.For<IMediaRender>();
			BufferRender bufferRender = new BufferRender(expected);

			BufferPlayer sut = new BufferPlayer(bufferRender);
			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
			var view = expected.Received().View;
			Thread.Sleep(100);
		}
	}
}
