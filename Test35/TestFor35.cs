using System;
using NUnit.Framework;

namespace Test35
{
    [TestFixture]
    public class TestFor35
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual(new Version(2, 0, 0, 0), typeof(int).Assembly.GetName().Version);
        }
    }
}
