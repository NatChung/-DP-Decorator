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
		}

		[Fact]
		[Trait("Decorator", "Buffer + Resizeable Player")]
		public void BufferAndResizeablePlayer()
		{
			var expected = Substitute.For<IMediaRender>();
			ResizeableRender resizeableRender = new ResizeableRender(new BufferRender(expected));

			BufferAndResizeablePlayer sut = new BufferAndResizeablePlayer(resizeableRender);
			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
			var view = expected.Received().View;
		}

		[Fact]
		[Trait("Media source", "Decorator")]
		public void MediaSourceTest()
		{
			var gotVideo = false;
			var gotAudio = false;

			var sut = new MediaSource();
			sut.OnVideoData = (byte[] d) => gotVideo = true;
			sut.OnAudioData = (byte[] d) => gotAudio = true;

			sut.AddVideoData(new byte[] { });
			sut.AddAudioData(new byte[] { });

			Assert.True(gotVideo);
			Assert.True(gotAudio);
		}

		[Fact]
		[Trait("Media source with Decorator", "Decorator")]
		public void MediaSourceWithDecoratorTest()
		{
			var expected = Substitute.For<IMediaSource>();
			IMediaSource sut = new JitterBuffer(expected);
			
			sut.AddVideoData(new byte[] { });
			sut.AddAudioData(new byte[] { });

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
		}

		[Fact]
		[Trait("Media source with Decorator", "Decorator")]
		public void MediaSourceWithDecoratorTest2()
		{
			var expected =  new MediaSource();
			IMediaSource sut = new JitterBuffer(expected);

			var gotVideo = false;
			var gotAudio = false;

			expected.OnVideoData = (byte[] d) => gotVideo = true;
			expected.OnAudioData = (byte[] d) => gotAudio = true;

			sut.AddVideoData(new byte[] { });
			sut.AddAudioData(new byte[] { });

			Assert.True(gotVideo);
			Assert.True(gotAudio);
		}
	}
}
