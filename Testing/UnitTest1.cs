using NUnit.Framework;
using Testing;
using ToTest;

namespace Testing
{
    public class EmacsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Class1 c = new Class1();
            Assert.True(c.aFunc());
        }
    }
}
