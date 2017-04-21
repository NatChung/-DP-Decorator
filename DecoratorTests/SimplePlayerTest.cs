using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

			expect.ReceivedWithAnyArgs().AddVideoData(default(byte[]);
			expect.ReceivedWithAnyArgs().AddAudioData(default(byte[]);
		}
	}
}
