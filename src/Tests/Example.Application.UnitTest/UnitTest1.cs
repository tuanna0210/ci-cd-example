using FluentAssertions;

namespace Example.Application.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void DummyTest()
        {
            int num = 2;
            num.Should().Be(2);
        }
    }
}