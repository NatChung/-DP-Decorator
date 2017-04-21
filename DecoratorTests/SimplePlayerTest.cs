using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator;
using Decorator.PlayerComponent;
using NSubstitute;
using Xunit;

namespace DecoratorTests
{
	public class SimplePlayerTest
	{
		[Fact]
		[Trait("Player", "Decorator")]
		public void PlayerTest()
		{
			var expect = Substitute.For<IMediaRender>();

			var sut = new Player(expect);
			sut.Play();

			expect.ReceivedWithAnyArgs().AddVideoData(default(byte[]));
			expect.ReceivedWithAnyArgs().AddAudioData(default(byte[]));
		}

		[Fact]
		[Trait("Player", "Decorator")]
		public void PlayerAddSubViewTest()
		{
			var expect = Substitute.For<IMediaRender>();

			var sut = new Player(expect);

			var view = expect.ReceivedWithAnyArgs().View;
		}
	}
}
