using Decorator;
using Xunit;
using NSubstitute;

namespace DecoratorTests
{
	public class SimplePlayerTest
	{
		[Fact]
		public void PlayTest()
		{
			var expected = Substitute.For<IMediaRender>();
			SimplePlayer sut = new SimplePlayer(expected);

			sut.Play();

			expected.ReceivedWithAnyArgs(1).AddVideoData(default(byte[]));
			expected.RecvivedWithAnyArgs(1).AddAudioData(default(byte[]));

		}
	}
}
