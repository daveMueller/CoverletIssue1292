using Issue1292Repro;
using Xunit;

namespace Issue1292ReproTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Class1.DoSomething("hello"));
            Assert.True(Class1.DoSomething(null));
        }
    }
}