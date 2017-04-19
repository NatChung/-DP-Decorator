using Decorator;
using Xunit;
using NSubstitute;
using Decorator.PlayerComponent;

namespace DecoratorTests
{
	public class SimplePlayerTest
	{
		[Fact]
		public void PlayTest()
		{
			var expected = Substitute.For<IMediaRender>();
			SimplePlayer sut = new SimplePlayer(expected);

			sut.Play("http://xxx.xxx");

			expected.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expected.ReceivedWithAnyArgs().AddAudioData(default(byte[]));

		}
	}
}
