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
			BasePlayer sut = new BasePlayer(expected);

			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().MediaSource.AddAudioData(default(byte[]));
			expected.ReceivedWithAnyArgs().MediaSource.AddAudioData(default(byte[]));

		}

		[Fact]
		[Trait("Decorator", "MediaRender")]
		public void PlayConstrouctorTest()
		{
			var expected = Substitute.For<IMediaSource>();
			MediaRender sut = new MediaRender(expected);

			Assert.Equal(expected.OnAudioData.Method.Name, "AddAudioData");
			Assert.Equal(expected.OnVideoData.Method.Name, "AddVideoData");
		}

		[Fact]
		[Trait("Decorator", "Resizable player")]
		public void ResizeablePlayerTest()
		{
			var expected = Substitute.For<IMediaRender>();
			ResizeableRender resizeableRender = new ResizeableRender(expected);

			BasePlayer sut = new BasePlayer(resizeableRender);
			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().MediaSource.AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().MediaSource.AddAudioData(default(byte[]));
		}

		[Fact]
		[Trait("Decorator", "Resizable player")]
		public void ResizeablePlayerConstroucorTest()
		{
			var expected = Substitute.For<IMediaRender>();
			ResizeableRender resizeableRender = new ResizeableRender(expected);

			BasePlayer sut = new BasePlayer(resizeableRender);
			var view = expected.Received().View;
		}

		[Fact]
		[Trait("Media source", "Decorator")]
		public void MediaSourceVideoTest()
		{
			var gotVideo = false;

			var sut = new MediaSource();
			sut.OnVideoData = (byte[] d) => gotVideo = true;

			sut.AddVideoData(new byte[] { });

			Assert.True(gotVideo);
		}

		[Fact]
		[Trait("Media source", "Decorator")]
		public void MediaSourceAudioTest()
		{
			var gotAudio = false;

			var sut = new MediaSource();
			sut.OnAudioData = (byte[] d) => gotAudio = true;
			
			sut.AddAudioData(new byte[] { });
			
			Assert.True(gotAudio);
		}

		[Fact]
		[Trait("Media source with Decorator", "Decorator")]
		public void MediaSourceWithDecoratorTest()
		{
			var expected = Substitute.For<IMediaSource>();
			IMediaSource sut = new MediaSourceDecorator(expected);
			
			sut.AddVideoData(new byte[] { });
			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
		}

		[Fact]
		[Trait("Media source with Decorator", "Decorator")]
		public void MediaSourceWithDecoratorTest2()
		{
			var expected =  new MediaSource();
			IMediaSource sut = new MediaSourceDecorator(expected);
			
			var gotAudio = false;
			
			expected.OnAudioData = (byte[] d) => gotAudio = true;
			
			sut.AddAudioData(new byte[] { });
			
			Assert.True(gotAudio);
		}
	}
}
